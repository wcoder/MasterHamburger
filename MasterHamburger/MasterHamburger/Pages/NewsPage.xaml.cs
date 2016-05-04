using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterHamburger.ViewModels;
using Xamarin.Forms;

namespace MasterHamburger.Pages
{
    public partial class NewsPage : ContentPage
    {
        public static string PageTitle = "News";

        public NewsPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = sender as ListView;
            if (listView?.SelectedItem != null)
            {
                ((NewsViewModel) BindingContext).GoToPostCommand.Execute(listView.SelectedItem);

                // reset selection
                listView.SelectedItem = null;
            }
        }
    }
}
