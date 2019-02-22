using _01Poberezhets.Tools.ViewTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace _01Poberezhets
{
    class BirthdayViewModel : BaseViewModel, IChinaHoroscope
    {
        #region Fields
        private string _date;
        private string _birthday_textBlock;
        private string _westHoroscope_textBox;
        private string _chinaHoroscope_textBlock;


        #region Commands
        private RelayCommand<object> _calculateBirthdayCommand;
        private RelayCommand<object> _closeCommand;

        #endregion
        #endregion

        #region Properties
        public string Date
        {
            get => _date;
            set
            {
                _date = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }



        public string Birthday
        {
            get => _birthday_textBlock;
            set
            {
                _birthday_textBlock = value;
                OnPropertyChanged();
            }
        }
        public string West
        {
            get => _westHoroscope_textBox;
            set
            {
                _westHoroscope_textBox = value;
                OnPropertyChanged();
            }
        }
        public string China
        {
            get => _chinaHoroscope_textBlock;
            set
            {
                _chinaHoroscope_textBlock = value;
                OnPropertyChanged();
            }
        }

        #region Commands
        public RelayCommand<object> SignInCommand => _calculateBirthdayCommand ?? (_calculateBirthdayCommand = new RelayCommand<object>(
                           SignInInplementation, o => CanExecuteCommand()));


        //method that calculate user's age
        private void calculateAge(string date)
        {
            LoaderManager.Instance.HideLoader();
            DateTime birth = Convert.ToDateTime(Date);
            DateTime today = Convert.ToDateTime(DateTime.Today);
            int Year = 0;
            if (birth.Month > today.Month || (today.Month == birth.Month && today.Day < birth.Day))
                Year = today.Year - birth.Year - 1;
            else Year = today.Year - birth.Year;

            if (Year < 0 || Year > 135)
            {
                MessageBox.Show("Введіть правдиву дату, будь ласка");
                Date = "";
                return;
            }
            Birthday = "Ваш вік: " + Year;
            West = "Ви " + WestHor(birth) + " за західним гороскопом!";
            China = "Ви " + GiveHoroscope(birth) + " за китайським гороскопом! ";
            if (checkBirthday(Date))
                MessageBox.Show("Happy Birthday !!!");

        }
        //method that return West Horoscope
        private String WestHor(DateTime Date)
        {
            if ((Date.Month == 3 && Date.Day >= 21) || (Date.Month == 4 && Date.Day <= 20))
                return "Овен";
            if ((Date.Month == 4 && Date.Day >= 21) || (Date.Month == 5 && Date.Day <= 21))
                return "Телець";
            if ((Date.Month == 5 && Date.Day >= 22) || (Date.Month == 6 && Date.Day <= 21))
                return "Близнюки";
            if ((Date.Month == 6 && Date.Day >= 22) || (Date.Month == 7 && Date.Day <= 22))
                return "Овен";
            if ((Date.Month == 7 && Date.Day >= 23) || (Date.Month == 8 && Date.Day <= 21))
                return "Лев";
            if ((Date.Month == 8 && Date.Day >= 22) || (Date.Month == 9 && Date.Day <= 23))
                return "Діва";
            if ((Date.Month == 9 && Date.Day >= 24) || (Date.Month == 10 && Date.Day <= 23))
                return "Терези";
            if ((Date.Month == 10 && Date.Day >= 24) || (Date.Month == 11 && Date.Day <= 22))
                return "Скорпіон";
            if ((Date.Month == 11 && Date.Day >= 23) || (Date.Month == 12 && Date.Day <= 22))
                return "Стрілець";
            if ((Date.Month == 12 && Date.Day >= 24) || (Date.Month == 1 && Date.Day <= 23))
                return "Козеріг";
            if ((Date.Month == 1 && Date.Day >= 21) || (Date.Month == 2 && Date.Day <= 19))
                return "Водолій";
            if ((Date.Month == 2 && Date.Day >= 20) || (Date.Month == 3 && Date.Day <= 20))
                return "Риба";
            return "Zodiak";
        }

        //method that check if user has a birthday today
        private bool checkBirthday(string date)
        {
            DateTime today = Convert.ToDateTime(DateTime.Today);
            DateTime birthday = Convert.ToDateTime(Date);
            if (today.Month == birthday.Month && today.Day == birthday.Day)
                return true;
            return false;
        }

        public RelayCommand<Object> CloseCommand
        {
            get
            {
                return _closeCommand ?? (_closeCommand = new RelayCommand<object>(o => Environment.Exit(0)));
            }
        }

        #endregion
        #endregion

        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_date);
        }
        public string GiveHoroscope(DateTime date)
        {
            int year = date.Year % 12;
            return Enum.GetName(typeof(ViewHoroscope), year);
        }

        private async void SignInInplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            await Task.Run(() =>
            {
                Birthday = "";
                West = "";
                China = "";
                Thread.Sleep(500);
            });
            calculateAge(Date);
        }

       

        
    }
}
