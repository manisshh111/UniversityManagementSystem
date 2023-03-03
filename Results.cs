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

namespace UniversityMSApp
{
    public partial class Results : Sample2
    {
        public Results()
        {
            InitializeComponent();
        }


        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";



        public SqlConnection con = new SqlConnection(s);



        public void addResult(int studentID, int batchId, int subjectID, int marks, int total )
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_insertResult", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@student_id", studentID);
                cmd.Parameters.AddWithValue("@batch_id", batchId);
                cmd.Parameters.AddWithValue("@subject_id" , subjectID);
                cmd.Parameters.AddWithValue("@marks", marks);
                cmd.Parameters.AddWithValue("@total_marks", total);


                con.Open();
                int x = cmd.ExecuteNonQuery();  // cmd.ExecuteNonQuery() returns no. of rows affected
                if (x > 0)
                {
                    MessageBox.Show(" Added successfully");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void updateResult(int resultID, int studentID, int batchId, int subjectID, int marks, int total)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_updateResult", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@res_id", resultID);
                cmd.Parameters.AddWithValue("@student_id", studentID);
                cmd.Parameters.AddWithValue("@batch_id", batchId);
                cmd.Parameters.AddWithValue("@subject_id", subjectID);
                cmd.Parameters.AddWithValue("@marks", marks);
                cmd.Parameters.AddWithValue("@total_marks", total);


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

        public void DeleteResult(int resultID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteResult", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@res_id", resultID);

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


        public void getAllResult(DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getResult", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();
                ResultIDGV.DataPropertyName = "ID";
                studentIDGV.DataPropertyName = "StudentID";
                nameGV.DataPropertyName = "Name";
                batchGV.DataPropertyName = "Batch";
                subjectGV.DataPropertyName = "Subject";

                marksGV.DataPropertyName = "Marks";
               totalMarksGV.DataPropertyName = "Total";

                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void BatchCBDisplay()
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

        //Fills subject Dropdown with subject name from subject table
        public void SubjectCBDisplay()
        {
            con.Open();
            string q = "select sub_name, sub_id from subjects";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader(); //DataReader reads data from a data source
            while (dr.Read())
            {
                subjectDD.Items.Add(dr["sub_name"].ToString());
                subjectDD.DisplayMember = (dr["sub_name"].ToString());
                subjectDD.ValueMember = (dr["sub_id"].ToString());

            }
            con.Close();


        }

        int edit = -1;

        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel5);

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable(panel5);
            edit = 1;

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (enrollmentText.Text == "") { enrollErrorLabel.Visible = true; } else { enrollErrorLabel.Visible = false; }
            if (batchDD.SelectedIndex == -1) { batchErrorLabel.Visible = true; } else { batchErrorLabel.Visible = false; }
            if(subjectDD.SelectedIndex == -1) { subjectErrorLabel.Visible=true; } else { subjectErrorLabel.Visible = false; }
            if (marksText.Text == "") { marksErrorLabel.Visible = true; } else { marksErrorLabel.Visible = false; } 
            if(totalText.Text=="") { totalErrorLabel.Visible=true; } else { totalErrorLabel.Visible = false; }  


            if(enrollErrorLabel.Visible || batchErrorLabel.Visible || subjectErrorLabel.Visible || marksErrorLabel.Visible || totalErrorLabel.Visible)
            {
                MainClass.ShowMSG("Field with * are Important.", "Stop...", "Error");
            }
            else
            {
                if(edit==0)  // code for save
                {
                    int studentID= Convert.ToInt32(enrollmentText.Text);
                    int btID = Convert.ToInt32(batchID);
                    int sbID = Convert.ToInt32(subID);
                    int marks = Convert.ToInt32(marksText.Text);
                    int total = Convert.ToInt32(totalText.Text);

                    addResult(studentID, btID, sbID, marks, total);
                    
                }

                else if (edit == 1)  //code for update
                {
                    int studentID = Convert.ToInt32(enrollmentText.Text);
                    int btID = Convert.ToInt32(batchID);
                    int sbID = Convert.ToInt32(subID);
                    int marks = Convert.ToInt32(marksText.Text);
                    int total = Convert.ToInt32(totalText.Text);

                    updateResult(resultID, studentID, btID, sbID, marks, total);
                }
            }


        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteResult(resultID);

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            MainClass.disable(panel5);
            getAllResult(resultGV);
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

        private void Results_Load(object sender, EventArgs e)
        {
            SubjectCBDisplay();
            BatchCBDisplay();
            MainClass.disable(panel5);
        }

        int resultID;
        private void attendanceGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = resultGV.Rows[e.RowIndex];  //The cell on which it is clicked, its row corresponding to that Row will be stored in "row".
                                                                      //Now we will fetch data from Row
                resultID = Convert.ToInt32(row.Cells["resultIDGV"].Value.ToString());
                

                enrollmentText.Text = row.Cells["studentIDGV"].Value.ToString();
                batchDD.SelectedItem = row.Cells["batchGV"].Value.ToString();
                subjectDD.SelectedItem = row.Cells["subjectGV"].Value.ToString();
                marksText.Text = row.Cells["marksGV"].Value.ToString();
                totalText.Text = row.Cells["totalMarksGV"].Value.ToString();

            }
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

        string subID;
        private void subjectDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q = "select sub_id from subjects where sub_name= '" + subjectDD.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    subID = dr[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
