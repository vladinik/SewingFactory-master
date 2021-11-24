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

namespace SewingFactory
{
    /// <summary>
    /// Логика взаимодействия для WinStorekeeper.xaml
    /// </summary>
    public partial class WinStorekeeper : Window
    {
        public WinStorekeeper()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();

        }

        private void BtnSpisock_Click(object sender, RoutedEventArgs e)
        {
            WinSpisock winSpisock = new WinSpisock();
            winSpisock.Show();
            this.Hide();
        }

        private void BtnEntrance_Click(object sender, RoutedEventArgs e)
        {
            WinEntrance winEntrance = new WinEntrance();
            winEntrance.Show();
            this.Hide();
        }
    }
}
