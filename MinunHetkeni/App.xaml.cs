﻿using System;
using MediaManager;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinunHetkeni
{
    public partial class App : Application
    {




        public App()
        {
            InitializeComponent();

            MainPage = new AppShellPage();
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
