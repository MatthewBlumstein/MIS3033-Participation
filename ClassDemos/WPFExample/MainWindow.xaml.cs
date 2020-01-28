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

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtBirthDate.Text = "";
        }


        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string firstName, lastName, birthDate;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            birthDate = txtBirthDate.Text;

            string fullName = firstName + " " + lastName;
            DateTime dob = Convert.ToDateTime(birthDate);

            foreach(var letter in fullName)
            {
               lbLetters.Items.Add(letter);
            }

            lbLetters.Items.Add($"You were born on a {dob.DayOfWeek}");
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Thank you for using our application! =)");
            Close();
        }
    }
}
