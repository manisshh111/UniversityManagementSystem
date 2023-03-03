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

namespace UniversityMSApp
{
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
        }
        
        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";

        // using connection classes

        public SqlConnection con = new SqlConnection(s);

        string rID;
       
        public void addStaff(string name,string username, string password, string phone1, string phone2, int role, Int16 status)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_insertStaff", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                cmd.Parameters.AddWithValue("@phone2", phone2);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@status", status);
                con.Open();
                int x = cmd.ExecuteNonQuery();  // cmd.ExecuteNonQuery() returns no. of rows affected
                if (x > 0)
                {
                    MessageBox.Show(name + " Added successfully");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void getAllStaffs(DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getAllStaffs", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();
                userIDGV.DataPropertyName= "ID";
                NameGV.DataPropertyName = "Name";
                usernameGV.DataPropertyName = "Username";
                Phone1GV.DataPropertyName = "Phone1";
                Phone2GV.DataPropertyName = "Phone2";
                RoleGV.DataPropertyName = "Role";
                StatusGV.DataPropertyName = "Status";





                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateStaff(string name, string username, string password, string phone1, string phone2, int role, Int16 status, int staffID )
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_updateStaff", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                cmd.Parameters.AddWithValue("@phone2", phone2);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@staffID", staffID);

                con.Open();
                int x = cmd.ExecuteNonQuery();  // cmd.ExecuteNonQuery() returns no. of rows affected
                if (x > 0)
                {
                    MessageBox.Show(name + " Updated successfully");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteStaff(int staffID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteStaff", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staffID", staffID);

                con.Open();
                int x = cmd.ExecuteNonQuery();  // cmd.ExecuteNonQuery() returns no. of rows affected
                if (x > 0)
                {
                    MessageBox.Show(" Deleted successfully");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        public void cmbDisplay()
        {
            con.Open();
            string q = "select r_name, r_id from roles";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                roleDD.Items.Add(dr["r_name"].ToString());
                roleDD.DisplayMember= (dr["r_name"].ToString());
                roleDD.ValueMember= (dr["r_id"].ToString());

            }
            con.Close();


        }


        int edit = -1;
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel5);
            
            edit = 0;

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel5);
           
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (userNameText.Text == "") { userNameErrorLabel.Visible = true; } else { userNameErrorLabel.Visible = false; }
            if (passwordText.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (cnfPasswordText.Text == "") { cnfPasswordErrorLabel.Visible = true; } else { cnfPasswordErrorLabel.Visible = false; }
            if (phone1Text.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
           // if (roleDD.SelectedIndex == -1) { roleDD.Visible = true; } else { roleDD.Visible = false; }
            //if (statusDD.SelectedIndex == -1) { statusDD.Visible = true; } else { statusDD.Visible = false; }   

            if(nameErrorLabel.Visible || userNameErrorLabel.Visible || passwordErrorLabel.Visible || cnfPasswordErrorLabel.Visible || roleErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Field with * are Important.", "Stop...", "Error");
                
            }
            else
            {
                if(edit==0)  //Code for SAVE Operation, when ADD button is pressed, save btn will work as save
                {


                    Int16 status = statusDD.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    int roleID = Convert.ToInt32(rID);

                    addStaff(nameText.Text, userNameText.Text, passwordText.Text, phone1Text.Text, phone2Text.Text,roleID , status);


                    MainClass.disable_reset(panel5);
                }

                else if (edit == 1) //Code for Update operation, when edit button is pressed, save button will act as Update button
                {

                    Int16 status = statusDD.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    int roleID = Convert.ToInt32(rID);

                    UpdateStaff(nameText.Text, userNameText.Text, passwordText.Text, phone1Text.Text, phone2Text.Text, roleID, status, staffID );


                    MainClass.disable_reset(panel5);

                }



            }
            
            
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteStaff(staffID);

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            getAllStaffs(staffsGV);
            MainClass.disable(panel5);

        }

        private void backBtn_Click(object sender, EventArgs e)

        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
            obj.Show();
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            if (nameText.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
        }

        private void userNameText_TextChanged(object sender, EventArgs e)
        {
            if (userNameText.Text == "") { userNameErrorLabel.Visible = true; } else { userNameErrorLabel.Visible = false; }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (passwordText.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }

        private void cnfPasswordText_TextChanged(object sender, EventArgs e)
        {
            if (cnfPasswordText.Text == "") { cnfPasswordErrorLabel.Visible = true; } else { cnfPasswordErrorLabel.Visible = false; }
        }

        private void cnfPasswordText_Validating(object sender, EventArgs e)
        {
            if(passwordText.Text!= cnfPasswordText.Text) { mismatchedErrorLabel.Visible = true; } else { mismatchedErrorLabel.Visible = false; }
        }

        private void phone1Text_TextChanged(object sender, EventArgs e)
        {
            if (phone1Text.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
        }


        
        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (roleDD.SelectedIndex == -1) { roleDD.Visible = true; } else { roleDD.Visible = false; }

            

            try
            {
                con.Open();
                string q = "select r_id from roles where r_name= '" + roleDD.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rID = dr[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (statusDD.SelectedIndex == -1) { statusDD.Visible = true; } else { statusDD.Visible = false; }
        }

        

        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5); //Disable-Reset panel5 (Panel 5 contains all the user input controls)
            cmbDisplay();
        }

        int staffID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = staffsGV.Rows[e.RowIndex];  //The cell on which it is clicked, its row corresponding to that Row will be stored in "row".
                                                                       //Now we will fetch data from Row
                staffID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                
                nameText.Text = row.Cells["NameGV"].Value.ToString();
                userNameText.Text= row.Cells["usernameGV"].Value.ToString();
                phone1Text.Text= row.Cells["Phone1GV"].Value.ToString();
                phone2Text.Text= row.Cells["Phone2GV"].Value.ToString();
                roleDD.SelectedItem = row.Cells["RoleGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }


            /*
             
            userIDGV.DataPropertyName= "ID";
                NameGV.DataPropertyName = "Name";
                usernameGV.DataPropertyName = "Username";
                Phone1GV.DataPropertyName = "Phone1";
                Phone2GV.DataPropertyName = "Phone2";
                RoleGV.DataPropertyName = "Role";
                StatusGV.DataPropertyName = "Status";

            */



        }
    }


}
