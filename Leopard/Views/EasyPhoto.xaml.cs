using System;
using System.Collections.Generic;
using Plugin.Media;
using Xamarin.Forms;

namespace Leopard.Views
{
    public partial class EasyPhoto : ContentPage
    {
        public EasyPhoto()
        {
            InitializeComponent();
        }

        async void btnTakePhoto_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions()
                {
                    DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Front,
                    Directory = "EasyPhoto",
                    SaveMetaData = true,
                });

                if(photo != null)
                {
                    imgCamera.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
                }

            }catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
    }
}
