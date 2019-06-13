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
    /// Interaction logic for Success.xaml
    /// </summary>
    public partial class Success : UserControl
    {
        public Success()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lblFilmTitle.Content = GlobalVariables.FilmTitle;
            lblDate.Content = GlobalVariables.day.ToString() + " " + GlobalVariables.month;
            lblTime.Content = GlobalVariables.time;
            lblCinema.Content = GlobalVariables.ShowingAtCinema;
            lblAdultTicketsQuantity.Content = GlobalVariables.adultTickets;
            lblChildTicketsQuantity.Content = GlobalVariables.childTickets;
            lblSeniorTicketsQuantity.Content = GlobalVariables.seniorTickets;
            lblStudentTicketsQuantity.Content = GlobalVariables.studentTickets;

            decimal ticketPrice = decimal.Parse(lblAdultTicketPrice.Content.ToString());
            int quantity = int.Parse(lblAdultTicketsQuantity.Content.ToString());
            decimal subTotal = ticketPrice * quantity;
            lblAdultSubtotal.Content = Convert.ToString(subTotal);

            ticketPrice = decimal.Parse(lblChildTicketPrice.Content.ToString());
            quantity = int.Parse(lblChildTicketsQuantity.Content.ToString());
            subTotal = ticketPrice * quantity;
            lblChildSubTotal.Content = Convert.ToString(subTotal);

            ticketPrice = decimal.Parse(lblSeniorTicketPrice.Content.ToString());
            quantity = int.Parse(lblSeniorTicketsQuantity.Content.ToString());
            subTotal = ticketPrice * quantity;
            lblSeniorSubtotal.Content = Convert.ToString(subTotal);

            ticketPrice = decimal.Parse(lblStudentTicketPrice.Content.ToString());
            quantity = int.Parse(lblStudentTicketsQuantity.Content.ToString());
            subTotal = ticketPrice * quantity;
            lblStudentSubtotal.Content = Convert.ToString(subTotal);

            lblSeats.Content = GlobalVariables.selectedseats;

            if(GlobalVariables.GuestCheckout == true)
                lblPaidBy.Content = GlobalVariables.GuestFirstName + " " + GlobalVariables.GuestLastName;
            if(GlobalVariables.Registered == true)
                lblPaidBy.Content = GlobalVariables.RegisterFirstName + " " + GlobalVariables.RegisterLastName;
            if (GlobalVariables.LoggedIn == true)
                lblPaidBy.Content = GlobalVariables.LoginFirstName + " " + GlobalVariables.LoginSecondName;

            lblPaymentMethod.Content = GlobalVariables.paymentMethod.ToString();

            lblTotal.Content = GlobalVariables.Total;

        }

        private void btnCompleteBooking_Click(object sender, RoutedEventArgs e)
        {
            // Reset global variables to empty or default values in order to destroy any current information about the previous booking
            GlobalVariables.LoggedIn = false;
            GlobalVariables.RegisterTitle = "";
            GlobalVariables.RegisterEmail = "";
            GlobalVariables.RegisterPassword = "";
            GlobalVariables.RegisterFirstName = "";
            GlobalVariables.RegisterLastName = "";
            GlobalVariables.RegisterPostCode = "";
            GlobalVariables.Registered = false;
            GlobalVariables.GuestFirstName = "";
            GlobalVariables.GuestLastName = "";
            GlobalVariables.GuestEmail = "";
            GlobalVariables.GuestCheckout = false;
            GlobalVariables.Total = 0.0m;
            GlobalVariables.adultTickets = 0;
            GlobalVariables.childTickets = 0;
            GlobalVariables.seniorTickets = 0;
            GlobalVariables.studentTickets = 0;
            GlobalVariables.selectedseats = "";
            GlobalVariables.numberOfTicketsPurchased = 0;
            GlobalVariables.paymentMethod = "";

            // Reset tickets
            Tickets.tempAdultTicketsSubTotal = 0.0m;
            Tickets.tempChildrenTicketsSubTotal = 0.0m;
            Tickets.tempSeniorTicketsSubTotal = 0.0m;
            Tickets.tempStudentTicketsSubTotal = 0.0m;
            Tickets.adultTicketChanged = false;
            Tickets.childTicketChanged = false;
            Tickets.seniorTicketChanged = false;
            Tickets.studentTicketChanged = false;

            // Reset seats
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

            // Switch to the main menu page
            Switcher.Switch(new MainMenu());
        }
    }
}
