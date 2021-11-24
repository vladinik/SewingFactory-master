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
    /// Логика взаимодействия для WinSpisokIz.xaml
    /// </summary>
    public partial class WinSpisokIz : Window
    {
        List<Furniture> furnitures = new List<Furniture>();
        public WinSpisokIz()
        {
            InitializeComponent();
            FillTable();
        }
        private void FillTable()
        {
            furnitures.Clear();

            using (FurnitureEntities db = new FurnitureEntities())
            {
                foreach (Furniture i in db.Furniture)

                    furnitures.Add(i);
                DgSpisockIz.ItemsSource = db.Cloth.Local.ToBindingList();
            }
        }

        private void BtnExtin_Click(object sender, RoutedEventArgs e)
        {
            WinManager winManager = new WinManager();
            winManager.Show();
            this.Hide();
        }
    }
}
