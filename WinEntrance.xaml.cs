using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для WinEntrance.xaml
    /// </summary>
    public partial class WinEntrance : Window
    {
        List<Entrance> entrances = new List<Entrance>();
        public WinEntrance()
        {
            InitializeComponent();
            FillTable();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            WinNewEntrance winNewEntrance = new WinNewEntrance();
            winNewEntrance.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            WinStorekeeper winStorekeeper = new WinStorekeeper();
            winStorekeeper.Show();
            this.Hide();
        }
        private void FillTable()
        {
            entrances.Clear();

            using (FurnitureEntities db = new FurnitureEntities())
            {
                foreach (Entrance i in db.Entrance)

                    entrances.Add(i);
                DgEntrance.ItemsSource = db.Cloth.Local.ToBindingList();
            }
        }
    }
}
