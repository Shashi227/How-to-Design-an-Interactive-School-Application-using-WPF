using Syncfusion.XlsIO;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace SchoolManagement_ExcelData
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        UserDataService _objExcelSer;
        Student _stud = new Student();

        List<Student> students = new List<Student>();
        string fogilo = @"C:\Users\shash\OneDrive\Desktop\WPFC#\SchoolManagement_ExcelData\SchoolManagement_ExcelData\bin\Debug\Output.xlsx";

        //public Student _stud { get; private set; }

        public Window1()
        {
            InitializeComponent();

        }

        //open excel file
        private void Openfile()
        {
            try
            {
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                IWorkbooks books = (IWorkbooks)excelApp.Workbooks;
                IWorkbook sheets = books.Open(fogilo);


            }
            catch (Exception)
            {

                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void GetStudentData()
        {
            _objExcelSer = new UserDataService();
            try
            {
                dataGridStudent.ItemsSource = _objExcelSer.ReadRecordFromEXCELAsync().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //create a workbook
                IWorkbook workbook = application.Workbooks.Create(3);
                IWorksheet worksheet = workbook.Worksheets[0];

                //save the Excel workbook as Output.xlsx
                workbook.SaveAs("Output.xlsx");
                this.Close();
                System.Diagnostics.Process.Start("Output.xlsx");
            }

        }

        private void First_Window_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void add_btn_click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_btn_click(object sender, RoutedEventArgs e)
        {

        }

        private void update_btn_click(object sender, RoutedEventArgs e)
        {

        }

        private void save_btn_click(object sender, RoutedEventArgs e)
        {

        }

        private void reset_btn_click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to load Excel data?", "Confirmation", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                // Yes code here
                GetStudentData();
            }
           
            else
            {
                // Cancel code here  
            }
            
        }

       

        private void Second_window(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //try
            //{
            //    if(dataGridStudent.Items.Count > 0)
            //    {
            //        std_id.Text = ((DataGrid)dataGridStudent.SelectedItem).LoadingRow["StudentID"].ToString();


            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

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

        private void Student_Info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _stud = dataGridStudent.SelectedItem as Student;
        }
    }
}
