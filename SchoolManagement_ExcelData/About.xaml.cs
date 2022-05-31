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
using System.Windows.Shapes;

namespace SchoolManagement_ExcelData
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.Show();
            this.Close();
        }

        private void ContactUs_btn_Click(object sender, RoutedEventArgs e)
        {
            AboutUs contactus = new AboutUs();
            contactus.Show();
            this.Close();
        }

        private void AboutUs_btn_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
            this.Close();
        }

        private void Courses_btn_Click(object sender, RoutedEventArgs e)
        {
            Course course = new Course();
            course.Show();
            this.Close();
        }

        private void Apply_btn_Click(object sender, RoutedEventArgs e)
        {
            Apply apply = new Apply();
            apply.Show();
            this.Close();
        }

        private void Faculty_btn_Click(object sender, RoutedEventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.Show();
            this.Close();
        }
    }
}
