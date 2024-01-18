using DdujooToys.Core.Logger;
using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Home.Forms.UI
{
    public class HomeView : JamesContent
    {
        static HomeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HomeView), new FrameworkPropertyMetadata(typeof(HomeView)));
        }

        public HomeView()
        {
            //인스턴스 생성 로그 작성.
            ActiveLogger.Singleton.Write("인스턴스 생성", this.GetType().Name);
        }
    }
}
