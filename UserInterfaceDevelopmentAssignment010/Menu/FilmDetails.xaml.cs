using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for FilmDetails.xaml
    /// </summary>
    public partial class FilmDetails : UserControl, ISwitchable
    {
        public FilmDetails()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        // Switcher.Switch(new MainMenu());

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lblFilmTitle.Content = GlobalVariables.FilmTitle;

            ImageSourceConverter converter = new ImageSourceConverter();
            var imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.AgeRatingSource);
            imgAgeRating.Source = imageSource;

            imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.UserRatingSource);
            //imgUserRating.Source = imageSource;

            lblUserRating.Content = GlobalVariables.UserRating;

            // Setting up film screenshots and banner

            imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.BannerImageSource);
            imgBanner.Source = imageSource;

            imageSource = (ImageSource) converter.ConvertFromString(GlobalVariables.ScreenshotOneSource);
            imgFilmScreenshotOne.Source = imageSource;

            imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.ScreenshotTwoSource);
            imgFilmScreenshotTwo.Source = imageSource;

            imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.ScreenshotThreeSource);
            imgFilmScreenshotThree.Source = imageSource;

            imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.ScreenshotFourSource);
            imgFilmScreenshotFour.Source = imageSource;


            txtBlockDescription.Text = GlobalVariables.Description;


            // Setting up automated dates for tickets
            #region firstDay
            lblCurrentDayName.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Today.DayOfWeek).ToString() + ",";
            lblCurrentDay.Content = DateTime.Today.Day.ToString();

            switch (DateTime.Today.Day)
            {
                case 1:
                case 21:
                case 31:
                    lblCurrentDayEnding.Content = "st";
                    break;
                case 2:
                case 22:
                    lblCurrentDayEnding.Content = "nd";
                    break;
                case 3:
                case 23:
                    lblCurrentDayEnding.Content = "rd";
                    break;
                default:
                    lblCurrentDayEnding.Content = "th";
                    break;
            }

            lblCurrentMonth.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Today.Month).ToString();
            #endregion

            #region SecondDay
            lblCurrentDayNameTwo.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Today.AddDays(1).DayOfWeek).ToString() + ",";
            lblCurrentDayTwo.Content = DateTime.Today.AddDays(1).Day.ToString();
            switch (DateTime.Today.AddDays(1).Day)
            {
                case 1:
                case 21:
                case 31:
                    lblCurrentDayEndingTwo.Content = "st";
                    break;
                case 2:
                case 22:
                    lblCurrentDayEndingTwo.Content = "nd";
                    break;
                case 3:
                case 23:
                    lblCurrentDayEndingTwo.Content = "rd";
                    break;
                default:
                    lblCurrentDayEndingTwo.Content = "th";
                    break;
            }
            lblCurrentMonthTwo.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Today.AddDays(1).Month).ToString();
            #endregion

            #region ThirdDay
            lblCurrentDayNameThree.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Today.AddDays(2).DayOfWeek).ToString() + ",";
            lblCurrentDayThree.Content = DateTime.Today.AddDays(2).Day.ToString();
            switch (DateTime.Today.AddDays(2).Day)
            {
                case 1:
                case 21:
                case 31:
                    lblCurrentDayEndingThree.Content = "st";
                    break;
                case 2:
                case 22:
                    lblCurrentDayEndingThree.Content = "nd";
                    break;
                case 3:
                case 23:
                    lblCurrentDayEndingThree.Content = "rd";
                    break;
                default:
                    lblCurrentDayEndingThree.Content = "th";
                    break;
            }
            lblCurrentMonthThree.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Today.AddDays(2).Month).ToString();
            #endregion

            #region FourthDay
            lblCurrentDayNameFour.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Today.AddDays(3).DayOfWeek).ToString() + ",";
            lblCurrentDayFour.Content = DateTime.Today.AddDays(3).Day.ToString();
            switch (DateTime.Today.AddDays(3).Day)
            {
                case 1:
                case 21:
                case 31:
                    lblCurrentDayEndingFour.Content = "st";
                    break;
                case 2:
                case 22:
                    lblCurrentDayEndingFour.Content = "nd";
                    break;
                case 3:
                case 23:
                    lblCurrentDayEndingFour.Content = "rd";
                    break;
                default:
                    lblCurrentDayEndingFour.Content = "th";
                    break;
            }
            lblCurrentMonthFour.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Today.AddDays(3).Month).ToString();
            #endregion

            #region FifthhDay

            //DateTime day = DateTime.Now.Day + 4;
            lblCurrentDayNameFive.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Today.AddDays(4).DayOfWeek).ToString() + ",";
            lblCurrentDayFive.Content = DateTime.Today.AddDays(4).Day.ToString();
            switch (DateTime.Today.AddDays(4).Day)
            {
                case 1:
                case 21:
                case 31:
                    lblCurrentDayEndingFive.Content = "st";
                    break;
                case 2:
                case 22:
                    lblCurrentDayEndingFive.Content = "nd";
                    break;
                case 3:
                case 23:
                    lblCurrentDayEndingFive.Content = "rd";
                    break;
                default:
                    lblCurrentDayEndingFive.Content = "th";
                    break;
            }
            lblCurrentMonthFive.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Today.AddDays(4).Month).ToString();
            #endregion

            #region SixthhDay
            lblCurrentDayNameSix.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Today.AddDays(5).DayOfWeek).ToString() + ",";
            lblCurrentDaySix.Content = DateTime.Today.AddDays(5).Day.ToString();
            switch (DateTime.Today.AddDays(5).Day)
            {
                case 1:
                case 21:
                case 31:
                    lblCurrentDayEndingSix.Content = "st";
                    break;
                case 2:
                case 22:
                    lblCurrentDayEndingSix.Content = "nd";
                    break;
                case 3:
                case 23:
                    lblCurrentDayEndingSix.Content = "rd";
                    break;
                default:
                    lblCurrentDayEndingSix.Content = "th";
                    break;
            }
            lblCurrentMonthSix.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Today.AddDays(5).Month).ToString();
            #endregion

            #region SeventhDay
            lblCurrentDayNameSeven.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Today.AddDays(6).DayOfWeek).ToString() + ",";
            lblCurrentDaySeven.Content = DateTime.Today.AddDays(6).Day.ToString();
            switch (DateTime.Today.AddDays(6).Day)
            {
                case 1:
                case 21:
                case 31:
                    lblCurrentDayEndingSeven.Content = "st";
                    break;
                case 2:
                case 22:
                    lblCurrentDayEndingSeven.Content = "nd";
                    break;
                case 3:
                case 23:
                    lblCurrentDayEndingSeven.Content = "rd";
                    break;
                default:
                    lblCurrentDayEndingSeven.Content = "th";
                    break;
            }
            lblCurrentMonthSeven.Content = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Today.AddDays(6).Month).ToString();
            #endregion
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        public void BookingDateDetails(Button buttonName, Label dayLabel, Label monthLabel)
        {
            GlobalVariables.day = int.Parse(dayLabel.Content.ToString());
            GlobalVariables.month = monthLabel.Content.ToString();
            GlobalVariables.time = buttonName.Content.ToString();
            GlobalVariables.ShowingAtCinema = cboShowingAt.SelectedValue.ToString();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnOne, lblCurrentDay, lblCurrentMonth);
            Switcher.Switch(new CheckoutMethod());
        }

        private void imgFilmScreenshotOne_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                var imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.ScreenshotOneSource);
                imgBanner.Source = imageSource;
            }
        }

        private void imgFilmScreenshotTwo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                var imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.ScreenshotTwoSource);
                imgBanner.Source = imageSource;
            }
        }

        private void imgFilmScreenshotThree_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                var imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.ScreenshotThreeSource);
                imgBanner.Source = imageSource;
            }
        }

        private void imgFilmScreenshotFour_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                var imageSource = (ImageSource)converter.ConvertFromString(GlobalVariables.ScreenshotFourSource);
                imgBanner.Source = imageSource;
            }
        }

        private void btnSecond_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnTwo, lblCurrentDay, lblCurrentMonth);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnTwo, lblCurrentDayTwo, lblCurrentMonthTwo);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnFour, lblCurrentDayTwo, lblCurrentMonthTwo);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnFive, lblCurrentDayThree, lblCurrentMonthThree);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnSix, lblCurrentDayThree, lblCurrentMonthThree);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnSeven, lblCurrentDayFour, lblCurrentMonthFour);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnEight, lblCurrentDayFour, lblCurrentMonthFour);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnNine, lblCurrentDayFive, lblCurrentMonthFive);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnTen_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnTen, lblCurrentDayFive, lblCurrentMonthFive);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnEleven_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnEleven, lblCurrentDaySix, lblCurrentMonthSix);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnTwelve_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnTwelve, lblCurrentDaySix, lblCurrentMonthSix);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnThirteen_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnThirteen, lblCurrentDaySeven, lblCurrentMonthSeven);
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnFourteen_Click(object sender, RoutedEventArgs e)
        {
            BookingDateDetails(btnFourteen, lblCurrentDaySeven, lblCurrentMonthSeven);
            Switcher.Switch(new CheckoutMethod());
        }
    }
}
