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
    /// Interaction logic for CheckoutMethod.xaml
    /// </summary>
    public partial class CheckoutMethod : UserControl, ISwitchable
    {
        public CheckoutMethod()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new FilmDetails());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Login());
        }

        private void btnGuest_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.GuestCheckout = true;
            Switcher.Switch(new Tickets());
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Register());
        }
    }
}
