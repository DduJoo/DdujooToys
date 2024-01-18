using Home.Forms.UI;
using Home.Forms.ViewModels;
using Jamesnet.Wpf.Global.Location;
using Login.Forms.UI;
using Login.Forms.ViewModels;
using MainFrame.Forms.UI;
using MainFrame.Forms.ViewModels;

namespace DdujooToys.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        /// <summary>
        /// View <-> ViewModel을 연결
        /// </summary>
        /// <param name="items"></param>
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainView, MainViewModel>();
            items.Register<LoginView, LoginViewModel>();
            items.Register<HomeView, HomeViewModel>();
        }
    }
}