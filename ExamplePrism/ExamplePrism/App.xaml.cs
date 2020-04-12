using ExamplePrism.Interfaces;
using ExamplePrism.Services;
using ExamplePrism.ViewModels;
using ExamplePrism.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamplePrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer=null):base(initializer)
        {

        }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{Constants.Navigation}/{Constants.TabbedPage}");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();

            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<TodoPage, TodoViewModel>();

            //services
            containerRegistry.Register<IApiServices, ApiService>();
        }
        //public App()
        //{


        //    MainPage = new MainPage();
        //}

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
