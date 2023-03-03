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
    public partial class Departments : Sample2
    {
        public Departments()
        {
            InitializeComponent();
        }







        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";

        // using connection classes

        public SqlConnection con = new SqlConnection(s);




        public void addDepartment(string name)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_insertDepartment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

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

        public void UpdateDepartment(int depID, string name)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_updateDepartment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", depID);
                cmd.Parameters.AddWithValue("@name", name);
                con.Open();
                int x = cmd.ExecuteNonQuery();  // cmd.ExecuteNonQuery() returns no. of rows affected
                if (x > 0)
                {
                    MessageBox.Show(" Updated successfully");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteDepartment(int depID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteDepartment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", depID);

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

        public void getAllDepartments(DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getDepartments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();

                departmentIDGV.DataPropertyName = "ID";
                departmentsGV.DataPropertyName = "Departments";


                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }









        private void Departments_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int edit = -1;
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
            if (departmentText.Text == "") { departmentErrorLabel.Visible = true; }
            else { departmentErrorLabel.Visible = false; }

            if (departmentErrorLabel.Visible) { MainClass.ShowMSG("Fields with * are mandatory", "Error...", "Error"); }

            else
            {
                if (edit == 0) //Code for save
                {
                    addDepartment(departmentText.Text);
                    MainClass.disable_reset(panel5);

                }

                else if (edit == 1) //Code for Update
                {
                    UpdateDepartment(depID, departmentText.Text);
                    MainClass.disable_reset(panel5);
                }

            }


        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Are you sure ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DeleteDepartment(depID);
                //MainClass.ShowMSG(roleText.Text + " Deleted  successfully.", "Success", "Success");
                MainClass.disable_reset(panel5);

            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            getAllDepartments(dataGridView1);
            MainClass.disable(panel5);
        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        public void backBtn_Click(object sender, EventArgs e)

        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
            obj.Show();
        }


        int depID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];  //The cell on which it is clicked, its row corresponding to that Row will be stored in "row".
                                                                       //Now we will fetch data from Row
                depID = Convert.ToInt32(row.Cells["departmentIDGV"].Value.ToString());
               
               departmentText.Text = row.Cells["departmentsGV"].Value.ToString();

            }
        }
    }
}
