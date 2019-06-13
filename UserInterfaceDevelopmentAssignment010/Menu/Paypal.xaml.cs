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
    /// Interaction logic for Paypal.xaml
    /// </summary>
    public partial class Paypal : UserControl
    {
        public Paypal()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxEmailAddress.Text == "payment@email.com" && passwordBoxPassword.Password == "123456")
                Switcher.Switch(new Success());
            else
            {
                this.stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lblPaypalTotal.Content = GlobalVariables.Total;
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
