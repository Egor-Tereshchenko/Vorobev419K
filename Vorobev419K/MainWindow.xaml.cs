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

namespace Vorobev419K
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (UserName.Text.Length < 3 || UserName.Text.Length > 25)
            {
                UserName.Background = Brushes.Red;
            }
            else
            {
                UserName.Background = Brushes.Green;
            }

        }

        private void UserFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (UserFirstName.Text.Length < 2 || UserFirstName.Text.Length > 30)
            {
                UserFirstName.Background = Brushes.Red;
            }
            else
            {
                UserFirstName.Background = Brushes.Green;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (Email.Text.Contains("@") && Email.Text.Contains("."))
            {
                Email.Background = Brushes.Green;
            }
            else
            {
                Email.Background = Brushes.Red;
            }
        }
    }
}
