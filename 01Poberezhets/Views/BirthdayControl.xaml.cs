﻿using System;
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

namespace _01Poberezhets
{
    /// <summary>
    /// Логика взаимодействия для BirthdayControl.xaml
    /// </summary>
    public partial class BirthdayControl : UserControl
    {
        public BirthdayControl()
        {
            InitializeComponent();
            DataContext = new BirthdayViewModel();
        }
    }
}
