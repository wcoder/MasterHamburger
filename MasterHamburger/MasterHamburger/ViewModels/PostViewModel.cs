using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;

namespace MasterHamburger.ViewModels
{
    public class PostViewModel : BaseViewModel
    {
        private Post _post;

        public Post Post
        {
            get { return _post; }
            set { _post = value; RaisePropertyChanged(nameof(Post)); }
        }

        public override void Init(object initData)
        {
            Post = initData as Post;

            // TODO: check by null
        }
    }
}
