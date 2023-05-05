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
    public partial class UpdateAppointment : Form
    {
        public UpdateAppointment()
        {
            InitializeComponent();
        }
        public UpdateAppointment(int appointmentId, int customerId, int userId, string appointmentType, DateTime startTime, DateTime endTime)
        {
            InitializeComponent();
            LoadUserBoxUpdate();
            LoadAppointmentTypeUpdate();
            LoadCustomerComboBoxUpdate();

            AppointmentIdBox.Text = appointmentId.ToString();
            CustIdBox.Text = customerId.ToString();
            UserIdBox.Text = userId.ToString();
            AppointTypeBox.Text = appointmentType;
            StartTimePicker.Text = startTime.ToString();
            EndTimePicker.Text = endTime.ToString();


       
        }
        //Loads user information from MySqlDatabase 
        //Enables the UserId to display userName instead.
        public void LoadUserBoxUpdate()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string userSelect = @"SELECT * 
                                      FROM user";

            MySqlCommand comUserSelect = new MySqlCommand(userSelect, conn2);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(comUserSelect);
            DataTable dtUser = new DataTable();
            mySqlDataAdapter.Fill(dtUser);

            UserIdBox.DataSource = dtUser;
            UserIdBox.DisplayMember = "userName";
            UserIdBox.ValueMember = "userId";
        }

        //Loads individual appointment types to the combo box while using a lambda 
        // to organize and maintain the list.
        public void LoadAppointmentTypeUpdate()
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
            AppointTypeBox.DataSource = meetingTypes;

        }

        //Loads customer data from Database. 
        public void LoadCustomerComboBoxUpdate()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string customerSelect = @"SELECT * 
                                      FROM customer";

            MySqlCommand comCustomer = new MySqlCommand(customerSelect, conn2);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(comCustomer);
            DataTable dtCust = new DataTable();
            mySqlDataAdapter.Fill(dtCust);

            CustIdBox.DataSource = dtCust;
            CustIdBox.DisplayMember = "customerName";
            CustIdBox.ValueMember = "customerId";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar calendar = new Calendar();
            calendar.Show();
        }
        /* 
          Checks if StartTime is before endtime
            Creates timespan to have operating business hours
         Updates the appointment table with selected data
         */
        private  bool IsOverlap(DateTime start, DateTime end, DateTime ast, DateTime ae)
        {
            return (start < ast) ? (end < ast) ? false : true : (start > ae) ? false : true; 
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (StartTimePicker.Value > EndTimePicker.Value || EndTimePicker.Value < StartTimePicker.Value)
            {
                MessageBox.Show("Please pick a time and date that is after your start time.");
                return;
            }

            TimeSpan startTime = new TimeSpan(08, 00, 00);
            TimeSpan endTime = new TimeSpan(17, 00, 00);

            var startBusinessHours = StartTimePicker.Value.TimeOfDay;
            var endBusinessHours = EndTimePicker.Value.TimeOfDay;

            if (startBusinessHours < startTime || endBusinessHours > endTime)
            {
                MessageBox.Show("Please make an appointment during business hours, 8am - 5pm.");
                return;

            }

            int index;

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string appointmentOverlap = @"SELECT * FROM appointment";
            MySqlCommand overlap = new MySqlCommand(appointmentOverlap, conn2);
            MySqlDataAdapter adapt2 = new MySqlDataAdapter(overlap);
            DataTable dt = new DataTable();
            adapt2.Fill(dt);

            for (index = 0; index < dt.Rows.Count; index++)
            {
                MatchStartPicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["start"], TimeZoneInfo.Local);
                MatchEndPicker.Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[index]["end"], TimeZoneInfo.Local);
                if (IsOverlap(StartTimePicker.Value, EndTimePicker.Value, MatchStartPicker.Value, MatchEndPicker.Value))
                {
                    MessageBox.Show("There is an overlap between your start and end time for your appointment.");
                    return;
                }

            }


            string updateAppointment = @"UPDATE appointment SET customerId = @customerId, userId = @userId, 
                                        type = @appointmentType, start = @startTime, end = @endTime 
                                        WHERE appointmentId = @appointmentId";
            
            MySqlCommand appointmentUpdate = new MySqlCommand(updateAppointment, conn2);
            appointmentUpdate.Parameters.AddWithValue("@customerId", CustIdBox.SelectedValue);
            appointmentUpdate.Parameters.AddWithValue("@userId", UserIdBox.SelectedValue);
            appointmentUpdate.Parameters.AddWithValue("@appointmentType", AppointTypeBox.SelectedValue);
            appointmentUpdate.Parameters.AddWithValue("@startTime", StartTimePicker.Value);
            appointmentUpdate.Parameters.AddWithValue("@endTime", EndTimePicker.Value);
            appointmentUpdate.Parameters.AddWithValue("@appointmentId", AppointmentIdBox.Text);

            appointmentUpdate.ExecuteNonQuery();

            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();


        }   
    }
}
