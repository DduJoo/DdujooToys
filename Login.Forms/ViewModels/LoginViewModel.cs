using CommunityToolkit.Mvvm.Input;
using DdujooToys.Core.Logger;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace Login.Forms.ViewModels
{
    public partial class LoginViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        private readonly IDialogService _dialogService;
        public LoginViewModel(IRegionManager regionManager, IContainerProvider containerProvider, IDialogService dialogService)
        {
            //인스턴스 생성 로그 작성.
            ActiveLogger.Singleton.Write("인스턴스 생성", this.GetType().Name);

            _regionManager = regionManager;
            _containerProvider = containerProvider;
            _dialogService = dialogService;
        }


        string Title = "";

        [RelayCommand]
        private void Login()
        {            
            var title = "dialog title";
            var message = "This is a message that should be shown in the dialog.";

            var param = new DialogParameters
            {
                {"title", title},
                {"message", message}
            };

            _dialogService.ShowDialog("Dialog", param, r =>
            {
                if (r.Result == ButtonResult.None)
                    Title = "Result is None";
                else if (r.Result == ButtonResult.OK)
                    Title = "Result is OK";
                else if (r.Result == ButtonResult.Cancel)
                    Title = "Result is Cancel";
                else
                    Title = "I Don't know what you did!?";
            });
        }
    }
}
 