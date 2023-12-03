using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Security.Cryptography;
using System.Xml.Linq;
using Practical_3_Kopylov_Maxim;
using HashPassword;



namespace Vvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {              
                bool t = true;
                while (t)
                {                   
                    var db = Helper.getContext();
                    t = true;
                    Practical_3_Kopylov_Maxim.Models.avtorization avtorization = new Practical_3_Kopylov_Maxim.Models.avtorization();
                    Practical_3_Kopylov_Maxim.Models.sotrudniki sotrudniki = new Practical_3_Kopylov_Maxim.Models.sotrudniki();
                   
                    Console.WriteLine("Добавление данных для нового пользователя");
                    Console.WriteLine("Введите Вашу фамилию: ");
                    string familia = Console.ReadLine();
                    sotrudniki.familia = familia;

                    Console.WriteLine("Введите Ваше имя: ");
                    string imya = Console.ReadLine();
                    sotrudniki.imya = imya;

                    Console.WriteLine("Введите Ваше отчество(при наличии): ");
                    string otchestvo = Console.ReadLine();
                    sotrudniki.otchestvo = otchestvo;

                    Console.WriteLine("Выберите вашу должность(1 - Администратор. 2 - Прораб): ");
                    int job = Convert.ToInt32(Console.ReadLine());
                    sotrudniki.ID_doljnosti = job;

                    Console.WriteLine("Введите номер паспорта: ");
                    string nomer =Console.ReadLine(); 
                    if(int.TryParse(nomer, out int number) && nomer.Length == 4)
                    {
                        sotrudniki.nomer_passporta = Convert.ToString(nomer);
                    }
                    else
                    {
                        Console.WriteLine("В номере паспорта нужно указать 4 цифры");
                    }

                    Console.WriteLine("Введите серию паспорта: ");
                    string seria = Console.ReadLine();
                    if (int.TryParse(seria, out int number2) && seria.Length == 6)
                    {
                        sotrudniki.seria_passporta = Convert.ToString(seria);
                    }
                    else
                    {
                        Console.WriteLine("В серии паспорта нужно указать 6 цифр");
                    }

                    DateTime data = DateTime.Now;
                    sotrudniki.data_priema_na_raboty = data.Date;

                    sotrudniki.ID_polyzovatelia = avtorization.ID_polyzovatelia;

                    Console.WriteLine("Введите Login: ");
                    string login = Console.ReadLine();
                    avtorization.login = login; 

                    Console.WriteLine("Введите Password: ");
                    string password = Console.ReadLine();
                    string hasgPasswords = Class1.HashPassword(password);
                    avtorization.paron = hasgPasswords;
                    Console.WriteLine($"Хэшированный пароль: {hasgPasswords}");

                    db.sotrudniki.Add(sotrudniki);
                    db.avtorization.Add(avtorization);
                    db.SaveChanges();

                    Console.WriteLine("Учетная запись добалена!");
                    Console.WriteLine("Чтобы продолжить нажмите Enter, чтобы завершить введите <конец>");
                    string where = Console.ReadLine();

                    if (where == "конец")
                    { 
                        t = false; 
                    }
                    else 
                    { 
                        t = true; 
                    }
                    Console.Clear();
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
