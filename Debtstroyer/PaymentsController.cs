using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Debtstroyer
{
	partial class PaymentsController : UIViewController
	{
		public PaymentsController (IntPtr handle) : base (handle)
		{
		}

		partial void btnCalc_TouchUpInside (UIButton sender)
		{
			UIAlertView _error = new UIAlertView("Error", "Please fill in all fields with positive values", null, "OK", null);

			try
			{

			double interest = double.Parse (txtRate.Text);
			int principal = int.Parse (txtPrincipal.Text);
			int monthly = int.Parse (txtMonthly.Text);
			double rate = interest / 1200;

				double payments = (Math.Log(monthly) - Math.Log(monthly - (principal * rate))) / (Math.Log(1 + rate));
				decimal numberOfPayments = Convert.ToDecimal(payments);
				numberOfPayments = Math.Ceiling(numberOfPayments);


				UIAlertView good = new UIAlertView("Number of monthly payments (rounded up):", numberOfPayments.ToString(), null, "OK", null);
				
			good.Show();

			}

			catch (Exception)
			{

				_error.Show();

			}
			//double monthly = rate > 0 ? ((rate + rate / (Math.Pow (1 + rate, months) - 1)) * principal) : principal / months;



		}
	}
}
