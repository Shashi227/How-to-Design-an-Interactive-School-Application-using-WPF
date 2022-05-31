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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace SchoolManagement_ExcelData
{
    /// <summary>
    /// Interaction logic for msaccess.xaml
    /// </summary>
    public partial class msaccess : Window
    {
        public msaccess()
        {
            InitializeComponent();
            LoadGrid();
        }

        SqlConnection con = new SqlConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Software\SchoolManagement.mdb");



        public void ClearData()
        {
            stdID_txt.Clear();
            name_txt.Clear();
            email_txt.Clear();
            address_txt.Clear();
            class_txt.Clear();
            age_txt.Clear();
            phoneno_txt.Clear();
        }

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from FirstTable", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            datagrid.ItemsSource = dt.DefaultView;

        }
        public bool IsValid()
        {
            //if(stdID_txt.Text==String.Empty)
            //{
            //    MessageBox.Show("StudenID is required", "Failed", MessageBoxButton.OK,MessageBoxImage.Error);
            //    return false;
            //}
            if (name_txt.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (email_txt.Text == String.Empty)
            {
                MessageBox.Show("Email is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (address_txt.Text == String.Empty)
            {
                MessageBox.Show("Address is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (class_txt.Text == String.Empty)
            {
                MessageBox.Show("Class is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (phoneno_txt.Text == String.Empty)
            {
                MessageBox.Show("PhoneNo is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (age_txt.Text == String.Empty)
            {
                MessageBox.Show("DOB is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;


        }

        private void Insert_btn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO FirstTable VALUES(@Name, @Email, @Class,@Address,@DOB,@PhoneNo)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@StudentID", stdID_txt.Text);
                    cmd.Parameters.AddWithValue("@Name", name_txt.Text);
                    Regex r = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                    if (r.IsMatch(email_txt.Text))
                    {
                        cmd.Parameters.AddWithValue("@Email", email_txt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Enter valid Email id!");
                    }

                    cmd.Parameters.AddWithValue("@Class", class_txt.Text);
                    cmd.Parameters.AddWithValue("@Address", address_txt.Text);

                    Regex r1 = new Regex(@"^(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
                    if (r1.IsMatch(age_txt.Text))
                    {
                        //int past = Convert.ToInt32(((TextBox)stud_Dob).Text);
                        //DateTime today = DateTime.Today;
                        //int sub = Convert.ToInt32(today);
                        //if(Convert.ToInt32(today - past) ==18 )
                        //{

                        //}
                        cmd.Parameters.AddWithValue("@DOB", age_txt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Enter DOB in valid format: dd/mm/yyyy !");

                    }

                    Regex r2 = new Regex(@"^[0-9]{10}$");
                    if (r2.IsMatch(phoneno_txt.Text))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNo", phoneno_txt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Invalid mobile number!");
                    }




                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadGrid();
                    MessageBox.Show("Successfully Inserted", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearData();

                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                LoadGrid();


            }

        }

        private void Update_btn_Click_1(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update FirstTable set Name='" + name_txt.Text + "', Email='" + email_txt.Text + "',Class='" + class_txt.Text + "',Address='" + address_txt.Text + "',DOB='" + age_txt.Text + "',PhoneNo='" + phoneno_txt.Text + "' WHERE StudentID='" + stdID_txt.Text + "'", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated!", "updated", MessageBoxButton.OK, MessageBoxImage.Information);


            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                ClearData();
                LoadGrid();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from FirstTable where StudentID=" + stdID_txt.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                con.Close();
                ClearData();
                LoadGrid();
                con.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Not Deleted" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {
            ClearData();

        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRow row_selected = gd.SelectedItem as DataRow;
            {
                if (row_selected != null)
                {
                    stdID_txt.Text = row_selected["StudentID"].ToString();
                    name_txt.Text = row_selected["Name"].ToString();
                    email_txt.Text = row_selected["Email"].ToString();
                    address_txt.Text = row_selected["Address"].ToString();
                    class_txt.Text = row_selected["Class"].ToString();
                    age_txt.Text = row_selected["DOB"].ToString();
                    phoneno_txt.Text = row_selected["PhoneNo"].ToString();

                }
            }


        }

        private void GoTo_Excel_Method(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            this.Close();
        }

        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
