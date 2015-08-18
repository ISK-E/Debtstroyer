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
	[Register ("LoansController")]
	partial class LoansController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSave { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblPayments { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtMonths { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtPrincipal { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtRate { get; set; }

		[Action ("btnSave_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSave_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSave != null) {
				btnSave.Dispose ();
				btnSave = null;
			}
			if (lblPayments != null) {
				lblPayments.Dispose ();
				lblPayments = null;
			}
			if (txtMonths != null) {
				txtMonths.Dispose ();
				txtMonths = null;
			}
			if (txtPrincipal != null) {
				txtPrincipal.Dispose ();
				txtPrincipal = null;
			}
			if (txtRate != null) {
				txtRate.Dispose ();
				txtRate = null;
			}
		}
	}
}
