﻿using ElectroneumSpace.Services;
using ElectroneumSpace.Utilities;
using ElectroneumSpace.Views;

using Microsoft.Practices.Unity;

using Prism.Logging;
using Prism.Unity;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ElectroneumSpace
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            // Bind current thread as main thread
            ThreadUtils.Setup();

            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<ILoggerFacade, LoggerFacade>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IPoolService, PoolService>(new ContainerControlledLifetimeManager());

            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<AddWalletPage>();
        }
    }
}
