using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContractClaimManager
{
	/// <summary>
	/// Interaction logic for Coordinator.xaml
	/// </summary>
	public partial class Coordinator : Window
	{
		public Coordinator()
		{
			InitializeComponent();
			LoadPendingClaims();
		}

		private void ApproveClaim_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Claim Approved!");
			LoadPendingClaims();
		}

		private void RejectClaim_Click(Object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Claim Rejected!");
			LoadPendingClaims();
		}

		private void LoadPendingClaims()
		{
			// Example data
			var claims = new List<Claim>
			{
				new Claim{ ClaimId = 1, Amount = 100.00m, SubmissionDate = DateTime.Now.ToString(), Documents = "doc1.pdf" },
				new Claim{ ClaimId = 2, Amount = 150.00m, SubmissionDate = DateTime.Now.ToString(), Documents = "doc2.pdf" }
			};
			dgPendingClaims.ItemsSource = claims;
		}
    }
}
