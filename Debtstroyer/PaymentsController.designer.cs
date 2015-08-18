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
	[Register ("PaymentsController")]
	partial class PaymentsController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCalc { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtMonthly { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtPrincipal { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtRate { get; set; }

		[Action ("btnCalc_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnCalc_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnCalc != null) {
				btnCalc.Dispose ();
				btnCalc = null;
			}
			if (txtMonthly != null) {
				txtMonthly.Dispose ();
				txtMonthly = null;
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
