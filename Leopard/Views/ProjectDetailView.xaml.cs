using System;
using System.Collections.Generic;
using Leopard.Utility;
using Xamarin.Forms;

namespace Leopard.Views
{
    public partial class ProjectDetailView : ContentPage
    {
        public ProjectDetailView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.ProjectDetailViewModel;
        }
    }
}
