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
    /// Логика взаимодействия для WinSpisock.xaml
    /// </summary>
    public partial class WinSpisock : Window
    {
        List<Cloth> cloths = new List<Cloth>();
        
        public WinSpisock()
        {
            InitializeComponent();
            FillTable();
        }
        private void FillTable()
        {
            cloths.Clear();
            
            using(FurnitureEntities db = new FurnitureEntities())
            {
                foreach (Cloth i in db.Cloth) 
                    
                    cloths.Add(i);
                DgSpisock.ItemsSource = db.Cloth.Local.ToBindingList();
            }
        }

        private void BtnExtin_Click(object sender, RoutedEventArgs e)
        {
            WinStorekeeper winStorekeeper = new WinStorekeeper();
            winStorekeeper.Show();
            this.Hide();
        }
    }
}
