using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace UserInterfaceDevelopmentAssignment010
{
    public static class GlobalVariables
    {
        // demo account for log-in
        public static string LoginEmail = "demo@email.com";
        public static string LoginPassword = "123456";
        public static string LoginFirstName = "Jane";
        public static string LoginSecondName = "Doe";
        public static bool LoggedIn = false;
        // Register account
        public static string RegisterTitle = "";
        public static string RegisterEmail = "";
        public static string RegisterPassword = "";
        public static string RegisterFirstName = "";
        public static string RegisterLastName = "";
        public static string RegisterPostCode = "";
        public static bool Registered = false;

        // Guest checkout
        public static string GuestFirstName = "";
        public static string GuestLastName = "";
        public static string GuestEmail = "";
        public static bool GuestCheckout = false;

        // Film Details
        public static string FilmTitle = "";
        public static int ReleaseYear = 0;
        public static int day = 0;
        public static string month = "";
        public static string time = "";
        public static string BannerImageSource = "";
        public static string UserRating = "";
        public static string UserRatingSource = ""; // Potentially can be deleted
        public static string AgeRatingSource;
        public static string Description = "";
        public static string ScreenshotOneSource = "";
        public static string ScreenshotTwoSource = "";
        public static string ScreenshotThreeSource = "";
        public static string ScreenshotFourSource = "";
        public static string ShowingAtCinema = "";

        // Global variables for Login.xaml page
        public static string userEmail = "";
        public static string userPassword = "";

        // Global variables for Tickets.xaml page
        public static decimal Total = 0.0m;
        public static int adultTickets = 0;
        public static int childTickets = 0;
        public static int seniorTickets = 0;
        public static int studentTickets = 0;

        // Seats
        public static string selectedseats = "";


        public static int numberOfTicketsPurchased = 0;


        // Payment
        public static string paymentMethod = "";

        // Back buttons
        public static bool seatsBackButtonPressed = false;
    }
}
