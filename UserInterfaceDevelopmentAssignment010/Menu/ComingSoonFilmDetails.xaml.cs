﻿using System;
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
    public partial class ComingSoonFilmDetails : UserControl, ISwitchable
    {
        public ComingSoonFilmDetails()
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

            txtBlockDescription.Text = GlobalVariables.Description;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
