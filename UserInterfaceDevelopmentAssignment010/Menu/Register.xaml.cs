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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : UserControl, ISwitchable
    {
        public Register()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CheckoutMethod());
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxPassword.Password != txtBoxConfirmPassword.Password)
            {
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxEmail.Text != txtBoxConfirmEmail.Text)
            {
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else if (txtBoxTitle.Text == "" || txtBoxFirstName.Text == "" || txtBoxLastName.Text == "" ||
                txtBoxEmail.Text == "" || txtBoxConfirmEmail.Text == "" || txtBoxPassword.Password == "" ||
                txtBoxConfirmPassword.Password == "" || txtBoxPostCode.Text == "")
            {
                stackPanelIncorrectDetails.Visibility = Visibility.Visible;
            }
            else
            {
                GlobalVariables.RegisterTitle = txtBoxTitle.Text;
                GlobalVariables.RegisterFirstName = txtBoxFirstName.Text;
                GlobalVariables.RegisterLastName = txtBoxLastName.Text;
                GlobalVariables.RegisterEmail = txtBoxEmail.Text;
                GlobalVariables.RegisterPassword = txtBoxPassword.Password;
                GlobalVariables.RegisterPostCode = txtBoxPostCode.Text;
                GlobalVariables.Registered = true;

                Switcher.Switch(new Tickets());
            }
            
        }
    }
}
