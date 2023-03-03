using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversityMSApp
{
    public partial class Roles : Sample2
    {
        public Roles()
        {
            InitializeComponent();
        }

        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";

        // using ADO.Net classes for 

        public SqlConnection con = new SqlConnection(s);

        public void getAllRoles(DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getAllRoles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();

                roleIDGV.DataPropertyName = "ID";
                RolesGV.DataPropertyName = "Role";
                StatusGV.DataPropertyName = "Status";

                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void addRole(string name, Int16 status)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_insertRoles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
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

        public void UpdateRole(string name, Int16 status, int roleID)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_updateRoles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@roleID", roleID);
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

        public void DeleteRole(int roleID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteRole", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@roleID", roleID);

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

        
   
        int edit = -1;

        //Overriding methods from sample2 class
        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel5);
        }


        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel5);

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            //----------------------------------------------------------
            if (roleText.Text == "")
            {
                roleErrorLabel.Visible = true;
            }
            else
            {
                roleErrorLabel.Visible = false;
            }

            if (statusDD.SelectedIndex == -1)
            {
                statusErrorLabel.Visible = true;
            }
            else
            {
                statusErrorLabel.Visible = false;
            }

            //-----------------------------------------------------

            if (roleErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Error...", "Error");
            }
            else
            {
                if(edit==0)//code for save
                {
                   
                    Int16 status = statusDD.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    
                    addRole(roleText.Text, status);

                   
                    MainClass.disable_reset(panel5);


                }
                else if (edit == 1)// code for update
                {
                    Int16 status = statusDD.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    UpdateRole(roleText.Text, status, roleID);
                    //MainClass.ShowMSG(roleText.Text + " Updated  successfully.", "Success", "Success");
                    MainClass.disable_reset(panel5);

                }    

            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DeleteRole(roleID);
                //MainClass.ShowMSG(roleText.Text + " Deleted  successfully.", "Success", "Success");
                MainClass.disable_reset(panel5);

            }


            

        }



        public override void viewBtn_Click(object sender, EventArgs e)
        {
           // roleDB obj = new roleDB();
            getAllRoles(dataGridView1);
            MainClass.disable(panel5);

        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void roleErrorLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(statusDD.SelectedIndex == -1)
            {
                statusErrorLabel.Visible=true;
            }
            else
            {
                statusErrorLabel.Visible = false;
            }
        }

        private void roleText_TextChanged(object sender, EventArgs e)
        {
            if (roleText.Text == "")
            {
                roleErrorLabel.Visible = true;
            }
            else
            {
                roleErrorLabel.Visible = false;
            }
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            //getAllRoles(dataGridView1);
        }

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

          int roleID;  //This variable is to be used in update method
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];  //The cell on which it is clicked, its row corresponding to that Row will be stored in "row".
                                                                       //Now we will fetch data from Row
                roleID = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
                // roleID = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
                roleText.Text = row.Cells["RolesGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }

        }
    }
}
