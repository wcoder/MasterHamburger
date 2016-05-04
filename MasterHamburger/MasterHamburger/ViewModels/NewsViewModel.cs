using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace MasterHamburger.ViewModels
{
    public class Post
    {
        public string Title { get; set; }
    }

    public class NewsViewModel : BaseViewModel
    {
        public ObservableCollection<Post> News { get; }
        public ICommand GoToPostCommand { get; private set; }

        public NewsViewModel()
        {
            Title = "News";
            News = new ObservableCollection<Post>();
            GoToPostCommand = new Command<Post>(post => CoreMethods.PushPageModel<PostViewModel>(post));
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            for (int i = 0; i < 50; i++)
            {
                News.Add(new Post
                {
                    Title = $"News N.{i}"
                });
            }
        }
    }
}
