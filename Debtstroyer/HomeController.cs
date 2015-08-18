using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Debtstroyer
{
	partial class HomeController : UITabBarController
	{
		public HomeController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.NavigationItem.SetHidesBackButton (true, false);
		}
	}
}
