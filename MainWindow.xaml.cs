using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace ContractClaimManager
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			LoadClaimHistory();
		}

		private void SubmitClaim_Click(object sender, RoutedEventArgs e)
		{
			string amount = txtClaimAmount.Text;
			string description = txtDescription.Text;

			// Handle claim submission logic (store data in DB or send it to a server)
			MessageBox.Show("Claim sunmitted successfully!");
			LoadClaimHistory();
		}

		private void UploadDocument_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			openFileDialog.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
			if (openFileDialog.ShowDialog() == true)
			{
				txtUploadedDocuments.Text = string.Join(", ", openFileDialog.FileNames);
				//To upload the documents to server or database
			}
		}

		private void LoadClaimHistory()
		{
			// Example data 
			var claims = new List<Claim>
			{
				new Claim {ClaimId = 1, Amount = 100.00m, Status = "Pending", SubmissionDate = DateTime.Now.ToString(), Documents = "doc1.pdf"},
				new Claim {ClaimId = 2, Amount = 150.00m, Status = "Approved", SubmissionDate = DateTime.Now.ToString(), Documents = "doc2.pdf"}
			};
			dgClaimHistory.ItemsSource = claims;
		}
	}

	public class Claim
	{
		public int ClaimId { get; set; }
		public decimal Amount { get; set; }
		public string Status { get; set; }
		public string SubmissionDate { get; set; }
		public string Documents { get; set; }
	}
}
