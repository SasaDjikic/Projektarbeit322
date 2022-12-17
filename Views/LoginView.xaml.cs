using Projektarbeit322.Models;
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
using System.Windows.Shapes;

namespace Projektarbeit322.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>

    public partial class LoginView : Window
    {
        private bool _isLoggedIn = false;
        public LoginView()
        {
            InitializeComponent();
            txtboxUsername.Focus();
        }

        public LoginView(bool isLoggedIn)
            :this()
        {
            _isLoggedIn = isLoggedIn;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            if (txtboxPassword.Password == "IBZ123!" || txtboxUsername.Text == "Admin")
            {
                _isLoggedIn = true;
                DialogResult = true;
                Close();
            }
            else
            {
                txtboxPassword.Password = "Passwort ist Falsch";
                txtboxPassword.Background = Brushes.Red;
                txtboxUsername.Text = "Benutzername ist Falsch";
                txtboxUsername.Background = Brushes.Red;
            }
        }

        private void txtboxUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtboxUsername.Text != "Benutzername ist Falsch")
            {
                txtboxUsername.Background = Brushes.White;
            }
        }

        private void txtboxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtboxPassword.Password != "Passwort ist Falsch")
            {
                txtboxPassword.Background = Brushes.White;
            }
        }
    }
}
