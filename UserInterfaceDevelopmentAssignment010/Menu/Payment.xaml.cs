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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();

            if(GlobalVariables.LoggedIn == true)
            {
                txtBoxFirstName.Text = GlobalVariables.LoginFirstName;
                txtBoxLastName.Text = GlobalVariables.LoginSecondName;
                txtBoxEmail.Text = GlobalVariables.LoginEmail;
            }
            else if (GlobalVariables.Registered == true)
            {
                txtBoxFirstName.Text = GlobalVariables.RegisterFirstName;
                txtBoxLastName.Text = GlobalVariables.RegisterLastName;
                txtBoxEmail.Text = GlobalVariables.RegisterEmail;
            }
            else if (GlobalVariables.GuestCheckout == true)
            {
                txtBoxFirstName.Text = GlobalVariables.GuestFirstName;
                txtBoxLastName.Text = GlobalVariables.GuestLastName;
                txtBoxEmail.Text = GlobalVariables.GuestEmail;
            }
        }

        private void btnPayWithPaypal_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxFirstName.Text.Trim().Length == 0 && txtBoxLastName.Text.Trim().Length == 0 &&
                txtBoxEmail.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text =
                    "You have not completed the required fields. Please enter your personal details in the fields bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxFirstName.Text.Trim().Length == 0 && txtBoxLastName.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your first name and the last name in the fields bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxLastName.Text.Trim().Length == 0 && txtBoxEmail.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your last name and the email in the fields bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxFirstName.Text.Trim().Length == 0 && txtBoxEmail.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your first name and the email in the fields bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxFirstName.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your first name in the field bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxLastName.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your last name in the field bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxEmail.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your email address in the field bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else
            {
                GlobalVariables.paymentMethod = "Paypal";
                GlobalVariables.GuestFirstName = txtBoxFirstName.Text;
                GlobalVariables.GuestLastName = txtBoxLastName.Text;
                GlobalVariables.GuestEmail = txtBoxEmail.Text;
                Switcher.Switch(new Paypal());
            }
            
        }

        private void btnPayWithDebitCreditCard_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxFirstName.Text.Trim().Length == 0 && txtBoxLastName.Text.Trim().Length == 0 &&
                txtBoxEmail.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text =
                    "You have not completed the required fields. Please enter your personal details in the fields bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxFirstName.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your first name in the field bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxLastName.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your last name in the field bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxEmail.Text.Trim().Length == 0)
            {
                txtBlockErrorMessage.Text = "Please enter your email address in the field bellow.";
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else
            {
                GlobalVariables.paymentMethod = "Debit\\Credit Card";
                GlobalVariables.GuestFirstName = txtBoxFirstName.Text;
                GlobalVariables.GuestLastName = txtBoxLastName.Text;
                GlobalVariables.GuestEmail = txtBoxEmail.Text;
                Switcher.Switch(new DebitCreditCardPayment());
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Seats());
        }

        private void BtnCancel_OnClick_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.adultTickets = 0;
            GlobalVariables.childTickets = 0;
            GlobalVariables.seniorTickets = 0;
            GlobalVariables.studentTickets = 0;
            GlobalVariables.numberOfTicketsPurchased = 0;
            GlobalVariables.LoggedIn = false;
            GlobalVariables.Registered = false;
            GlobalVariables.GuestCheckout = false;

            Seats.seatsAvailable = 0;
            Seats.seatA1Selected = "not selected";
            Seats.seatA2Selected = "not selected";
            Seats.seatA3Selected = "not selected";
            Seats.seatA4Selected = "not selected";
            Seats.seatA5Selected = "not selected";
            Seats.seatA6Selected = "not selected";
            Seats.seatA7Selected = "not selected";
            Seats.seatA8Selected = "not selected";
            Seats.seatA9Selected = "not selected";
            Seats.seatB1Selected = "not selected";
            Seats.seatB2Selected = "not selected";
            Seats.seatB3Selected = "not selected";
            Seats.seatB4Selected = "not selected";
            Seats.seatB5Selected = "not selected";
            Seats.seatB6Selected = "not selected";
            Seats.seatB7Selected = "not selected";
            Seats.seatB8Selected = "not selected";
            Seats.seatB9Selected = "not selected";

            Seats.seatC1Selected = "not selected";
            Seats.seatC2Selected = "not selected";
            Seats.seatC3Selected = "not selected";
            Seats.seatC4Selected = "not selected";
            Seats.seatC5Selected = "not selected";
            Seats.seatC6Selected = "not selected";
            Seats.seatC7Selected = "not selected";
            Seats.seatC8Selected = "not selected";
            Seats.seatC9Selected = "not selected";

            Seats.seatD1Selected = "not selected";
            Seats.seatD2Selected = "not selected";
            Seats.seatD3Selected = "not selected";
            Seats.seatD4Selected = "not selected";
            Seats.seatD5Selected = "not selected";
            Seats.seatD6Selected = "not selected";
            Seats.seatD7Selected = "not selected";
            Seats.seatD8Selected = "not selected";
            Seats.seatD9Selected = "not selected";
            Seats.seatE1Selected = "not selected";
            Seats.seatE2Selected = "not selected";
            Seats.seatE3Selected = "not selected";
            Seats.seatE4Selected = "not selected";
            Seats.seatE5Selected = "not selected";
            Seats.seatE6Selected = "not selected";
            Seats.seatE7Selected = "not selected";
            Seats.seatE8Selected = "not selected";
            Seats.seatE9Selected = "not selected";

            Seats.seatsSelected = new List<string>();

            GlobalVariables.GuestFirstName = "";
            GlobalVariables.GuestLastName = "";
            GlobalVariables.GuestEmail = "";

            Switcher.Switch(new MainMenu());
        }
    }
}
