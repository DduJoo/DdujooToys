using DdujooToys.Core.Logger;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Login.Forms.UI
{
    public class LoginView : JamesContent
    {
        static LoginView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginView), new FrameworkPropertyMetadata(typeof(LoginView)));
        }

        public LoginView()
        {
            //인스턴스 생성 로그 작성.
            ActiveLogger.Singleton.Write("인스턴스 생성", this.GetType().Name);
        }
    }
}
