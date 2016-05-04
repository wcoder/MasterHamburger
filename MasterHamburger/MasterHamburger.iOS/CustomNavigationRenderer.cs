using System;
using System.Collections.Generic;
using System.Text;
using MasterHamburger.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationRenderer))]

namespace MasterHamburger.iOS
{
    /// <summary>
    /// http://forums.xamarin.com/discussion/44586/navigationbar-background-image-renderer-android
    /// </summary>
    public class CustomNavigationRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.NavigationBar.BarTintColor = UIColor.FromPatternImage(UIImage.FromFile("topbar_bg@2x.png"));
        }
    }
}
