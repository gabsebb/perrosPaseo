﻿using perrosPaseo.Services;
using perrosPaseo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace perrosPaseo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Shell.Current.GoToAsync("//LoginPage");
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
