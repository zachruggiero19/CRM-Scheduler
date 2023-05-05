using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_schedule
{
    public partial class Calendar : Form
    {

        //Loads datagrids from methods below
        public Calendar()
        {
            InitializeComponent();
            LoadAppointment();
            LoadCustomer();
           // LoadReport();

        }

      
        /// <summary>
        /// Loads appointment data grid with all appointments
        /// from appointment table
        /// </summary>
        private void LoadAppointment()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string sqlString = "SELECT* FROM appointment";
            MySqlCommand cmd = new MySqlCommand(sqlString, conn2);
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                dt.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["start"], TimeZoneInfo.Local).ToString();
            }


            AppointmentGrid.DataSource = dt;
            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.MultiSelect = false;
        }
        /// <summary>
        /// Loads customer data from customer
        /// table, includes inner joins to access data
        /// that is from: address, city, country
        /// </summary>
        private void LoadCustomer()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn3 = new MySqlConnection(connectionString);
            conn3.Open();

            string sqlCustString = @"SELECT distinct customer.customerId, customer.customerName, 
                                    address.address, address.addressId, address.phone, 
                                    city.city, city.cityId, 
                                    country.country, country.countryId
                                     FROM
                                    customer
                                    INNER JOIN address on customer.addressId = address.addressId
                                    INNER JOIN city on address.cityId = city.cityId
                                    INNER JOIN country on city.countryId = country.countryId";



            //string sqlCustString = "SELECT* FROM customer";
            MySqlCommand cmd2 = new MySqlCommand(sqlCustString, conn3);
            MySqlDataAdapter adapt2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);

            CustomerGrid.DataSource = dt2;
            CustomerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGrid.MultiSelect = false;
        }

        //Opens AddAppointment/Event
        private void AddEvntBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
        }
        //sends data to Update Event/Appointment and opens Update Appointment form
        private void UpdateEvntBtn_Click(object sender, EventArgs e)
        {

            int appointmentIndex = AppointmentGrid.CurrentRow.Index;
            DataTable appointDataTable = (DataTable)AppointmentGrid.DataSource;

            int appointmentId = (int)appointDataTable.Rows[appointmentIndex]["appointmentId"];
            int customerId = (int)appointDataTable.Rows[appointmentIndex]["customerId"];
            int userId = (int)appointDataTable.Rows[appointmentIndex]["userId"];
            string appointmentType = (string)appointDataTable.Rows[appointmentIndex]["type"];
            DateTime startTime = (DateTime)appointDataTable.Rows[appointmentIndex]["start"];
            DateTime endTime = (DateTime)appointDataTable.Rows[appointmentIndex]["end"];

            this.Hide();
            UpdateAppointment updateAppointment = new UpdateAppointment(appointmentId, customerId, userId,  appointmentType, startTime, endTime);
            updateAppointment.Show();
        }

        private void DeleteEvntBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connEvnt = new MySqlConnection(connectionString);
            connEvnt.Open();

            const string deleteMessage =
            "Are you sure you want to delete that Appointment?";
            const string caption = "Delete Appointment";
            var answer = MessageBox.Show(deleteMessage, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            int index = AppointmentGrid.CurrentRow.Index;
            DataTable dataTable = (DataTable)AppointmentGrid.DataSource;
            int appointmentId = (int)dataTable.Rows[index]["appointmentId"];

            if (answer == DialogResult.Yes)
            {
                string sqlStringAppointment = "DELETE from appointment where appointmentId = @APPOINTID";
                MySqlCommand com = new MySqlCommand(sqlStringAppointment, connEvnt);
                com.Parameters.AddWithValue("@APPOINTID", appointmentId);
                com.ExecuteNonQuery();
            }
            else
            {
                return;
            }
            LoadAppointment();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();


        }
        //Opens update customer with selected data from datagrid.
        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();


            int customerIndex = CustomerGrid.CurrentRow.Index;
            DataTable custDataTable = (DataTable)CustomerGrid.DataSource;

            int customerId = (int)custDataTable.Rows[customerIndex]["customerId"];
            int addressId = (int)custDataTable.Rows[customerIndex]["addressId"];
            int cityId = (int)custDataTable.Rows[customerIndex]["cityId"];
            int countryId = (int)custDataTable.Rows[customerIndex]["countryId"];
            string customerName = (string)custDataTable.Rows[customerIndex]["customerName"];
            string customerAddress = (string)custDataTable.Rows[customerIndex]["address"];
            string customerPhone = (string)custDataTable.Rows[customerIndex]["phone"];
            string customerCity = (string)custDataTable.Rows[customerIndex]["city"];
            string customerCountry = (string)custDataTable.Rows[customerIndex]["country"];

            this.Hide();
            UpdateCustomer updateCustomer = new UpdateCustomer(customerId, addressId, cityId, countryId, customerName, customerAddress, customerPhone, customerCity, customerCountry);
            updateCustomer.Show();
            
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connCust = new MySqlConnection(connectionString);
            connCust.Open();

            const string deleteMessage =
           "Are you sure you want to delete that customer?";
            const string caption = "Delete Customer";
            var answer = MessageBox.Show(deleteMessage, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            int index = CustomerGrid.CurrentRow.Index;
            DataTable dataTable = (DataTable)CustomerGrid.DataSource;
            int customerId = (int)dataTable.Rows[index]["customerId"];

            if (answer == DialogResult.Yes)
            {
                string sqlStringApp = "DELETE from appointment where customerId = @CUSTOMERID";
                MySqlCommand comAppDel = new MySqlCommand(sqlStringApp, connCust);
                comAppDel.Parameters.AddWithValue("@CUSTOMERID", customerId);
                comAppDel.ExecuteNonQuery();

                string sqlStringCust = "Delete FROM customer where customerid = @CUSTOMERID ";
                MySqlCommand comCustDel = new MySqlCommand(sqlStringCust, connCust);
                comCustDel.Parameters.AddWithValue("@CUSTOMERID", customerId);
                comCustDel.ExecuteNonQuery();
            }
            else
            {
                return;
            }
            LoadCustomer();





        }
        //When Calendar loads or is reloaded a datatable is called
        //and a MySql command checks for an appointment that is in 
        //the next 15 minutes. Presents a messagebox as an alert.
        private void Calendar_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();
           
            DateTime appointmentTime = DateTime.Now;

            string appointmentSelect = @"SELECT * 
                                            FROM appointment
                                            WHERE start BETWEEN @atNow AND @fifteenNow";
            MySqlCommand comTimeSelect = new MySqlCommand(appointmentSelect, conn2);
            comTimeSelect.Parameters.AddWithValue("@atNow", appointmentTime);
            comTimeSelect.Parameters.AddWithValue("@fifteenNow", appointmentTime.AddMinutes(15));
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(comTimeSelect);

            DataTable timeSelectTable = new DataTable();
            mySqlDataAdapter.Fill(timeSelectTable);

            for (int index = 0; index < timeSelectTable.Rows.Count; index++)
            {
                MessageBox.Show("You have an appointment in the next 15 minutes");
            }





        }

        
        private void MonthButton_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            DateTime startDate = dateTimeStart.Value;
           

                      
            string appointmentSelect = @"SELECT * 
                                            FROM appointment
                                            WHERE start BETWEEN @startDate AND @monthDate";
            MySqlCommand comAppointment = new MySqlCommand(appointmentSelect, conn2);
            comAppointment.Parameters.AddWithValue("@startDate", startDate);
            comAppointment.Parameters.AddWithValue("@monthDate", startDate.AddMonths(1));
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(comAppointment);

            DataTable appointmentTable = new DataTable();
            mySqlDataAdapter.Fill(appointmentTable);

            for (int index = 0; index < appointmentTable.Rows.Count; index++)
            {
                appointmentTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                
            }

            AppointmentGrid.DataSource = appointmentTable;
            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.MultiSelect = false;



        }

        private void WeekButton_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            DateTime startDateWeek = dateTimeStart.Value;

            string appointmentWeekSelect = @"SELECT * 
                                            FROM appointment
                                            WHERE start BETWEEN @startDate AND @weekDate";
            MySqlCommand comAppointmentWeek = new MySqlCommand(appointmentWeekSelect, conn2);
            comAppointmentWeek.Parameters.AddWithValue("@startDate", startDateWeek);
            comAppointmentWeek.Parameters.AddWithValue("@weekDate", startDateWeek.AddDays(7));
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(comAppointmentWeek);

            DataTable appointmentTable = new DataTable();
            mySqlDataAdapter.Fill(appointmentTable);

            for (int index = 0; index < appointmentTable.Rows.Count; index++)
            {
                appointmentTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
            }

            AppointmentGrid.DataSource = appointmentTable;
            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.MultiSelect = false;
        }

        private void AppointmentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllButton_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string sqlString = "SELECT* FROM appointment";
            MySqlCommand cmd = new MySqlCommand(sqlString, conn2);
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                dt.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["start"], TimeZoneInfo.Local).ToString();
            }


            AppointmentGrid.DataSource = dt;
            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.MultiSelect = false;
        }

        private void ReportBox_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int customerSearch;

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string customerSelect = @"SELECT distinct customer.customerId, customer.customerName, 
                                    address.address, address.addressId, address.phone, 
                                    city.city, city.cityId, 
                                    country.country, country.countryId
                                     FROM
                                    customer
                                    INNER JOIN address on customer.addressId = address.addressId
                                    INNER JOIN city on address.cityId = city.cityId
                                    INNER JOIN country on city.countryId = country.countryId
                                    WHERE customerId = @searchId";
            MySqlCommand cmd = new MySqlCommand(customerSelect, conn2);
            cmd.Parameters.AddWithValue("@searchId", SearchBox.Text);
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);

            if (!Int32.TryParse(SearchBox.Text, out customerSearch))
            {
                MessageBox.Show("Please enter an ID to search for customers. Numbers only.");
                SearchBox.Clear();
                SearchBox.Focus();
                return;
            }
            else
            {
                if (int.Parse(SearchBox.Text) < 1)
                {
                    MessageBox.Show("Please enter an ID greater than 1.");
                    return;
                }

                else
                {
                    
                    DataTable dataTable = new DataTable();
                    adapt.Fill(dataTable);

                    CustomerGrid.DataSource = dataTable;
                    CustomerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    CustomerGrid.MultiSelect = false;

                }
            }

        }

        private void AllCustomersButton_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void AllUserButton_Click(object sender, EventArgs e)
        {
            LoadAppointment();
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            int userSearch;
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string userSelect = $"SELECT * FROM appointment WHERE userId = @user";
            MySqlCommand cmd = new MySqlCommand(userSelect, conn2);
            cmd.Parameters.AddWithValue("@user", UserSearchBox.Text);

            if (!Int32.TryParse(UserSearchBox.Text, out userSearch ))
            {
                MessageBox.Show("Please enter a valid User Id");
                return;
            }
            else
            {
                if (int.Parse(SearchBox.Text) < 1)
                {
                    MessageBox.Show("Please enter an ID greater than 1.");
                    return;
                }
                else
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapt.Fill(dataTable);

                    AppointmentGrid.DataSource = dataTable;
                    AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    CustomerGrid.MultiSelect = false;
                }
            }
        }
    }
}
