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
    /// Interaction logic for MainMneu.xaml
    /// </summary>
    public partial class MainMenu : UserControl, ISwitchable
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void btnReadMore1_Click(object sender, RoutedEventArgs e)
        { 
            GlobalVariables.FilmTitle = txtblckTitle1.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/Bad-Santa-2BANNER.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRating15.png";
            GlobalVariables.UserRating = "5.7 / 10";
            GlobalVariables.ScreenshotOneSource = "../../Images/screenshots/bad_santa_2_screen_1.jpg";
            GlobalVariables.ScreenshotTwoSource = "../../Images/screenshots/bad_santa_2_screen_2.jpg";
            GlobalVariables.ScreenshotThreeSource = "../../Images/screenshots/bad_santa_2_screen_3.jpg";
            GlobalVariables.ScreenshotFourSource = "../../Images/screenshots/bad_santa_2_screen_4.jpg";

            GlobalVariables.Description = "Fueled by cheap whiskey, greed and hatred, Willie Soke (Billy Bob Thornton) teams up with " + 
                                          "his angry little sidekick, Marcus, to knock off a Chicago charity on Christmas Eve." + 
                                          " Along for the ride is chubby and cheery Thurman Merman, a 250-pound ray of sunshine who " + 
                                          "brings out Willie's sliver of humanity. Mommy issues arise when the pair are " + 
                                          "joined by Willie's horror story of a mother, Sunny Soke, who raises the bar for the gang's " + 
                                          "ambitions, while somehow lowering the standards of criminal behavior.";
            Switcher.Switch(new FilmDetails());
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtblckTitle2.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/arrival_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRating12.png";
            GlobalVariables.UserRating = "8.3 / 10";
            GlobalVariables.ScreenshotOneSource = "../../Images/screenshots/arrival_screen_1.jpg";
            GlobalVariables.ScreenshotTwoSource = "../../Images/screenshots/arrival_screen_2.jpg";
            GlobalVariables.ScreenshotThreeSource = "../../Images/screenshots/arrival_screen_3.jpg";
            GlobalVariables.ScreenshotFourSource = "../../Images/screenshots/arrival_screen_4.jpg";


            GlobalVariables.Description = "When mysterious spacecraft touch down across the globe, an elite team - led by expert linguist Louise Banks (Amy Adams) - is brought together to investigate. As mankind teeters on the verge of global war, Banks and the team race against time for answers - and to find them, she will take a chance that could threaten her life, and quite possibly humanity.";
            Switcher.Switch(new FilmDetails());
        }

        private void btnReadMoreDoctorStrange_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtblckTitle3.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/doctor_strange_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRating12.png";
            GlobalVariables.UserRating = "7.9 / 10";
            GlobalVariables.ScreenshotOneSource = "../../Images/screenshots/doctor_strange_screen_1.jpg";
            GlobalVariables.ScreenshotTwoSource = "../../Images/screenshots/doctor_strange_screen_2.jpg";
            GlobalVariables.ScreenshotThreeSource = "../../Images/screenshots/doctor_strange_screen_3.jpg";
            GlobalVariables.ScreenshotFourSource = "../../Images/screenshots/doctor_strange_screen_4.jpg";

            GlobalVariables.Description = "After his career is destroyed, a brilliant but arrogant surgeon gets a new lease on life when a sorcerer takes him under his wing and trains him to defend the world against evil.";
            Switcher.Switch(new FilmDetails());
        }

        private void btnReadMoreFantasticBeasts_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtblckTitle4.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/fantastic-beasts-and-where-to-find-them_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRating12.png";
            GlobalVariables.UserRating = "7.8 / 10";
            GlobalVariables.ScreenshotOneSource = "../../Images/screenshots/fantastic_beasts_screen_1.jpg";
            GlobalVariables.ScreenshotTwoSource = "../../Images/screenshots/fantastic_beasts_screen_2.jpg";
            GlobalVariables.ScreenshotThreeSource = "../../Images/screenshots/fantastic_beasts_screen_3.jpg";
            GlobalVariables.ScreenshotFourSource = "../../Images/screenshots/fantastic_beasts_screen_4.jpg";

            GlobalVariables.Description = "‘Fantastic Beasts and Where to Find Them’ begins in 1926 as Newt Scamander (Eddie Redmayne) has just completed a global excursion to find and document an extraordinary array of magical creatures.  Arriving in New York for a brief stopover, he might have come and gone without incident were it not for a No-Maj (American for Muggle) named Jacob, a misplaced magical case, and the escape of some of Newt’s fantastic beasts, which could spell trouble for both the wizarding and No-Maj worlds.";
            Switcher.Switch(new FilmDetails());
        }

        private void btnReadMoreAllied_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtblckTitle5.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/allied_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRating15.png";
            GlobalVariables.UserRating = "7.2 / 10";
            GlobalVariables.ScreenshotOneSource = "../../Images/screenshots/Allied_2016_screen_1.jpg";
            GlobalVariables.ScreenshotTwoSource = "../../Images/screenshots/Allied_2016_screen_2.jpg";
            GlobalVariables.ScreenshotThreeSource = "../../Images/screenshots/Allied_2016_screen_3.jpg";
            GlobalVariables.ScreenshotFourSource = "../../Images/screenshots/Allied_2016_screen_4.jpg";

            GlobalVariables.Description = "The story of intelligence officer Max Vatan (Brad Pitt), who in 1942 North Africa encounters French Resistance fighter Marianne Beausejour (Marion Cotillard) on a deadly mission behind enemy lines. Reunited in London, their relationship is threatened by the extreme pressures of the war.";
            Switcher.Switch(new FilmDetails());
        }

        private void btnReadMoreKingArthur_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtBlockComingSoon1.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/king_arthur_legend_of_the_sword.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRatingTBC.png";
            GlobalVariables.UserRating = "Not Rated";

            GlobalVariables.Description = "A re-imagining of the King Arthur tale.";
            Switcher.Switch(new ComingSoonFilmDetails());
        }

        private void btnReadMoreBeautyAndTheBeast_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtBlockComingSoon2.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/Beauty-and-the-Beast_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRatingPG.png";
            GlobalVariables.UserRating = "Not Rated";

            GlobalVariables.Description = "'Beauty and the Beast' is the fantastic journey of Belle, a bright, beautiful and independent young woman who is taken prisoner by a beast in his castle. Despite her fears, she befriends the castle's enchanted staff and learns to look beyond the Beast's hideous exterior and realize the kind heart and soul of the true Prince within.";
            Switcher.Switch(new ComingSoonFilmDetails());
        }

        private void btnReadMorePowerRangers_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtBlockComingSoon3.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/power_rangers_2017_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRatingTBC.png";
            GlobalVariables.UserRating = "Not Rated";

            GlobalVariables.Description = "A modern reinvention of the Mighty Morphin Power Rangers, a group of ordinary high school kids who find themselves infused with extraterrestrial powers and must harness those powers as a team to save the world.";
            Switcher.Switch(new ComingSoonFilmDetails());
        }

        private void btnReadMorePatriotsDay_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtBlockComingSoon4.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/patriots-day_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRating15.png";
            GlobalVariables.UserRating = "Not Rated";
            GlobalVariables.Description = "In the aftermath of an unspeakable act of terror, Police Sergeant Tommy Saunders (Mark Wahlberg) joins courageous survivors, first responders and investigators in a race against the clock to hunt down the bombers before they strike again.";
            Switcher.Switch(new ComingSoonFilmDetails());
        }

        private void btnReadMoreSmurfsTheLostVillage_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtBlockComingSoon5.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/smurfs_the_lost_village_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRatingTBC.png";
            GlobalVariables.UserRating = "Not Rated";
            GlobalVariables.Description = "In this fully animated, all-new take on the Smurfs, a mysterious map sets Smurfette and her best friends Brainy, Clumsy and Hefty on an exciting and thrilling race through the Forbidden Forest filled with magical creatures to find a mysterious lost village before the evil wizard Gargamel does. Embarking on a rollercoaster journey full of action and danger, the Smurfs are on a course that leads to the discovery of the biggest secret in Smurf history!";
            Switcher.Switch(new ComingSoonFilmDetails());
        }

        private void btnReadMoreLogan_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTitle = txtBlockComingSoon6.Text.Trim().ToString();
            GlobalVariables.ReleaseYear = 2016;
            GlobalVariables.BannerImageSource = "../../Images/banners/logan_banner.jpg";
            GlobalVariables.UserRatingSource = "../../Images/userRating_5_stars.png";
            GlobalVariables.AgeRatingSource = "../../Images/ageRatings/ageRatingTBC.png";
            GlobalVariables.UserRating = "Not Rated";
            GlobalVariables.Description = "In 2024, mutant births are severely in decline, and people aren't sure why. A government-type operation is turning mutant children into killing machines. From this, Logan emerges as a mentor to a mutant girl, who has two claws instead of his three.";
            Switcher.Switch(new ComingSoonFilmDetails());
        }
    }
}
