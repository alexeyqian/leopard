using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Leopard.Views
{
    public partial class CardCam : ContentPage
    {
        public CardCam()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.CardCamViewModel;
        }
    }
}
