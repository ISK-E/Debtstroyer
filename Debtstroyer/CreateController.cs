using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;

namespace Debtstroyer
{
	partial class CreateController : UIViewController
	{
		public CreateController (IntPtr handle) : base (handle)
		{
		}
		/// <summary>
		/// Buttons the create account touch up inside.
		/// </summary>
		/// <param name="sender">Sender.</param>
		async partial void btnCreateAccount_TouchUpInside (UIButton sender)
		{
			var firstName = txtFirstName.Text;
			var lastName = txtLastName.Text;
			var username = txtUser.Text;
			var password = txtPassword.Text;
			var confirmPassword = txtConfirm.Text;

			var alert = new UIAlertView();

			if ((string.IsNullOrEmpty(username)) || (string.IsNullOrEmpty(password)) ||
				(string.IsNullOrEmpty(firstName)) ||
				(string.IsNullOrEmpty(lastName)))

			{
				alert = new UIAlertView("Input Validation Failed", "Please complete all the input fields!", null, "OK");
				alert.Show();
			}
			else
			{
				if (password != confirmPassword)
				{
					alert = new UIAlertView("Input Validation Failed", "Password and Confirm Password must match!", null, "OK");
					alert.Show();
				}
				else
				{
					try
					{
						var user = new ParseUser()
						{
							Username = username,
							Password = password,
						
						} ;

						user["LastName"] = lastName;
						user["FirstName"] = firstName;

						await user.SignUpAsync();

						alert = new UIAlertView("Account Created", "Your account has been successfully created!", null, "OK");
						alert.Show();

						NavigationController.PopViewController (true);

					}
					catch(Exception ex)
					{
						var error = ex.Message;
						alert = new UIAlertView("Registration Failed", "Sorry, we might be experiencing some connectivity difficulties or your email is already in the system!", null, "OK");
						alert.Show();
					}
				}
			}
		}		
	}
}