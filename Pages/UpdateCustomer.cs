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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public UpdateCustomer(int customerId, int addressId, int cityId, int countryId, string customerName, string customerAddress, string customerPhone, string customerCity, string customerCountry)
        {
            InitializeComponent();
            //populates all data from Customer Table that is selected.

            customerIdBox.Text = customerId.ToString();
            addressIdBox.Text = addressId.ToString();
            cityIdBox.Text = cityId.ToString();
            countryIdBox.Text = countryId.ToString();
            customerNameText.Text = customerName;
            addressText.Text = customerAddress;
            phoneText.Text = customerPhone;
            cityText.Text = customerCity;
            countryText.Text = customerCountry;


        }
        //confirm Button individually updates each record in the MySql Database and proceeds
        //to close the update customer form and reopen calendar
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn2 = new MySqlConnection(connectionString);
            conn2.Open();

            string updateCustomer = @"UPDATE customer SET customerName = @customerName WHERE customerId = @customerId";
            MySqlCommand customerUpdate = new MySqlCommand(updateCustomer, conn2);
            customerUpdate.Parameters.AddWithValue("@customerName", customerNameText.Text);
            customerUpdate.Parameters.AddWithValue("@customerId", customerIdBox.Text);
            customerUpdate.ExecuteNonQuery();
            
            string updateAddress = @"UPDATE address SET address = @address, phone = @phone WHERE addressId = @addressId";
            MySqlCommand addressUpdate = new MySqlCommand(updateAddress, conn2);
            addressUpdate.Parameters.AddWithValue("@address", addressText.Text);
            addressUpdate.Parameters.AddWithValue("@phone", phoneText.Text);
            addressUpdate.Parameters.AddWithValue("@addressId", addressIdBox.Text);
            addressUpdate.ExecuteNonQuery();

            string updateCity = @"UPDATE city SET city = @city WHERE cityId = @cityId";
            MySqlCommand cityUpdate = new MySqlCommand(updateCity, conn2);
            cityUpdate.Parameters.AddWithValue("@city", cityText.Text);
            cityUpdate.Parameters.AddWithValue("@cityId", cityIdBox.Text);
            cityUpdate.ExecuteNonQuery();

            string updateCountry = @"UPDATE country SET country = @country WHERE countryId = @countryId";
            MySqlCommand countryUpdate = new MySqlCommand(updateCountry, conn2);
            countryUpdate.Parameters.AddWithValue("@country", countryText.Text);
            countryUpdate.Parameters.AddWithValue("@countryId", countryIdBox.Text);
            countryUpdate.ExecuteNonQuery();


            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Calendar calendar = new Calendar();
            calendar.Show();
        }
    }
}
