using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace _01Poberezhets
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext=new MainWindowViewModel();

        }
          //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    String Birthday_date = Date_Picker.Text;
        //    if (Birthday_date.Equals(""))
        //        text_Show.Text = "Select your date, please";

        //    DateTime birth = Convert.ToDateTime(Birthday_date);
        //    DateTime today = Convert.ToDateTime(DateTime.Today);
        //    int Year = 0;
        //    if (birth.Month > today.Month || (today.Month == birth.Month && today.Day < birth.Day))
        //    {
        //        Year = today.Year - birth.Year - 1;
        //    }
        //    else
        //    {
        //        if (today.Month == birth.Month && today.Day == birth.Day)
        //            MessageBox.Show("Happy Birthday !");
        //        Year = today.Year - birth.Year;

        //    }

        //    if (Year < 0 || Year > 135)
        //        MessageBox.Show("Bad age");
        //    else text_Show.Text = "You are " + Year + " old";
        //    Zodiak_Show.Text = ShowZodiak(birth);
        //    China_Show.Text = ChinaZod(birth);
        //}
        //private String ShowZodiak(DateTime Date)
        //{
        //    if ((Date.Month==3&&Date.Day>=21)||(Date.Month==4&&Date.Day<=20))
        //    return "Овен";
        //    if ((Date.Month == 4 && Date.Day >= 21) || (Date.Month == 5 && Date.Day <= 21))
        //        return "Телець";
        //    if ((Date.Month == 5 && Date.Day >= 22) || (Date.Month == 6 && Date.Day <= 21))
        //        return "Близнюки";
        //    if ((Date.Month == 6 && Date.Day >= 22 )|| (Date.Month == 7 && Date.Day <= 22))
        //        return "Овен";
        //    if ((Date.Month == 7 && Date.Day >= 23 )|| (Date.Month == 8 && Date.Day <= 21))
        //        return "Лев";
        //    if ((Date.Month == 8 && Date.Day >= 22 )|| (Date.Month == 9 && Date.Day <= 23))
        //        return "Діва";
        //    if ((Date.Month == 9 && Date.Day >= 24 )||(Date.Month == 10 && Date.Day <= 23))
        //        return "Терези";
        //    if ((Date.Month == 10 && Date.Day >= 24) || (Date.Month == 11 && Date.Day <= 22))
        //        return "Скорпіон";
        //    if ((Date.Month == 11 && Date.Day >= 23 )|| (Date.Month == 12 && Date.Day <= 22))
        //        return "Стрілець";
        //    if ((Date.Month == 12 && Date.Day >= 24) || (Date.Month == 1 && Date.Day <= 23))
        //        return "Козеріг";
        //    if ((Date.Month == 1 && Date.Day >= 21) || (Date.Month == 2 && Date.Day <= 19))
        //        return "Водолій";
        //    if ((Date.Month == 2 && Date.Day >= 20) || (Date.Month == 3 && Date.Day <= 20))
        //        return "Риба";
        //    return "Zodiak";
        //}

        //private String ChinaZod(DateTime Date)
        //{
        //    int number = Date.Year % 12;
        //    switch (number)
        //    {
        //        case 0:
        //            return "Мавпа";
        //        case 1:
        //            return "Півень";
        //        case 2:
        //            return "Собака";
        //        case 3:
        //            return "Свиня (Кабан)";
        //        case 4:
        //            return "Щур";
        //        case 5:
        //            return "Бик";
        //        case 6:
        //            return "Тигр";
        //        case 7:
        //            return "Кіт (кролик)";
        //        case 8:
        //            return "Дракон";
        //        case 9:
        //            return "Змія";
        //        case 10:
        //            return "Кінь";
        //        case 11:
        //            return "Коза (вівця)";
        //        default:
        //            return " ";
        //    }
        //}
    }
}
