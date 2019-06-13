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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInterfaceDevelopmentAssignment010.Menu
{
    /// <summary>
    /// Interaction logic for DebitCreditCardPayment.xaml
    /// </summary>
    public partial class DebitCreditCardPayment : UserControl
    {
        public DebitCreditCardPayment()
        {
            InitializeComponent();
            lblDebitTotal.Content = GlobalVariables.Total;
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxCardNumber.Text != "" && txtBoxNameOnCard.Text != "" && txtBoxSecurityCode.Text != "" && cboxMonth.Text != "" && cboxYear.Text != "")
                if (txtBoxCardNumber.Text.Length < 16 || txtBoxCardNumber.Text.Length > 16)
                    this.stackPanelIncorrectDetails.Visibility = Visibility.Visible;
                else if(txtBoxSecurityCode.Text.Length < 3 || txtBoxSecurityCode.Text.Length > 3)
                    this.stackPanelIncorrectDetails.Visibility = Visibility.Visible;
                else
                    Switcher.Switch(new Success());
            else
            {
                this.stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.GuestCheckout = true;
            Switcher.Switch(new Payment());
        }

        private void BtnCancel_OnClick_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Payment());
        }
    }
}
