using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversityMSApp
{
    public partial class Subjects : Sample2
    {
        public Subjects()
        {
            InitializeComponent();
        }


        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";

        // using connection classes

        public SqlConnection con = new SqlConnection(s);




        public void addSubject(string name, int batch)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_insertSubject", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@batch", batch);

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

        public void UpdateSubject(int subjectID, string name, int batch)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_updateSubject", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", subjectID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@batch", batch);
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

        public void DeleteSubject(int subjectID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteSubject", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",subjectID );

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

        public void getAllSubjects(DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSubjects", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();

                subjectIDGV.DataPropertyName = "ID";
                subjectsGV.DataPropertyName = "Subjects";
                batchGV.DataPropertyName = "Batch";



                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


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

        int edit = -1;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (subjectText.Text == ""){ subjectErrorLabel.Visible = true;}
            else { subjectErrorLabel.Visible = false;}
            if (batchDD.SelectedIndex == -1) { batchErrorLabel.Visible = true; } else { batchErrorLabel.Visible = false;}

            if (subjectErrorLabel.Visible || batchErrorLabel.Visible) { MainClass.ShowMSG("Fields with * are mandatory", "Error...", "Error"); }

            else
            {
                if (edit == 0) //Code for save
                {
                    int bID= Convert.ToInt32(batchID);
                    addSubject(subjectText.Text, bID);
                    MainClass.disable_reset(panel5);

                }

                else if( edit==1) //COde for Update
                {
                    int bID = Convert.ToInt32(batchID);
                    UpdateSubject(subjectID, subjectText.Text, bID);
                    MainClass.disable_reset(panel5);
                }

            }


        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DeleteSubject(subjectID);
                //MainClass.ShowMSG(roleText.Text + " Deleted  successfully.", "Success", "Success");
                MainClass.disable_reset(panel5);

            }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            getAllSubjects(dataGridView1);
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
        int subjectID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];  //The cell on which it is clicked, its row corresponding to that Row will be stored in "row".
                                                                       //Now we will fetch data from Row
                subjectID = Convert.ToInt32(row.Cells["subjectIDGV"].Value.ToString());
               
                subjectText.Text = row.Cells["subjectsGV"].Value.ToString();
                batchDD.SelectedItem= row.Cells["batchGV"].Value.ToString();


            }
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            cmbDisplay();
            MainClass.disable_reset(panel5);
        }

        string batchID;
        private void batchDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q = "select batch_id from batches where batch_name= '" + batchDD.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    batchID = dr[0].ToString();
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
            string q = "select batch_name, batch_id from batches";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               batchDD.Items.Add(dr["batch_name"].ToString());
                batchDD.DisplayMember = (dr["batch_name"].ToString());
                batchDD.ValueMember = (dr["batch_id"].ToString());

            }
            con.Close();


        }
    }

   



}



