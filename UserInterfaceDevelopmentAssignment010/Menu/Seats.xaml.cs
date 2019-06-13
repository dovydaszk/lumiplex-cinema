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
    /// Interaction logic for Seats.xaml
    /// </summary>
    public partial class Seats : UserControl
    {
        public static int seatsAvailable = 0;
        public static string seatA1Selected = "not selected";
        public static string seatA2Selected = "not selected";
        public static string seatA3Selected = "not selected";
        public static string seatA4Selected = "not selected";
        public static string seatA5Selected = "not selected";
        public static string seatA6Selected = "not selected";
        public static string seatA7Selected = "not selected";
        public static string seatA8Selected = "not selected";
        public static string seatA9Selected = "not selected";

        public static string seatB1Selected = "not selected";
        public static string seatB2Selected = "not selected";
        public static string seatB3Selected = "not selected";
        public static string seatB4Selected = "not selected";
        public static string seatB5Selected = "not selected";
        public static string seatB6Selected = "not selected";
        public static string seatB7Selected = "not selected";
        public static string seatB8Selected = "not selected";
        public static string seatB9Selected = "not selected";

        public static string seatC1Selected = "not selected";
        public static string seatC2Selected = "not selected";
        public static string seatC3Selected = "not selected";
        public static string seatC4Selected = "not selected";
        public static string seatC5Selected = "not selected";
        public static string seatC6Selected = "not selected";
        public static string seatC7Selected = "not selected";
        public static string seatC8Selected = "not selected";
        public static string seatC9Selected = "not selected";

        public static string seatD1Selected = "not selected";
        public static string seatD2Selected = "not selected";
        public static string seatD3Selected = "not selected";
        public static string seatD4Selected = "not selected";
        public static string seatD5Selected = "not selected";
        public static string seatD6Selected = "not selected";
        public static string seatD7Selected = "not selected";
        public static string seatD8Selected = "not selected";
        public static string seatD9Selected = "not selected";

        public static string seatE1Selected = "not selected";
        public static string seatE2Selected = "not selected";
        public static string seatE3Selected = "not selected";
        public static string seatE4Selected = "not selected";
        public static string seatE5Selected = "not selected";
        public static string seatE6Selected = "not selected";
        public static string seatE7Selected = "not selected";
        public static string seatE8Selected = "not selected";
        public static string seatE9Selected = "not selected";

        public static List<string> seatsSelected = new List<string>();

        public Seats()
        {
            InitializeComponent();
            lblNumberOfSeats.Content = GlobalVariables.numberOfTicketsPurchased.ToString();
            seatsAvailable = GlobalVariables.numberOfTicketsPurchased;
            lblNumberOfSeatsLeft.Content = seatsAvailable.ToString();

        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            if (seatsAvailable != 0)
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            else
            {
                GlobalVariables.selectedseats = lblSelectedSeats.Text;
                Switcher.Switch(new Payment());
            }

            
        }

        public string SelectedSeats()
        {
            string seats = String.Empty;

            foreach (var seat in seatsSelected)
            {
                seats += seat + " ";
            }
            return seats;
        }

        public string SelectSeat(string seatSelected, Image seatImage, string seatNumber)
        {
            string selected = "";
            if (seatsAvailable > 0)
            {
                if (seatSelected == "not selected")
                {
                    seatsAvailable -= 1;
                    seatImage.Opacity = 1;
                    seatsSelected.Add(seatNumber);
                    selected = "selected";
                }
                else if (seatSelected == "selected")
                {
                    seatsAvailable += 1;
                    seatsSelected.Remove(seatNumber);
                    seatImage.Opacity = 0.5;
                    selected = "not selected";

                }
                seatsSelected.Sort();
                lblSelectedSeats.Text = SelectedSeats();
                lblNumberOfSeatsLeft.Content = seatsAvailable.ToString();
            }
            else if (seatsAvailable == 0)
            {
                foreach (var seat in seatsSelected)
                {
                    if (seat == seatNumber)
                    {
                        seatsAvailable += 1;
                        seatsSelected.Remove(seatNumber);
                        seatImage.Opacity = 0.5;
                        selected = "not selected";
                        break;
                    }
                    else
                    {
                        selected = "not selected";
                    }
                }
                seatsSelected.Sort();
                lblSelectedSeats.Text = SelectedSeats();
                lblNumberOfSeatsLeft.Content = seatsAvailable.ToString();

            }

            return selected;
        }

        private void imgSeatA1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA1Selected = SelectSeat(seatA1Selected, imgSeatA1, "A1");
            }
        }

        private void imgSeatA2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA2Selected = SelectSeat(seatA2Selected, imgSeatA2, "A2");
            }
        }

        private void imgSeatA3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA3Selected = SelectSeat(seatA3Selected, imgSeatA3, "A3");
            }
        }

        private void imgSeatA4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA4Selected = SelectSeat(seatA4Selected, imgSeatA4, "A4");
            }
        }

        private void imgSeatA5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA5Selected = SelectSeat(seatA5Selected, imgSeatA5, "A5");
            }
        }

        private void imgSeatA6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA6Selected = SelectSeat(seatA6Selected, imgSeatA6, "A6");
            }
        }

        private void imgSeatA7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA7Selected = SelectSeat(seatA7Selected, imgSeatA7, "A7");
            }
        }

        private void imgSeatA8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA8Selected = SelectSeat(seatA8Selected, imgSeatA8, "A8");
            }
        }

        private void imgSeatA9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatA9Selected = SelectSeat(seatA9Selected, imgSeatA9, "A9");
            }
        }

        private void imgSeatB1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB1Selected = SelectSeat(seatB1Selected, imgSeatB1, "B1");
            }
        }

        private void imgSeatB2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB2Selected = SelectSeat(seatB2Selected, imgSeatB2, "B2");
            }
        }

        private void imgSeatB3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB3Selected = SelectSeat(seatB3Selected, imgSeatB3, "B3");
            }
        }

        private void imgSeatB4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB4Selected = SelectSeat(seatB4Selected, imgSeatB4, "B4");
            }
        }

        private void imgSeatB5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB5Selected = SelectSeat(seatB5Selected, imgSeatB5, "B5");
            }
        }

        private void imgSeatB6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB6Selected = SelectSeat(seatB6Selected, imgSeatB6, "B6");
            }
        }

        private void imgSeatB7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB7Selected = SelectSeat(seatB7Selected, imgSeatB7, "B7");
            }
        }

        private void imgSeatB8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB8Selected = SelectSeat(seatB8Selected, imgSeatB8, "B8");
            }
        }

        private void imgSeatB9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatB9Selected = SelectSeat(seatB9Selected, imgSeatB9, "B9");
            }
        }

        private void imgSeatC1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC1Selected = SelectSeat(seatC1Selected, imgSeatC1, "C1");
            }
        }

        private void imgSeatC2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC2Selected = SelectSeat(seatC2Selected, imgSeatC2, "C2");
            }
        }

        private void imgSeatC3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC3Selected = SelectSeat(seatC3Selected, imgSeatC3, "C3");
            }
        }

        private void imgSeatC4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC4Selected = SelectSeat(seatC4Selected, imgSeatC4, "C4");
            }
        }

        private void imgSeatC5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC5Selected = SelectSeat(seatC5Selected, imgSeatC5, "C5");
            }
        }

        private void imgSeatC6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC6Selected = SelectSeat(seatC6Selected, imgSeatC6, "C6");
            }
        }

        private void imgSeatC7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC7Selected = SelectSeat(seatC7Selected, imgSeatC7, "C7");
            }
        }

        private void imgSeatC8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC8Selected = SelectSeat(seatC8Selected, imgSeatC8, "C8");
            }
        }

        private void imgSeatC9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatC9Selected = SelectSeat(seatC9Selected, imgSeatC9, "C9");
            }
        }

        private void imgSeatD1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD1Selected = SelectSeat(seatD1Selected, imgSeatD1, "D1");
            }
        }

        private void imgSeatD2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD2Selected = SelectSeat(seatD2Selected, imgSeatD2, "D2");
            }
        }

        private void imgSeatD3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD3Selected = SelectSeat(seatD3Selected, imgSeatD3, "D3");
            }
        }

        private void imgSeatD4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD4Selected = SelectSeat(seatD4Selected, imgSeatD4, "D4");
            }
        }

        private void imgSeatD5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD5Selected = SelectSeat(seatD5Selected, imgSeatD5, "D5");
            }
        }

        private void imgSeatD6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD6Selected = SelectSeat(seatD6Selected, imgSeatD6, "D6");
            }
        }

        private void imgSeatD7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD7Selected = SelectSeat(seatD7Selected, imgSeatD7, "D7");
            }
        }

        private void imgSeatD8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD8Selected = SelectSeat(seatD8Selected, imgSeatD8, "D8");
            }
        }

        private void imgSeatD9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatD9Selected = SelectSeat(seatD9Selected, imgSeatD9, "D9");
            }
        }

        private void imgSeatE1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE1Selected = SelectSeat(seatE1Selected, imgSeatE1, "E1");
            }
        }

        private void imgSeatE2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE2Selected = SelectSeat(seatE2Selected, imgSeatE2, "E2");
            }
        }

        private void imgSeatE3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE3Selected = SelectSeat(seatE3Selected, imgSeatE3, "E3");
            }
        }

        private void imgSeatE4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE4Selected = SelectSeat(seatE4Selected, imgSeatE4, "E4");
            }
        }

        private void imgSeatE5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE5Selected = SelectSeat(seatE5Selected, imgSeatE5, "E5");
            }
        }

        private void imgSeatE6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE6Selected = SelectSeat(seatE6Selected, imgSeatE6, "E6");
            }
        }

        private void imgSeatE7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE7Selected = SelectSeat(seatE7Selected, imgSeatE7, "E7");
            }
        }

        private void imgSeatE8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE8Selected = SelectSeat(seatE8Selected, imgSeatE8, "E8");
            }
        }

        private void imgSeatE9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                seatE9Selected = SelectSeat(seatE9Selected, imgSeatE9, "E9");
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            seatsAvailable = 0;
            seatA1Selected = "not selected";
            seatA2Selected = "not selected";
            seatA3Selected = "not selected";
            seatA4Selected = "not selected";
            seatA5Selected = "not selected";
            seatA6Selected = "not selected";
            seatA7Selected = "not selected";
            seatA8Selected = "not selected";
            seatA9Selected = "not selected";
            seatB1Selected = "not selected";
            seatB2Selected = "not selected";
            seatB3Selected = "not selected";
            seatB4Selected = "not selected";
            seatB5Selected = "not selected";
            seatB6Selected = "not selected";
            seatB7Selected = "not selected";
            seatB8Selected = "not selected";
            seatB9Selected = "not selected";

            seatC1Selected = "not selected";
            seatC2Selected = "not selected";
            seatC3Selected = "not selected";
            seatC4Selected = "not selected";
            seatC5Selected = "not selected";
            seatC6Selected = "not selected";
            seatC7Selected = "not selected";
            seatC8Selected = "not selected";
            seatC9Selected = "not selected";

            seatD1Selected = "not selected";
            seatD2Selected = "not selected";
            seatD3Selected = "not selected";
            seatD4Selected = "not selected";
            seatD5Selected = "not selected";
            seatD6Selected = "not selected";
            seatD7Selected = "not selected";
            seatD8Selected = "not selected";
            seatD9Selected = "not selected";
            seatE1Selected = "not selected";
            seatE2Selected = "not selected";
            seatE3Selected = "not selected";
            seatE4Selected = "not selected";
            seatE5Selected = "not selected";
            seatE6Selected = "not selected";
            seatE7Selected = "not selected";
            seatE8Selected = "not selected";
            seatE9Selected = "not selected";

            seatsSelected = new List<string>();

            GlobalVariables.seatsBackButtonPressed = true;
            Switcher.Switch(new Tickets());
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
            Tickets.tempAdultTicketsSubTotal = 0.0m;
            Tickets.tempChildrenTicketsSubTotal = 0.0m;
            Tickets.tempSeniorTicketsSubTotal = 0.0m;
            Tickets.tempStudentTicketsSubTotal = 0.0m;
            Tickets.adultTicketChanged = false;
            Tickets.childTicketChanged = false;
            Tickets.seniorTicketChanged = false;
            Tickets.studentTicketChanged = false;

            // Reset seats
            seatsAvailable = 0;
            seatA1Selected = "not selected";
            seatA2Selected = "not selected";
            seatA3Selected = "not selected";
            seatA4Selected = "not selected";
            seatA5Selected = "not selected";
            seatA6Selected = "not selected";
            seatA7Selected = "not selected";
            seatA8Selected = "not selected";
            seatA9Selected = "not selected";
            seatB1Selected = "not selected";
            seatB2Selected = "not selected";
            seatB3Selected = "not selected";
            seatB4Selected = "not selected";
            seatB5Selected = "not selected";
            seatB6Selected = "not selected";
            seatB7Selected = "not selected";
            seatB8Selected = "not selected";
            seatB9Selected = "not selected";

            seatC1Selected = "not selected";
            seatC2Selected = "not selected";
            seatC3Selected = "not selected";
            seatC4Selected = "not selected";
            seatC5Selected = "not selected";
            seatC6Selected = "not selected";
            seatC7Selected = "not selected";
            seatC8Selected = "not selected";
            seatC9Selected = "not selected";

            seatD1Selected = "not selected";
            seatD2Selected = "not selected";
            seatD3Selected = "not selected";
            seatD4Selected = "not selected";
            seatD5Selected = "not selected";
            seatD6Selected = "not selected";
            seatD7Selected = "not selected";
            seatD8Selected = "not selected";
            seatD9Selected = "not selected";
            seatE1Selected = "not selected";
            seatE2Selected = "not selected";
            seatE3Selected = "not selected";
            seatE4Selected = "not selected";
            seatE5Selected = "not selected";
            seatE6Selected = "not selected";
            seatE7Selected = "not selected";
            seatE8Selected = "not selected";
            seatE9Selected = "not selected";

            seatsSelected = new List<string>();


            Switcher.Switch(new MainMenu());
        }
    }
}
