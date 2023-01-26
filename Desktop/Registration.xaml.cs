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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.NameValid(Name) == false)
            {
                MessageBox.Show("Неправильно введено имя");
            }
            else if (Validator.EmailValid(Email) == false)
            {
                MessageBox.Show("Неправильно введена почта");
            }
            else if (Validator.CheckPassValid(Password1, Password2) == false)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else
            {
                var wind = new MainEmpty();
                wind.Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var wind = new Log_In();
            wind.Show();
            this.Close();
        }
    }
}
