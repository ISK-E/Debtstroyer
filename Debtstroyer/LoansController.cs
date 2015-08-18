using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;

namespace Debtstroyer
{
	partial class LoansController : UIViewController
	{
		public LoansController (IntPtr handle) : base (handle)
		{

		}

		//method is for eventual data grid output
		public void MonthlyDetails(double principal, double interest, int months, double monthly)
		{
			var endingBalance = principal;
			double rate = interest/1200.0;
			var count = 1;
			while (count <= months)
			{
				var interestPaid = endingBalance*rate;
				var principlePaid = monthly - interestPaid;
				endingBalance -= principlePaid;
				//CreateRow(count, String.Format("{0:C}", interestPaid), String.Format("{0:C}",
					//principlePaid),String.Format("{0:C}", endingBalance), count++);
			} 


		
		}

		partial void btnSave_TouchUpInside (UIButton sender)
		{

			UIAlertView _error = new UIAlertView("Error", "Please fill in all fields with positive values", null, "OK", null);


			try
			{
			var interest = double.Parse (txtRate.Text);
			var months = int.Parse (txtMonths.Text);
			var principal = double.Parse (txtPrincipal.Text);
			double rate = interest / 1200;
			double monthly = rate > 0 ? ((rate + rate / (Math.Pow (1 + rate, months) - 1)) * principal) : principal / months;
			int monthlyPayment = Convert.ToInt32(monthly);

			UIAlertView good = new UIAlertView("Required monthly payment:", "$" + monthlyPayment.ToString(), null, "OK", null);
			good.Show();
			}

			catch (Exception)
			{
				
				_error.Show();

			}



		}
	}
}
