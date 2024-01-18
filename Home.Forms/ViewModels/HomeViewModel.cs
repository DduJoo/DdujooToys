using CommunityToolkit.Mvvm.Input;
using DdujooToys.Core.Logger;
using DdujooToys.Core.Names;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace Home.Forms.ViewModels
{
    public partial class HomeViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public HomeViewModel()
        {
            //인스턴스 생성 로그 작성.
            ActiveLogger.Singleton.Write("인스턴스 생성", this.GetType().Name);
        }

        public HomeViewModel(IRegionManager regionManager, IContainerProvider containerProvider) : this()
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Login()
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable LoginView = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(LoginView))
            {
                mainRegion.Add(LoginView);
            }

            mainRegion.Activate(LoginView);
        }
    }
}
