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
using System.Text.RegularExpressions;


namespace SchoolManagement_ExcelData
{
    /// <summary>  
    /// Interaction logic for MainWindow.xaml  
    /// </summary>  
    public partial class MainWindow : Window
    {
        ExcelDataService _objExcelSer;
        Student _stud = new Student();

        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>  
        /// Getting Data From Excel Sheet  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetStudentData();
            
        }

        private void GetStudentData()
        {
            _objExcelSer = new ExcelDataService();
            try
            {
                dataGridStudent.ItemsSource = _objExcelSer.ReadRecordFromEXCELAsync().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshRecord_Click(object sender, RoutedEventArgs e)
        {
            GetStudentData();
        }

        /// <summary>  
        /// Getting Data of each cell  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void dataGridStudent_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                FrameworkElement stud_ID = dataGridStudent.Columns[0].GetCellContent(e.Row);
                if (stud_ID.GetType() == typeof(TextBox))
                {
                    _stud.StudentID = Convert.ToInt32(((TextBox)stud_ID).Text);
                }

                FrameworkElement stud_Name = dataGridStudent.Columns[1].GetCellContent(e.Row);
                if (stud_Name.GetType() == typeof(TextBox))
                {
                    _stud.Name = ((TextBox)stud_Name).Text;
                }

                FrameworkElement stud_Email = dataGridStudent.Columns[2].GetCellContent(e.Row);
                if (stud_Email.GetType() == typeof(TextBox))
                {
                    _stud.Email = ((TextBox)stud_Email).Text;
                    //Regex r = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                    //if (r.IsMatch(((TextBox)stud_Email).Text))
                    //{
                    //    _stud.Email = ((TextBox)stud_Email).Text;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Enter valid Email id!");
                    //}
                    
                }

                FrameworkElement stud_Class = dataGridStudent.Columns[3].GetCellContent(e.Row);
                if (stud_Class.GetType() == typeof(TextBox))
                {
                    _stud.Class = ((TextBox)stud_Class).Text;
                }

                FrameworkElement stud_Address = dataGridStudent.Columns[4].GetCellContent(e.Row);
                if (stud_Address.GetType() == typeof(TextBox))
                {
                    _stud.Address = ((TextBox)stud_Address).Text;
                }

                FrameworkElement stud_Dob = dataGridStudent.Columns[5].GetCellContent(e.Row);
                if (stud_Dob.GetType() == typeof(TextBox))
                {
                    _stud.Dob = ((TextBox)stud_Dob).Text;

                    //Regex r = new Regex(@"^(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
                    //if (r.IsMatch(((TextBox)stud_Dob).Text))
                    //{
                    //    //int past = Convert.ToInt32(((TextBox)stud_Dob).Text);
                    //    //DateTime today = DateTime.Today;
                    //    //int sub = Convert.ToInt32(today);
                    //    //if(Convert.ToInt32(today - past) ==18 )
                    //    //{

                    //    //}
                    //    _stud.Dob = ((TextBox)stud_Dob).Text;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Enter DOB in valid format: dd/mm/yyyy !");
                    //}
                    
                }

                FrameworkElement stud_PhoneNo = dataGridStudent.Columns[6].GetCellContent(e.Row);
                if (stud_PhoneNo.GetType() == typeof(TextBox))
                {
                    _stud.PhoneNo = ((TextBox)stud_PhoneNo).Text;

                    //Regex r = new Regex(@"^[0-9]{10}$");
                    //if (r.IsMatch(((TextBox)stud_PhoneNo).Text))
                    //{
                    //    _stud.PhoneNo = ((TextBox)stud_PhoneNo).Text;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid mobile number!");
                    //}
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>  
        /// Get entire Row  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void dataGridStudent_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            try
            {
                bool IsSave = _objExcelSer.ManageExcelRecordsAsync(_stud).Result;
                if (IsSave)
                {
                    MessageBox.Show("Student Record Saved Successfully.");
                }
                else
                {
                    MessageBox.Show("Some Problem Occured.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>  
        /// Get Record info to update  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void dataGridStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _stud = dataGridStudent.SelectedItem as Student;
        }

        private void Home_click(object sender, RoutedEventArgs e)
        {
            Home w4 = new Home();
            w4.Show();
            this.Close();
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to close this window?", "Confirmation", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                // Yes code here
                this.Close();
            }
            else
            {

            }
        }

        //for delete function
        //private void iDelete()
        //{
        //    foreach(dataGridStudentrow item in this.dataGridStudent.SelectedItems)
        //    {
        //        dataGridStudent.SelectedItems.RemoveAt(index);
        //    }
        //}

        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selecteditem = dataGridStudent.SelectedItem;
            if(selecteditem != null)
            {
                MessageBoxResult result = MessageBox.Show(string.Format("Do you want to this data?", selecteditem), "confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    _objExcelSer = new ExcelDataService();
                    try
                    {

                        var result1 = await _objExcelSer.IsDeleteRecordExistAsync(selecteditem as Student);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else
                {
                    MessageBox.Show("First select student details!");
                }
            }
        }
    }
}