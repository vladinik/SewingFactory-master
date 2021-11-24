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
    /// Логика взаимодействия для WinNewEntrance.xaml
    /// </summary>
    public partial class WinNewEntrance : Window
    {
        
        public WinNewEntrance()
        {
            InitializeComponent();
            CbNewEntrance.ItemsSource = Helper.GetContext().Entrance.ToList();
            SumCalculator();
        }
        public void SumCalculator()
        {
            double totalSum = 0;
            for(int i=0;i< DgNewEntrance.Items.Count;i++)
            {
                string sum = (DgNewEntrance.Columns[3].GetCellContent(DgNewEntrance.Items[i]) as TextBlock).Text.Replace(",", ",");
                totalSum += double.Parse(sum);
            }
            TBSum.Text = totalSum.ToString();
        }

        private void BtnNewAdd_Click(object sender, RoutedEventArgs e)
        {
            WinAddMaterials winAddMaterials = new WinAddMaterials();
            winAddMaterials.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            WinEntrance winEntrance = new WinEntrance();
            winEntrance.Show();
            this.Hide();
        }

        private void BtnSoh_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
