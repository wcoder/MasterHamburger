using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using MasterHamburger.Pages;
using Xamarin.Forms;

namespace MasterHamburger.Customization
{
    public class CustomMasterDetailNavigationContainer : FreshMasterDetailNavigationContainer
    {
        // TODO: base _menuPage is private
        // https://github.com/rid00z/FreshMvvm/blob/master/src/FreshMvvm/FreshMasterDetailNavigationContainer.cs#L13
        protected override void CreateMenuPage(string menuPageTitle, string menuIcon = null)
        {
            var menuPage = new MenuPage(PageNames, ItemSelected);
            menuPage.Title = menuPageTitle;

            var navPage = new NavigationPage(menuPage) { Title = menuPageTitle };

            if (!string.IsNullOrEmpty(menuIcon))
                navPage.Icon = menuIcon;

            Master = navPage;
        }

        protected void ItemSelected(string pageName)
        {
            if (Pages.ContainsKey(pageName))
            {
                Detail = Pages[pageName];
            }

            IsPresented = false;
        }
    }
}
