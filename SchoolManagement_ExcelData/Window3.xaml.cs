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
using System.Windows.Forms;

namespace SchoolManagement_ExcelData
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void submit_click(object sender, RoutedEventArgs e)
        {
            if (pass.Password != "" && user.Text != "")
            {
                if (pass.Password == "password" && user.Text == "admin")
                {
                    Home w1 = new Home();
                    w1.Show();
                    this.Close();


                }
                else
                {
                    System.Windows.MessageBox.Show("Enter valid username and password", "Valid");

                }
            }

        }

        private void check_box_Checked(object sender, RoutedEventArgs e)
        {
            //if(check_box.IsChecked==true)
            //{
            //    pass.UserSystemPasswordChar = false;
            //}
            //else
            //{
            //    pass.UserSystemPasswordChar = true;
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //submit.IsEnabled = false;
        }
    }
}
