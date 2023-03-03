using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UniversityMSApp
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
            passwordText.PasswordChar = '*';
        }

        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";



        public SqlConnection con = new SqlConnection(s);


        public void login(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("login", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database  
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();

                if (dt.Rows[0][0].ToString() == "1")
                {
                    HomeScreen obj = new HomeScreen();
                    MainClass.showWindow(obj, this, MDI.ActiveForm);
                }

                else
                {
                    MessageBox.Show("Please check your Username and Password");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            login(usernameText.Text, passwordText.Text);
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
