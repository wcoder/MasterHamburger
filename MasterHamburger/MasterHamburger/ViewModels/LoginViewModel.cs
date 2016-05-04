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
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(() => ((App)Application.Current).GoToMasterDetails());
        }
    }
}
