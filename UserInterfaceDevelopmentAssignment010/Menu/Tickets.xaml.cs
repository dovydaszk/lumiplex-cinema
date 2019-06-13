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
    /// Interaction logic for Tickets.xaml
    /// </summary>
    public partial class Tickets : UserControl, ISwitchable
    {
        public static decimal tempAdultTicketsSubTotal = 0.0m;
        public static decimal tempChildrenTicketsSubTotal = 0.0m;
        public static decimal tempSeniorTicketsSubTotal = 0.0m;
        public static decimal tempStudentTicketsSubTotal = 0.0m;
        public static bool adultTicketChanged = false;
        public static bool childTicketChanged = false;
        public static bool seniorTicketChanged = false;
        public static bool studentTicketChanged = false;

        public Tickets()
        {
            InitializeComponent();

            if (GlobalVariables.seatsBackButtonPressed == true)
            {
                cboAdultQuantity.Text = Convert.ToString(GlobalVariables.adultTickets);
                cboChildQuantity.SelectedValue = GlobalVariables.childTickets;
                cboSeniorQuantity.SelectedValue = GlobalVariables.seniorTickets;
                cboStudentQuantity.SelectedValue = GlobalVariables.studentTickets;

                txtBlockAdultSubtotal.Text = Convert.ToString(decimal.Parse(txtBlockAdultPrice.Text) * int.Parse(cboAdultQuantity.Text));
                txtBlockChildSubtotal.Text = Convert.ToString(decimal.Parse(txtBlockChildPrice.Text) * int.Parse(cboChildQuantity.Text));
                txtBlockSeniorSubtotal.Text = Convert.ToString(decimal.Parse(txtBlockSeniorPrice.Text) * int.Parse(cboSeniorQuantity.Text));
                txtBlockStudentSubtotal.Text = Convert.ToString(decimal.Parse(txtBlockStudentPrice.Text) * int.Parse(cboStudentQuantity.Text));

                int adultTicketQuantity = int.Parse(cboAdultQuantity.SelectedValue.ToString());
                int childTicketQuantity = int.Parse(cboChildQuantity.SelectedValue.ToString());
                int seniorTicketQuantity = int.Parse(cboSeniorQuantity.SelectedValue.ToString());
                int studentTicketQuantity = int.Parse(cboStudentQuantity.SelectedValue.ToString());

                if (adultTicketQuantity > 0)
                {
                    this.stackPanelAdultTickets.Visibility = Visibility.Visible;
                    lblNumberOfAdultTickets.Content = "Adult: " + cboAdultQuantity.SelectedValue.ToString();
                }
                else if(adultTicketQuantity == 0)
                {
                    this.stackPanelAdultTickets.Visibility = Visibility.Collapsed;
                    lblNumberOfAdultTickets.Content = "Adult: " + cboAdultQuantity.SelectedValue.ToString();
                }
                if (childTicketQuantity > 0)
                {
                    this.stackPanelChildrenTickets.Visibility = Visibility.Visible;
                    lblNumberOfChildTickets.Content = "Child: " + cboChildQuantity.SelectedValue.ToString();
                }
                else if (childTicketQuantity == 0)
                {
                    this.stackPanelChildrenTickets.Visibility = Visibility.Collapsed;
                    lblNumberOfChildTickets.Content = "Child: " + cboChildQuantity.SelectedValue.ToString();
                }
                if (seniorTicketQuantity > 0)
                {
                    this.stackPanelSeniorTickets.Visibility = Visibility.Visible;
                    lblNumberOfSeniorsTickets.Content = "Senior: " + cboSeniorQuantity.SelectedValue.ToString();
                }
                else if (seniorTicketQuantity == 0)
                {
                    this.stackPanelSeniorTickets.Visibility = Visibility.Collapsed;
                    lblNumberOfSeniorsTickets.Content = "Senior: " + cboSeniorQuantity.SelectedValue.ToString();
                }
                if (studentTicketQuantity > 0)
                {
                    this.stackPanelStudentTickets.Visibility = Visibility.Visible;
                    lblNumberOfStudentsTickets.Content = "Student: " + cboStudentQuantity.SelectedValue.ToString();
                }
                else if (studentTicketQuantity < 0)
                {
                    this.stackPanelStudentTickets.Visibility = Visibility.Collapsed;
                    lblNumberOfStudentsTickets.Content = "Student: " + cboStudentQuantity.SelectedValue.ToString();
                }

                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();

                GlobalVariables.seatsBackButtonPressed = false;
            }
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void cboAdultQuantity_DropDownClosed(object sender, EventArgs e)
        {

            decimal ticketPrice = decimal.Parse(txtBlockAdultPrice.Text);
            int quantity = int.Parse(cboAdultQuantity.Text);
            decimal subTotal = ticketPrice * quantity;

            txtBlockAdultSubtotal.Text = subTotal.ToString();
            

            int ticketQuantity = int.Parse(cboAdultQuantity.SelectedValue.ToString());

            if(ticketQuantity > 0)
            {
                this.stackPanelAdultTickets.Visibility = Visibility.Visible;
                lblNumberOfAdultTickets.Content = "Adult: " + cboAdultQuantity.SelectedValue.ToString();
            }
            else
            {
                this.stackPanelAdultTickets.Visibility = Visibility.Collapsed;
                lblNumberOfAdultTickets.Content = "Adult: " + cboAdultQuantity.SelectedValue.ToString();
            }

            if(adultTicketChanged != true)
            {
                tempAdultTicketsSubTotal = decimal.Parse(txtBlockAdultSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockAdultSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
                adultTicketChanged = true;
            }
            else
            {
                GlobalVariables.Total -= tempAdultTicketsSubTotal;
                tempAdultTicketsSubTotal = decimal.Parse(txtBlockAdultSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockAdultSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
            }
            
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.numberOfTicketsPurchased = int.Parse(cboAdultQuantity.SelectedValue.ToString()) + 
                int.Parse(cboChildQuantity.SelectedValue.ToString()) +
                int.Parse(cboSeniorQuantity.SelectedValue.ToString()) + int.Parse(cboStudentQuantity.SelectedValue.ToString());
            GlobalVariables.adultTickets = int.Parse(cboAdultQuantity.SelectedValue.ToString());
            GlobalVariables.childTickets = int.Parse(cboChildQuantity.SelectedValue.ToString());
            GlobalVariables.seniorTickets = int.Parse(cboSeniorQuantity.SelectedValue.ToString());
            GlobalVariables.studentTickets = int.Parse(cboStudentQuantity.SelectedValue.ToString());
            if (GlobalVariables.numberOfTicketsPurchased <= 0)
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            else
                Switcher.Switch(new Seats());
        }

        private void cboChildQuantity_DropDownClosed(object sender, EventArgs e)
        {
            decimal ticketPrice = decimal.Parse(txtBlockChildPrice.Text);
            int quantity = int.Parse(cboChildQuantity.Text);
            decimal subTotal = ticketPrice * quantity;

            txtBlockChildSubtotal.Text = subTotal.ToString();

            int ticketQuantity = int.Parse(cboChildQuantity.SelectedValue.ToString());

            if (ticketQuantity > 0)
            {
                this.stackPanelChildrenTickets.Visibility = Visibility.Visible;
                lblNumberOfChildTickets.Content = "Child: " + cboChildQuantity.SelectedValue.ToString();
            }
            else
            {
                this.stackPanelChildrenTickets.Visibility = Visibility.Collapsed;
                lblNumberOfChildTickets.Content = "Child: " + cboChildQuantity.SelectedValue.ToString();
            }

            if (childTicketChanged != true)
            {
                tempChildrenTicketsSubTotal = decimal.Parse(txtBlockChildSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockChildSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
                childTicketChanged = true;
            }
            else
            {
                GlobalVariables.Total -= tempChildrenTicketsSubTotal;
                tempChildrenTicketsSubTotal = decimal.Parse(txtBlockChildSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockChildSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
            }
        }

        private void cboSeniorQuantity_DropDownClosed(object sender, EventArgs e)
        {
            decimal ticketPrice = decimal.Parse(txtBlockSeniorPrice.Text);
            int quantity = int.Parse(cboSeniorQuantity.Text);
            decimal subTotal = ticketPrice * quantity;

            txtBlockSeniorSubtotal.Text = subTotal.ToString();

            int ticketQuantity = int.Parse(cboSeniorQuantity.SelectedValue.ToString());

            if (ticketQuantity > 0)
            {
                this.stackPanelSeniorTickets.Visibility = Visibility.Visible;
                lblNumberOfSeniorsTickets.Content = "Senior: " + cboSeniorQuantity.SelectedValue.ToString();
            }
            else
            {
                this.stackPanelSeniorTickets.Visibility = Visibility.Collapsed;
                lblNumberOfSeniorsTickets.Content = "Senior: " + cboSeniorQuantity.SelectedValue.ToString();
            }

            if (seniorTicketChanged != true)
            {
                tempSeniorTicketsSubTotal = decimal.Parse(txtBlockSeniorSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockSeniorSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
                seniorTicketChanged = true;
            }
            else
            {
                GlobalVariables.Total -= tempSeniorTicketsSubTotal;
                tempSeniorTicketsSubTotal = decimal.Parse(txtBlockSeniorSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockSeniorSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
            }

        }

        private void cboStudentQuantity_DropDownClosed(object sender, EventArgs e)
        {
            decimal ticketPrice = decimal.Parse(txtBlockStudentPrice.Text);
            int quantity = int.Parse(cboStudentQuantity.Text);
            decimal subTotal = ticketPrice * quantity;

            txtBlockStudentSubtotal.Text = subTotal.ToString();

            int ticketQuantity = int.Parse(cboStudentQuantity.SelectedValue.ToString());

            if (ticketQuantity > 0)
            {
                this.stackPanelStudentTickets.Visibility = Visibility.Visible;
                lblNumberOfStudentsTickets.Content = "Student: " + cboStudentQuantity.SelectedValue.ToString();
            }
            else
            {
                this.stackPanelStudentTickets.Visibility = Visibility.Collapsed;
                lblNumberOfStudentsTickets.Content = "Student: " + cboStudentQuantity.SelectedValue.ToString();
            }

            if (studentTicketChanged != true)
            {
                tempStudentTicketsSubTotal = decimal.Parse(txtBlockStudentSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockStudentSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
                studentTicketChanged = true;
            }
            else
            {
                GlobalVariables.Total -= tempStudentTicketsSubTotal;
                tempStudentTicketsSubTotal = decimal.Parse(txtBlockStudentSubtotal.Text);
                GlobalVariables.Total += decimal.Parse(txtBlockStudentSubtotal.Text);
                txtBlockSubototalOfAllTicekts.Text = GlobalVariables.Total.ToString();
            }

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.adultTickets = 0;
            GlobalVariables.childTickets = 0;
            GlobalVariables.seniorTickets = 0;
            GlobalVariables.studentTickets = 0;
            GlobalVariables.numberOfTicketsPurchased = 0;
            GlobalVariables.LoggedIn = false;
            GlobalVariables.Registered = false;
            GlobalVariables.GuestCheckout = false;

            // Reset tickets
            tempAdultTicketsSubTotal = 0.0m;
            tempChildrenTicketsSubTotal = 0.0m;
            tempSeniorTicketsSubTotal = 0.0m;
            tempStudentTicketsSubTotal = 0.0m;
            adultTicketChanged = false;
            childTicketChanged = false;
            seniorTicketChanged = false;
            studentTicketChanged = false;

            Switcher.Switch(new MainMenu());
        }
    }
}
