using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_schedule
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        MySqlConnection conn = null;
        Exception excep;
        string path = @"c:\logFile";


        public Login()

        {
            InitializeComponent();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }


        }
        //Translates language and culture info on login page to Spanish in Spain.
        private void Form1_Load(object sender, EventArgs e)
        {

            // CultureInfo.CurrentCulture = new CultureInfo("es");   //for test purposes only, remove before submitting


            if (CultureInfo.CurrentCulture.Name == "es")
            {
                excep = new Exception("Nombre de usuario o contraseña incorrecta");
                LoginButton.Text = "Iniciar sesión";
                NewUser.Text = "Nuevo usuario";
                UserName.Text = "Nombre de usuario";
                password.Text = "Contraseña";
            }
            else
            {
                excep = new Exception("Incorrect username or password");
            }

        }

        //Login button includes: StreamWriting to C:\logFile\logFile.txt login info
        //Login also validates username and password from local MySql Database.
        //Proceeds to open Calendar
        private void LoginButton_Click(object sender, EventArgs e)
        {


            MySqlCommand com = new MySqlCommand($"Select * FROM user WHERE userName = @userName and password = @password");

            com.Parameters.AddWithValue("@userName", UserNameText.Text);
            com.Parameters.AddWithValue("@password", PasswordText.Text);

            try
            {
                conn = new MySqlConnection(connectionString);
                com.Connection = conn;
                conn.Open();

                DataTable loginTable = new DataTable();
                int adapter = new MySqlDataAdapter(com).Fill(loginTable);

                if (string.IsNullOrEmpty(UserNameText.Text)  || string.IsNullOrEmpty(PasswordText.Text) )
                {
                    MessageBox.Show("Please enter a valid username and password");

                    return;
                }
                else
                {


                    if (loginTable.Rows.Count <= 0)
                    {

                        using (StreamWriter appendWriter = File.AppendText(Path.Combine(path, "logFile.txt")))
                        {

                            appendWriter.WriteLine(UserNameText.Text + " " + "failed to log in at " + DateTime.Now);
                        }
                        MessageBox.Show("Please use correct credentials.");



                        return;
                    }
                    else
                    {

                        using (StreamWriter writer = File.AppendText(Path.Combine(path, "logFile.txt")))
                        {
                            writer.WriteLine(UserNameText.Text + " " + "logged in at " + DateTime.Now);

                        }

                    }
                }
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);

            }




            conn.Close();

            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();



        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand($"INSERT IGNORE INTO user(username, password, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@username, @password, 1, @dateTime, @username, @dateTime, @username)");
            com.Parameters.AddWithValue("@username", UserNameText.Text);
            com.Parameters.AddWithValue("@password", PasswordText.Text);
            com.Parameters.AddWithValue("@dateTime", DateTime.Now);
            try
            {


                conn = new MySqlConnection(connectionString);
                com.Connection = conn;
                conn.Open();

                DataTable loginTable = new DataTable();
                int adapter = new MySqlDataAdapter(com).Fill(loginTable);


                if (string.IsNullOrEmpty(UserNameText.Text) || string.IsNullOrEmpty(PasswordText.Text))
                {

                    using (StreamWriter appendWriter = File.AppendText(Path.Combine(path, "logFile.txt")))
                    {

                        appendWriter.WriteLine(UserNameText.Text + " " + "failed to create a user on " + DateTime.Now);
                    }
                    MessageBox.Show("Please enter a valid User Name and Password.");



                    return;
                }
               
                    else
                    {

                        using (StreamWriter writer = File.AppendText(Path.Combine(path, "logFile.txt")))
                        {
                            writer.WriteLine("created a new user named " + UserNameText.Text + DateTime.Now);

                        }
                

                    }
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);

            }
        }
    
    }
}

