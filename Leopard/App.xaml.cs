using System;
using Leopard.Services;
using Leopard.Utility;
using Leopard.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leopard
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; } = new NavigationService();
        public static ProjectDataService ProjectDataService { get; } = new ProjectDataService();

        public App()
        {
            InitializeComponent();

            NavigationService.Configure(ViewNames.ProjectListView, typeof(ProjectListView));
            NavigationService.Configure(ViewNames.ProjectDetailView, typeof(ProjectDetailView));

            MainPage = new NavigationPage(new ProjectListView()); 
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
