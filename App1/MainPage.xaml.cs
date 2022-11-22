using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double amountLoan;
            int repaymentYear;
            double interest;

            bool isEmptyAmountLoan;

            isEmptyAmountLoan = string.IsNullOrEmpty(loanTextBox.Text);

            if (isEmptyAmountLoan)
            {
                var error_name = new MessageDialog("Name must be filled.");
                await error_name.ShowAsync();
                loanTextBox.Focus(FocusState.Programmatic);
                loanTextBox.SelectAll();
                return;
            }
            try
            {
                amountLoan = double.Parse(loanTextBox.Text);
            } catch (Exception exception)
            {
                // Display error
                var dialogMessage = new MessageDialog("Error! " + exception.Message);
                await dialogMessage.ShowAsync();

                // Select vechicle cost input field
                loanTextBox.Focus(FocusState.Programmatic);
                loanTextBox.SelectAll();
                return;
            }

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void displayButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
