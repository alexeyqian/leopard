using System;
using System.Windows.Input;
using Leopard.Models;
using Leopard.Services;
using Leopard.Utility;
using Xamarin.Forms;

namespace Leopard.ViewModels
{
    public class CardCameraViewModel : BaseViewModel
    {
        private INavigationService _navigationService;

       
        public ICommand TakePhotoCommand { get; }

        public CardCameraViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            TakePhotoCommand = new Command(OnTakePhotoCommand);

        }

        private void OnTakePhotoCommand()
        {
           

            //MessagingCenter.Send(this, MessageNames.ProjectChangedMessage, SelectedProject);
            //_navigationService.GoBack();
        }

        public override void Initialize(object parameter)
        {
           
        }

    }

}
