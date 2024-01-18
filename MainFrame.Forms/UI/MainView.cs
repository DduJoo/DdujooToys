using DdujooToys.Core.Logger;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace MainFrame.Forms.UI
{
    public class MainView : JamesWindow
    {
        static MainView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
        }

        public MainView()
        {
            //인스턴스 생성 로그 작성.
            ActiveLogger.Singleton.Write("인스턴스 생성", this.GetType().Name);
            this.WindowStyle = WindowStyle.None;
        }
    }
}
