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
    public partial class AddAppointment : Form
    {
        //Loads all combo boxes and creates a connection to the database
        public AddAppointment()
        {
            InitializeComponent();

            LoadCustomerComboBox();
            LoadUserBox();
            LoadAppointmentType();
        }
        //Loads customer to customer box by adding their ID and displaying it
        //as the customerName
        public void LoadCustomerComboBox()
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

            CustomerIdBox.DataSource = dtCust;
            CustomerIdBox.DisplayMember = "customerName";
            CustomerIdBox.ValueMember = "customerId";
        }
        //Gets user for userbox from database
        public void LoadUserBox()
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
        //creates a list for appointment types
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
            AppointmentTypeBox.DataSource = meetingTypes;

        }

       

        private bool IsOverlap(DateTime start, DateTime end, DateTime ast, DateTime ae)
        {
            return (start < ast) ? (end < ast) ? false : true : (start > ae) ? false : true;
        }

        //Validates time of day to business hours and start and finish times.
        //Inserts values into appointment table
        public void ConfirmButton()
        {
            if (StartDatePicker.Value > EndDatePicker.Value || EndDatePicker.Value < StartDatePicker.Value)
            {
                MessageBox.Show("Please pick a time and date that is after your start time.");
                return;
            }

            //Business hours Check
            TimeSpan startTime = new TimeSpan(08, 00, 00);
            TimeSpan endTime = new TimeSpan(17, 00, 00);

            var startBusinessHours = StartDatePicker.Value.TimeOfDay;
            var endBusinessHours = EndDatePicker.Value.TimeOfDay;

            if (startBusinessHours < startTime || endBusinessHours > endTime)
            {
                MessageBox.Show("Please make an appointment within business hours, 8am - 5pm.");

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
                if (IsOverlap(StartDatePicker.Value, EndDatePicker.Value, MatchStartPicker.Value, MatchEndPicker.Value))
                {
                    MessageBox.Show("There is an overlap between your start and end time for your appointment.");
                    return;

                }
            }


            string sqlStringAppointment = @"INSERT INTO appointment VALUES(NULL, @customerId, @userId, 
                                            'not needed', 'not needed', 'not needed', 'not needed', @type, 'not needed',
                                            @start, @end, NOW(), 'user', NOW(), 'user')";

            MySqlCommand comAppointmentCreate = new MySqlCommand(sqlStringAppointment, conn2);
            comAppointmentCreate.Parameters.AddWithValue("@customerId", CustomerIdBox.SelectedValue);
            comAppointmentCreate.Parameters.AddWithValue("@userId", UserIdBox.SelectedValue);
            comAppointmentCreate.Parameters.AddWithValue("@type", AppointmentTypeBox.SelectedValue);
            comAppointmentCreate.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeToUtc(StartDatePicker.Value));
            comAppointmentCreate.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeToUtc(EndDatePicker.Value));

            comAppointmentCreate.ExecuteNonQuery();

           // return;

            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();



        }
            private void ConfirmBtn_Click(object sender, EventArgs e)
            {
                ConfirmButton();
            }

            private void CancelBtn_Click(object sender, EventArgs e)
            {
                Calendar calendar = new Calendar();
                calendar.Show();
                this.Close();
            }
        
    } 
}
