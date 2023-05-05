using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace client_schedule
{
    public partial class AddCustomer : Form
    {
        private Exception ex;

        public AddCustomer()
        {
            InitializeComponent();

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {


            ex = new Exception(" a problem has occured.");
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();



            //Setup country insert command and execute
            string sqlStringCountry = "INSERT INTO country VALUES(NULL, @country, NOW(), 'user', NOW(), 'user')";
            MySqlCommand comCountry = new MySqlCommand(sqlStringCountry, conn);
            comCountry.Parameters.AddWithValue("@country", countryText.Text);
            comCountry.ExecuteNonQuery();

            int countryId = (int)comCountry.LastInsertedId;

            //Get new countryId from the country command

            //Setup city insert command using countryId as a parameter
            string sqlStringCity = @"INSERT INTO city VALUES(NULL, @city, @countryId, NOW(), 'user',
                                    NOW(), 'user')";
            MySqlCommand comCity = new MySqlCommand(sqlStringCity, conn);
            comCity.Parameters.AddWithValue("@city", cityText.Text);
            comCity.Parameters.AddWithValue("@countryId", countryId);
            comCity.ExecuteNonQuery();

            int cityId = (int)comCity.LastInsertedId;

            //Execute city command

            //Get new city id from the city command

            //Setup address insert command using city id as a parameter
            string sqlStringAddress = @"INSERT INTO address VALUES(NULL, @address,'',
                                       @cityId, 11223, @phone, NOW(), 'user', NOW(), 'user')";
            MySqlCommand comAddress = new MySqlCommand(sqlStringAddress, conn);
            comAddress.Parameters.AddWithValue("@address", addressText.Text);
            comAddress.Parameters.AddWithValue("@cityId", cityId);
            comAddress.Parameters.AddWithValue("@phone", phoneText.Text);
            comAddress.ExecuteNonQuery();

            int addressId = (int)comAddress.LastInsertedId;
            //Execute address command

            //Get new address id from the address command

            //Setup customer insert command using the address id as a parameter

            //Execute customer command

            string sqlCustString = @"INSERT INTO customer VALUES(NULL, @customerName,
                                    @addressid, 1, NOW(), 'user', NOW(), 'user')";

            MySqlCommand comCustomer = new MySqlCommand(sqlCustString, conn);
            comCustomer.Parameters.AddWithValue("@customerName", customerNameText.Text);
            comCustomer.Parameters.AddWithValue("@addressid", addressId);


            try
            {

                comCustomer.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {

                Calendar calendar = new Calendar();
                calendar.Show();
                this.Close();

            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();
        }
    }
}
