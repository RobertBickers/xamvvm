﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamvvm;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var factory = new XamvvmFormsFactory(this);

            factory.RegisterNavigationPage<MainNavigationPageModel,MainPageModel>();


            XamvvmCore.SetCurrentFactory(factory);


            var mainPage = XamvvmCore.CurrentFactory.GetPageFromCache<MainNavigationPageModel>() as Page;
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
