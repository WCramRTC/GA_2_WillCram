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

namespace GA_2_WillCram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Buttons, Labels, and TextBoxes

        public MainWindow()
        {
            InitializeComponent();
        } // MainWindow()

        // Display a full name in a Message Box
        
        private void btnFullName_Click(object sender, RoutedEventArgs e)
        {
            DisplayFullName();

        } // btnFullName_Click

        // Organizing my code into methods
        public void DisplayFullName()
        {
            // Declare two string variables to hold our first and last name
            //bool firstNameNotEmpty = txtFirstName.Text != "";
            //bool lastNameNoteEmpty = txtLastName.Text != "";

            bool nameBoxesNotEmpty = ValidateTextBoxes(txtFirstName.Text, txtLastName.Text);

            if (nameBoxesNotEmpty)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;

                // Declare a third string, full name
                // Concatenate ( combine ) the first and last name into one long string
                string fullName = $"{firstName} {lastName}";

                // Display full name on button click
                MessageBox.Show(fullName);
            }
            else
            {
                MessageBox.Show("Please enter your first and last name in the text boxes");
            }
        } // DisplayFullName

        public bool ValidateTextBoxes(string textBox1, string textBox2)
        {
            bool textBox1NotEmpty = textBox1 != "";
            bool textBox2NotEmpty = textBox2 != "";

            return textBox1NotEmpty && textBox2NotEmpty;
        } // ValidateTextBoxes



        // Add or Subtract Two Numbers - Display in a text box

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {

        }


        // Display a single character from a Word in a Label

        private void btnDisplayLetter_Click(object sender, RoutedEventArgs e)
        {

        }

    } // class

} // namespace
