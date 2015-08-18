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
	[Register ("LoginController")]
	partial class LoginController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCreate { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtUser { get; set; }

		[Action ("btnCreate_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnCreate_TouchUpInside (UIButton sender);

		[Action ("btnLogin_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnLogin_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnCreate != null) {
				btnCreate.Dispose ();
				btnCreate = null;
			}
			if (btnLogin != null) {
				btnLogin.Dispose ();
				btnLogin = null;
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
