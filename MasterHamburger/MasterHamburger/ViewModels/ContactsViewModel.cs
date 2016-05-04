using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace MasterHamburger.ViewModels
{
    public class ContactsViewModel : BaseViewModel
    {
        public ICommand GoToAboutCommand { get; private set; }

        public ContactsViewModel()
        {
            Title = "Contacts";
            GoToAboutCommand = new Command(() => CoreMethods.PushPageModel<AboutViewModel>());
        }
    }
}
