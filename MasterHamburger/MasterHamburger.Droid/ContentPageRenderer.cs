using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MasterHamburger.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


//TODO:
//[assembly: ExportRenderer(typeof(ContentPage), typeof(ContentPageRenderer))]

namespace MasterHamburger.Droid
{
    /// <summary>
    /// http://forums.xamarin.com/discussion/44586/navigationbar-background-image-renderer-android
    /// </summary>
    public class ContentPageRenderer : PageRenderer
    {
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            var actionBar = ((Activity)Context).ActionBar;
            actionBar.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.naturenature));
        }
    }
}