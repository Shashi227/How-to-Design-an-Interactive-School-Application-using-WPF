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

namespace SchoolManagement_ExcelData
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Studentdata_btn(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.Show();
            this.Close();
        }

        

        private void About_btn_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
            this.Close();
        }

        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            //Home home = new Home();
            //home.Show();
            //this.Close();

        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Apply apply = new Apply();
            apply.Show();
            this.Close();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Course courses = new Course();
            courses.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AboutUs contactus = new AboutUs();
            contactus.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.Show();
            this.Close();

        }
    }
}
