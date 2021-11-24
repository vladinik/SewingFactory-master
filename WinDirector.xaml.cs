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
    /// Логика взаимодействия для WinDirector.xaml
    /// </summary>
    public partial class WinDirector : Window
    {
        public WinDirector()
        {
            InitializeComponent();
        }


        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void BtnSpisokIz_Click(object sender, RoutedEventArgs e)
        {
            WinSpisokIz winSpisokIz = new WinSpisokIz();
            winSpisokIz.Show();
            this.Hide();
        }
    }
}
