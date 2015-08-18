// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Debtstroyer
{
	[Register ("CreateController")]
	partial class CreateController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCreateAccount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtConfirm { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtFirstName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtLastName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtUser { get; set; }

		[Action ("btnCreateAccount_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnCreateAccount_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnCreateAccount != null) {
				btnCreateAccount.Dispose ();
				btnCreateAccount = null;
			}
			if (txtConfirm != null) {
				txtConfirm.Dispose ();
				txtConfirm = null;
			}
			if (txtFirstName != null) {
				txtFirstName.Dispose ();
				txtFirstName = null;
			}
			if (txtLastName != null) {
				txtLastName.Dispose ();
				txtLastName = null;
			}
			if (txtPassword != null) {
				txtPassword.Dispose ();
				txtPassword = null;
			}
			if (txtUser != null) {
				txtUser.Dispose ();
				txtUser = null;
			}
		}
	}
}
