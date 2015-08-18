using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;

namespace Debtstroyer
{
	partial class LoginController : UIViewController
	{
		public LoginController (IntPtr handle) : base (handle)
		{
			Title = "Debstroyer";
		}

		public override void ViewDidLoad()
		{
			if (ParseUser.CurrentUser != null)
			{
				var home = Storyboard.InstantiateViewController ("home") as HomeController;
				NavigationController.PushViewController (home, true);
			}


		}


		async partial void btnLogin_TouchUpInside (UIButton sender)
		{
			btnLogin.Hidden = true;

			var user = txtUser.Text;
			var password = txtPassword.Text;
			var error = "Enter a valid Username and Password";

			var alert = new UIAlertView();

			if ((string.IsNullOrEmpty(user)) || (string.IsNullOrEmpty(password)))
			{
				alert = new UIAlertView("Login Failed", error, null, "Okay");
				alert.Show();
			}
			else
			{
				try
				{
					ParseUser myUser = await ParseUser.LogInAsync(user, password);
					var home = Storyboard.InstantiateViewController("home") as HomeController;
					NavigationController.PushViewController (home, true);
				}
				catch (ParseException f)
				{
					alert = new UIAlertView("Login Failed", error, null, "OK");
					alert.Show();
				}
				catch (Exception f)
				{
					alert = new UIAlertView("Login Failed", "Error- Please check your connectivity or try again later", null, "Okay");
					alert.Show();
				}
			}
			btnLogin.Hidden = false;
		}


		partial void btnCreate_TouchUpInside (UIButton sender)
		{
			 
		}
	}
}

