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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCreateAccount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtUser { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnCreateAccount != null) {
				btnCreateAccount.Dispose ();
				btnCreateAccount = null;
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
