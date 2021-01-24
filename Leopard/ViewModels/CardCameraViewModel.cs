using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Leopard.Models;
using Leopard.Services;
using Leopard.Utility;
using Plugin.Media;
using Xamarin.Forms;

namespace Leopard.ViewModels
{
    public class CardCameraViewModel : BaseViewModel
    {
        private INavigationService _navigationService;
        private StreamImageSource _stImageSource;

        public StreamImageSource StImageSource
        { 
            get => _stImageSource;
            set
            {
                _stImageSource = value;
                OnPropertyChanged(nameof(StImageSource));
            }
        }

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

        public override void InitializeAsync(object parameter)
        {
            
        }

    }

}
