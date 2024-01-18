using Serilog.Templates;
using Serilog;
using System.Diagnostics;
using System.Reflection;

namespace DdujooToys.Core.Logger
{
    /// <summary>
    /// Only Information Log
    /// </summary>
    public class ActiveLogger
    {
        #region Singleton
        public static ActiveLogger Singleton { get; private set; }

        static ActiveLogger()
        {
            Singleton = new ActiveLogger();
        }
        private ActiveLogger() { }
        #endregion

        public void Write(string message, string instanceName = "")
        {
            using (var log = new LoggerConfiguration()
               .MinimumLevel.Information()
               .WriteTo.File
               (
                new ExpressionTemplate("[{@t:yyyy-MM-dd HH:mm:ss}] [{@l:u3}] {#if SourceContext is not null} [{SourceContext}] {#end} {@m}\n{@x}"),
                AppDomain.CurrentDomain.BaseDirectory + @"Log\ActiveLog.txt",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 62 //Log 폴더 안의 최대 파일 개수.
               )
               .CreateLogger())
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase methodBase = stackFrame.GetMethod();

                if(string.IsNullOrEmpty(instanceName))
                    log.Information($"[{methodBase.DeclaringType.Name}.{methodBase.Name}] {message} ");
                else
                    log.Information($"[{instanceName}] {message} ");
            }
        }
    }
}
