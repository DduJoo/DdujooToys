using CommunityToolkit.Mvvm.Input;
using DdujooToys.Core.Logger;
using DdujooToys.Core.Names;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace MainFrame.Forms.ViewModels
{
    public partial class MainViewModel : IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        public MainViewModel()
        {
            //인스턴스 생성 로그 작성.
            ActiveLogger.Singleton.Write("인스턴스 생성", this.GetType().Name);
        }

        public MainViewModel(IRegionManager regionManager, IContainerProvider containerProvider) : this()
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(IViewable view)
        {            
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable LoginView = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(LoginView))
            {
                mainRegion.Add(LoginView);
            }

            mainRegion.Activate(LoginView);
            
        }

        [RelayCommand]
        private void Close()
        {
            Application.Current.Shutdown();
        }
    }
}
