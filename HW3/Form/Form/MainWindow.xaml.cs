using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Form
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow

    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool NameCheck(string text)
        {
            if (text.Length < 255)
            {
                string pattern = @"?[a-z]\w";
                while (true)
                {
                    if (Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase))
                    {
                        return true;
                    }
                    else return false;
                }
            }
            else return false;

        }
        private bool BirthCheck(string text)
        {
            string[] dateOfBirth = text.Split('.');
            try
            {
                if ((int.Parse(dateOfBirth[0]) > 0 && int.Parse(dateOfBirth[0]) < 32) && (int.Parse(dateOfBirth[1]) > 0 && int.Parse(dateOfBirth[1]) < 13)
                   && (int.Parse(dateOfBirth[2]) > 1900 && int.Parse(dateOfBirth[2]) < int.Parse(DateTime.Now.Year.ToString())))
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
        private bool GenderCheck(string text)
        {
            if (text == "male" || text == "female")
                return true;
            else return false;
        }
        private bool EmailCheck(string text)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            while (true)
            {
                if (Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase))
                    return true;
                else
                    return false;
            }
        }
        private bool PhoneCheck(string text)
        {
            string pattern = @"[380]\d[0-9]{9}\d{9}";
            while (true)
            {
                if (Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase))
                    return true;
                else
                    return false;
            }
        }
        private bool AddInfoCheck(string text) { 
            if (text.Length < 2000)
                return true;
            else return false;
        }
        
        private void Test() {

            if (NameCheck(firstNameBox.Text) && NameCheck(lastNameBox.Text)

                && BirthCheck(birthBox.Text) && GenderCheck(genderBox.Text) &&

                EmailCheck(emailBox.Text) && PhoneCheck(phoneBox.Text) &&

                AddInfoCheck(addInfoBox.Text))
            MessageBox.Show("Data is OK");
            else
            MessageBox.Show("Data is invalid");
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            Test();
        }
    }
}