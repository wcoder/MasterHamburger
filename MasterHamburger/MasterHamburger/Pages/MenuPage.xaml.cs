using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterHamburger.Pages
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage(ObservableCollection<string> pageNames, Action<string> itemSelectedCallback)
        {
            InitializeComponent();

            ListViewMenu.ItemsSource = pageNames;
            ListViewMenu.ItemSelected += (sender, args) => itemSelectedCallback(args.SelectedItem.ToString());
        }
    }
}
