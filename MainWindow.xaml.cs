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

namespace SewingFactory
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

        private void BtnEntry_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TbLogin.Text) && !string.IsNullOrEmpty(PwbPassword.Password))
            {
                try
                {
                    if (TbLogin.Text == Helper.GetContext().User.FirstOrDefault(x => x.Login == TbLogin.Text).Login
                        && PwbPassword.Password == Helper.GetContext().User.FirstOrDefault(x => x.Password == PwbPassword.Password).Password)
                    {
                        User user = Helper.GetContext().User.Find(TbLogin.Text);
                        switch (user.Role)
                        {
                            case "Заказчик":
                                WinCustomer winCustomer = new WinCustomer();
                                winCustomer.Show();
                                this.Close();
                                break;
                            case "Менеджер":
                                WinManager winManager = new WinManager();
                                winManager.Show();
                                this.Close();
                                break;
                            case "Директор":
                                WinDirector winDirector = new WinDirector();
                                winDirector.Show();
                                this.Close();
                                break;
                            case "Кладовщик":
                                WinStorekeeper winStorekeeper = new WinStorekeeper();
                                winStorekeeper.Show();
                                this.Close();
                                break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Авторизация не успешна. Не верны логин или пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Авторизация не успешна. Не верны логин или пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    
        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы хотите зарегистрироватся?", "Регистрация", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                WinRegistration winRegistration = new WinRegistration();
                winRegistration.Show();
                this.Hide();
            }
            else
            {
               
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Show();
            }
        }
    }
}
