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
    /// Логика взаимодействия для WinRegistration.xaml
    /// </summary>
    public partial class WinRegistration : Window
    {
        public WinRegistration()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TbLogin.Text) && !string.IsNullOrEmpty(PswPassword.Password))
            {
                try
                {
                    using (FurnitureEntities db = new FurnitureEntities())
                    {
                        User user = new User();
                        user.Login = TbLogin.Text;
                        user.Password = PswPassword.Password;
                        user.Name = TbFIO.Text;
                        user.Role = "Заказчик";
                        db.User.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Регистрация прошла успешно", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                }
                catch
                {
                    MessageBox.Show("Регистрация не успешна. Не заполнены поля логина ,пароля или наименования", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            else
            {
                MessageBox.Show("Регистрация не успешна. Не заполнены поля логина ,пароля или наименования", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
