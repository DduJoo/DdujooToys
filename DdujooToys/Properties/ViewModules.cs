using DdujooToys.Core.Names;
using Dialog.Forms.ViewModels;
using Dialog.Forms.Views;
using Home.Forms.UI;
using Jamesnet.Wpf.Controls;
using Login.Forms.UI;
using Prism.Ioc;
using Prism.Modularity;

namespace DdujooToys.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider){}

        /// <summary>
        /// Content View Singleton 등록
        /// </summary>
        /// <param name="containerRegistry"></param>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, LoginView>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, HomeView>(ContentNameManager.Home);

            containerRegistry.RegisterDialog<DialogView, DialogViewModel>("Dialog");
        }
    }
}
