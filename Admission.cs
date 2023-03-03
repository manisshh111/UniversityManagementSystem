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
    public partial class Admission : Sample2
    {
        public Admission()
        {
            InitializeComponent();
        }



        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";

        // using connection classes

        public SqlConnection con = new SqlConnection(s);

        public void addStudent(string name, int batch, Int16 tenth, Int16 twelfth, Int16 gender,string father, string mother, string fatherprofession, string motherprofession, string dob, string address, string phone,  string email)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_insertStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@batch", batch);
                cmd.Parameters.AddWithValue("@tenth", tenth);
                cmd.Parameters.AddWithValue("@twelfth", twelfth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@father", father);
                cmd.Parameters.AddWithValue("@mother", mother);
                cmd.Parameters.AddWithValue("@fatherprofession", fatherprofession);
                cmd.Parameters.AddWithValue("@motherprofession", motherprofession);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);

                con.Open();
                int x = cmd.ExecuteNonQuery();  // cmd.ExecuteNonQuery() returns no. of rows affected
                if (x > 0)
                {
                    MessageBox.Show(name + " Admitted successfully");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateStudent(string name, int batch, Int16 tenth, Int16 twelfth, Int16 gender, string father, string mother, string fatherprofession, string motherprofession, string dob, string address, string phone, string email, int enrollmentNumber)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("updateStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@batch", batch);
                cmd.Parameters.AddWithValue("@tenth", tenth);
                cmd.Parameters.AddWithValue("@twelfth", twelfth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@father", father);
                cmd.Parameters.AddWithValue("@mother", mother);
                cmd.Parameters.AddWithValue("@fatherprofession", fatherprofession);
                cmd.Parameters.AddWithValue("@motherprofession", motherprofession);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", enrollmentNumber);

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


        public void DeleteStudent(int enrollmentNumber)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", enrollmentNumber);

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

        public void getAllStaffs(DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getAllStudents", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();
                enrollmentGV.DataPropertyName = "ID";
                studentNameGV.DataPropertyName = "Name";
                batchGV.DataPropertyName = "batch";
                tenthMarksGV.DataPropertyName = "Tenth";
                twelfthMarksGV.DataPropertyName = "Twelfth";
                genderGV.DataPropertyName = "Gender";
                fatherNameGv.DataPropertyName = "Father";
                motherNameGV.DataPropertyName = "Mother";
                fProfessionGV.DataPropertyName = "Fathers Profession";
                mProfessionGV.DataPropertyName = "Mothers Profession";
                dobGV.DataPropertyName = "DOB";
                addressGV.DataPropertyName = "Address";
                phoneGV.DataPropertyName = "Phone";
                emailGV.DataPropertyName = "Email";

                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
        int edit = -1;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (studentText.Text == "") { studentErrorLabel.Visible = true; } else { studentErrorLabel.Visible = false; }
            if (batchDD.SelectedIndex == -1) { batchErrorLabel.Visible = true; } else { batchErrorLabel.Visible = false; }
            if (tenthText.Text == "") { tenthErrorLabel.Visible = true; } else { tenthErrorLabel.Visible = false; }
            if (twelfthText.Text == "") { twelfthErrorLabel.Visible = true; } else { twelfthErrorLabel.Visible = false; }
            if (genderDD.SelectedIndex==-1) { genderErrorLabel.Visible = true; } else { genderErrorLabel.Visible = false; }
            if (fatherText.Text == "") { fatherErrorLabel.Visible = true; } else { fatherErrorLabel.Visible = false; }
            if (motherText.Text == "") { motherErrorLabel.Visible = true; } else { motherErrorLabel.Visible = false; }
            if (fProfessionText.Text == "") { fpErrorLabel.Visible = true; } else { fpErrorLabel.Visible = false; }
            //if (dateTimePicker1.Text == "") { .Visible = true; } else { .Visible = false; }
            if (addressText.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (phoneText.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            

            if(studentErrorLabel.Visible || batchErrorLabel.Visible || tenthErrorLabel.Visible || twelfthErrorLabel.Visible ||genderErrorLabel.Visible || 
                fatherErrorLabel.Visible || motherErrorLabel.Visible || fpErrorLabel.Visible || addressErrorLabel.Visible || phoneErrorLabel.Visible)
            {
                MainClass.ShowMSG("Field with * are Important.", "Stop...", "Error");
            }

            else
            {
                if(edit==0) //Code for save operation
                {
                    Int16 gender = genderDD.SelectedItem.ToString() == "Male" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    int btID = Convert.ToInt32(batchID);
                    Int16 tenth = Convert.ToInt16(tenthText.Text.ToString());
                    Int16 twelfth = Convert.ToInt16(twelfthText.Text.ToString());



                    addStudent(studentText.Text, btID, tenth, twelfth, gender, fatherText.Text, motherText.Text, fProfessionText.Text, mProfessionText.Text, dateTimePicker1.Text, addressText.Text, phoneText.Text, emailText.Text);


                }

                else if (edit == 1) //Code for Update
                {
                    Int16 gender = genderDD.SelectedItem.ToString() == "Male" ? Convert.ToInt16(1) : Convert.ToInt16(0);
                    int btID = Convert.ToInt32(batchID);
                    Int16 tenth = Convert.ToInt16(tenthText.Text.ToString());
                    Int16 twelfth = Convert.ToInt16(twelfthText.Text.ToString());



                    UpdateStudent(studentText.Text, btID, tenth, twelfth, gender, fatherText.Text, motherText.Text, fProfessionText.Text, mProfessionText.Text, dateTimePicker1.Text, addressText.Text, phoneText.Text, emailText.Text, enrollmentNo);


                }
            }
   

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure ?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DeleteStudent(enrollmentNo);
                MainClass.disable_reset(panel5);

            }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            getAllStaffs(admissionGV);
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

        private void Admission_Load(object sender, EventArgs e)
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
        int enrollmentNo;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = admissionGV.Rows[e.RowIndex];  //The cell on which it is clicked, its row corresponding to that Row will be stored in "row".
                                                                  //Now we will fetch data from Row
                enrollmentNo = Convert.ToInt32(row.Cells["enrollmentGV"].Value.ToString());

                studentText.Text = row.Cells["studentNameGV"].Value.ToString();
                batchDD.SelectedItem = row.Cells["batchGV"].Value.ToString();
                tenthText.Text = row.Cells["tenthMarksGV"].Value.ToString();
                twelfthText.Text = row.Cells["twelfthMarksGV"].Value.ToString();
                genderDD.SelectedItem = row.Cells["genderGv"].Value.ToString();
                fatherText.Text = row.Cells["fatherNameGV"].Value.ToString();
                motherText.Text = row.Cells["motherNameGV"].Value.ToString();
                fProfessionText.Text = row.Cells["fProfessionGV"].Value.ToString();
                mProfessionText.Text = row.Cells["mProfessionGV"].Value.ToString();
                //dateTimePicker1.Value = row.Cells["dobGV"].Value.ToString();
                addressText.Text = row.Cells["addressGV"].Value.ToString();
                phoneText.Text= row.Cells["phoneGv"].Value.ToString();
                emailText.Text = row.Cells["emailGV"].Value.ToString();

            }
        }

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void admissionGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}


}
