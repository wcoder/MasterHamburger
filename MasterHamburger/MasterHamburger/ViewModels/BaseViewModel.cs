using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;

namespace MasterHamburger.ViewModels
{
    public abstract class BaseViewModel : FreshBasePageModel
    {
        protected string _title;

        public virtual string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(nameof(Title)); }
        }
    }
}
