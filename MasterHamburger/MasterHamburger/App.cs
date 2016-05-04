using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm;
using MasterHamburger.Customization;
using MasterHamburger.Pages;
using MasterHamburger.ViewModels;
using Xamarin.Forms;

namespace MasterHamburger
{
    public class App : Application
    {
        public App()
        {
            GoToLogin();
        }

        public void GoToLogin()
        {
            var page = FreshPageModelResolver.ResolvePageModel<LoginViewModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
        }

        public void GoToMasterDetails()
        {
            var masterDetailNav = new CustomMasterDetailNavigationContainer();
            masterDetailNav.Init("Menu", "hamburger.png");
            masterDetailNav.AddPage<NewsViewModel>("News", null);
            masterDetailNav.AddPage<ContactsViewModel>("Contacts", null);
            MainPage = masterDetailNav;
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
