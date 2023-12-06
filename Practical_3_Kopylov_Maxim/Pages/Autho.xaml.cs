using HashPassword;
using Practical_3_Kopylov_Maxim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using System.Timers;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Media;



namespace Practical_3_Kopylov_Maxim.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autho.xaml
    /// </summary>
    public partial class Autho : Page
    {
        private DispatcherTimer timer;
        public Autho()
        {          
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

        }

        private int cap = 0;
        private int srok = 10;
        private int attempts = 3;

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = txtbLogin.Text.Trim();
            string password = pswbPassword.Password.Trim();
            string Hash = Class1.HashPassword(password);
            var doljnosti = Helper.getContext().sotrudniki.Where(d => d.ID_doljnosti == 2).FirstOrDefault();

            Models.sotrudniki sotrudniki = new Models.sotrudniki();

            if (login.Length > 0 && password.Length > 0)
            {
                if (cap < 1)
                {
                    var job = Helper.getContext().sotrudniki;
                    var user = EntityBuilding.GetContext().avtorization.Where(u => u.login == login && u.paron == Hash).FirstOrDefault();
                    if (user != null)
                    {
                        var id = EntityBuilding.GetContext().sotrudniki.Where(id1 => id1.ID_polyzovatelia == user.ID_polyzovatelia).FirstOrDefault();
                        var asd = id.doljnosti;
                        attempts = 3;
                        if(asd.doljnost == "Администратор")
                        {
                            NavigationService.Navigate(new Admin());
                        }
                        else if(asd.doljnost == "Прораб")
                        {
                            NavigationService.Navigate(new Prorab());
                        }

                    }
                    else
                    {
                        if(attempts > 1)
                        {
                            attempts--;
                            MessageBox.Show($"Такой пользователь не найден\n Пройдите Капчу. У вас осталось {attempts} попытки для верного ввода данных!");
                            cap++;
                            txtBlockCaptcha.Text = GenerateRandomCaptcha(4);
                        }
                        else
                        { 
                            txtbLogin.IsEnabled = false;
                            pswbPassword.IsEnabled = false;
                            txtbLogin.Clear();
                            pswbPassword.Clear();
                            srok = 10;
                            LbTimer.Content = srok.ToString();
                            timer.Start();
                            LbTimer.Foreground = Brushes.Red;
                            LbTimer.Content = "Осталось секунд до разблокировки: 10";
                            attempts = 3;
                            MessageBox.Show("Вы заблокированы на 10 секунд");

                        }
                    }
                }
                else
                {
                    var user = Helper.getContext().avtorization.Where(u => u.login == login && u.paron == password).FirstOrDefault();
                    string captcha = txtboxCaptcha.Text;
                    if (captcha == txtBlockCaptcha.Text)
                    {                       
                        TextLogin.Text = "Логин:";
                        TextPassword.Text = "Пароль:";
                        txtBlockCaptcha.Visibility = Visibility.Collapsed;
                        txtboxCaptcha.Visibility = Visibility.Collapsed;
                        txtbLogin.Visibility = Visibility.Visible;
                        pswbPassword.Visibility = Visibility.Visible;
                        txtBlockCaptcha.TextDecorations = null;
                        txtBlockCaptcha.FontStyle = FontStyles.Normal;
                        txtbLogin.Clear();
                        pswbPassword.Clear();
                        txtboxCaptcha.Clear();
                        cap--;
                        MessageBox.Show("Капча введена верно, попробуйте авторизироваться еще раз");

                    }
                    else
                    {
                        MessageBox.Show("Капча введена неверно");
                        txtboxCaptcha.Text = "";
                        txtBlockCaptcha.Text = GenerateRandomCaptcha(4);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Не все поля заполнены! Заполните поля логина и пароля!");
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LbTimer.Content = "";
            srok--;
            LbTimer.Content = "Осталось секунд до разблокировки: " + srok.ToString();
            if(srok == 0)
            {
                LbTimer.Content = "";
                timer.Stop();
                txtbLogin.IsEnabled = true;
                pswbPassword.IsEnabled = true;
                MessageBox.Show("Вы разблокированы");
            }
        }

        private string GenerateRandomCaptcha(int length)
        {           
            TextLogin.Text = "";
            TextPassword.Text = "Введи зачёркнутый текст";
            txtbLogin.Visibility = Visibility.Collapsed;
            pswbPassword.Visibility = Visibility.Collapsed;
            txtboxCaptcha.Visibility = Visibility.Visible;
            txtBlockCaptcha.Visibility = Visibility.Visible;

            txtBlockCaptcha.TextDecorations = TextDecorations.Strikethrough;

            txtBlockCaptcha.FontStyle = FontStyles.Italic;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new client(null));
        }

        private void CBRoli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBAdmin_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
