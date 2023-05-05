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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            LoadAppointmentType();
            LoadUser();
           
        }
        // Loads userId into Consultantbox
        private void LoadUser()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string sqlCommandUser = @"SELECT userId FROM user";
            MySqlCommand userCmd = new MySqlCommand(sqlCommandUser, conn2);
            MySqlDataAdapter adapt = new MySqlDataAdapter(userCmd);
            DataTable dtUserTable = new DataTable();
            adapt.Fill(dtUserTable);

            ConsultantBox.DataSource = dtUserTable;
            ConsultantBox.DisplayMember = "userName";
            ConsultantBox.ValueMember = "userId";
        }

        //determines how many types are in the database
        private void TypeReport_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string sqlCommand = @"SELECT DISTINCT COUNT(type) 
                                FROM appointment
                                WHERE month(start) = @Month AND type = @Type";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, conn2);
            cmd.Parameters.AddWithValue("@Type", TypeComboBox.Text);
            cmd.Parameters.AddWithValue("@Month", MonthPicker.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dtAppointmentSelect = new DataTable();
            adapter.Fill(dtAppointmentSelect);

            TypeGridView.DataSource = dtAppointmentSelect;

        }
        public void LoadAppointmentType()
        {

            List<string> meetingTypes = new List<string>
            {
                "General",
                "Quick Appointment",
                "Sales Meeting",
                "Presentation",
                "Scrum"
            };
            //Lambda expression fixes alphabetical sort.

            meetingTypes = meetingTypes.OrderBy(type => type).ToList();
            TypeComboBox.DataSource = meetingTypes;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Calendar calendar = new Calendar();
            calendar.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string sqlSchedule = @"SELECT * 
                                FROM appointment 
                                WHERE userId = @UserId";
            MySqlCommand cmd = new MySqlCommand(sqlSchedule, conn2);
            cmd.Parameters.AddWithValue("@UserId", ConsultantBox.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dtSchedule = new DataTable();
            adapter.Fill(dtSchedule);

            ScheduleGrid.DataSource = dtSchedule;

        }

        private void ActiveCustomer_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string sqlActive = @"SELECT * 
                                FROM customer
                                WHERE active = 1";
            MySqlCommand cmd = new MySqlCommand(sqlActive, conn2);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dtActive = new DataTable();
            adapter.Fill(dtActive);

            ActiveCustomerGrid.DataSource = dtActive;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
