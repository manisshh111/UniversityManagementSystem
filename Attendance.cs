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
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversityMSApp
{
    public partial class Attendance : Sample2
    {
        public Attendance()
        {
            InitializeComponent();
        }


        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";

        

        public SqlConnection con = new SqlConnection(s);



        public void addAttendance(int studentID, string session, int present, int total)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_insertAttendance", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@session", session);
                cmd.Parameters.AddWithValue("@present", present);
                cmd.Parameters.AddWithValue("@total", total);
          
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


        public void UpdateAttendance(int attendanceId, int studentID, string session, int present, int total)
        {
            try
            {
                //Passing data to stored procedure

                SqlCommand cmd = new SqlCommand("st_updateAttendance", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@at_id", attendanceId);
                cmd.Parameters.AddWithValue("@Student_id", studentID);
                cmd.Parameters.AddWithValue("@session", session);
                cmd.Parameters.AddWithValue("@present", present);
                cmd.Parameters.AddWithValue("@total", total);


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



        public void DeleteAttendance(int attendanceID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteAttendance", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@at_id", attendanceID);

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


        public void getAllAttendance(DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getAttendance", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();
                attendanceIDGV.DataPropertyName = "ID";
                studentIDGV.DataPropertyName = "StudentID";
                nameGV.DataPropertyName= "Name";
                sessionGV.DataPropertyName = "Session";
                presentGV.DataPropertyName = "Present";
                totalGV.DataPropertyName = "Total";

                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (studentEnrollText.Text == "") { enrollErrorLAbel.Visible = true; } else { enrollErrorLAbel.Visible = false; }
            if (sessionDD.SelectedIndex == -1) { sessionErrorLabel.Visible = true; } else { sessionErrorLabel.Visible = false; }
            if (presentText.Text == "") { presentErrorLabel.Visible = true;  } else { presentErrorLabel.Visible = false; }
            if (totalText.Text == "") { totalErrorLabel.Visible = true; } else{ totalErrorLabel.Visible = false; }


            if(enrollErrorLAbel.Visible || sessionErrorLabel.Visible || presentErrorLabel.Visible || totalErrorLabel.Visible)
            {
                MainClass.ShowMSG("Field with * are Important.", "Stop...", "Error");
            }
            else
            {
                if(edit == 0) //Code for save
                {
                    //Values from UI
                    int st_ID = Convert.ToInt32(studentEnrollText.Text);
                    int presentdays = Convert.ToInt32(presentText.Text);
                    int totaldays = Convert.ToInt32(totalText.Text);

                    addAttendance(st_ID, sessionDD.SelectedItem.ToString(), presentdays, totaldays);
                    MainClass.disable_reset(panel5);

                }

                else if (edit == 1) //Code for update
                {
                    int st_ID = Convert.ToInt32(studentEnrollText.Text);
                    int presentdays = Convert.ToInt32(presentText.Text);
                    int totaldays = Convert.ToInt32(totalText.Text);

                    UpdateAttendance(attendanceID, st_ID, sessionDD.SelectedItem.ToString(), presentdays, totaldays);



                }
            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAttendance(attendanceID);
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            getAllAttendance(attendanceGV);
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
        int attendanceID;
       // int studentID;
        private void staffsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = attendanceGV.Rows[e.RowIndex];  //The cell on which it is clicked, its row corresponding to that Row will be stored in "row".
                                                                  //Now we will fetch data from Row
                attendanceID = Convert.ToInt32(row.Cells["attendanceIDGV"].Value.ToString());
               // studentID = Convert.ToInt32(row.Cells["studentIDGV"].Value.ToString());

                studentEnrollText.Text = row.Cells["studentIDGV"].Value.ToString();
                sessionDD.SelectedItem = row.Cells["sessionGV"].Value.ToString();
                presentText.Text = row.Cells["presentGV"].Value.ToString();
                totalText.Text = row.Cells["totalGV"].Value.ToString();
               
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
        }
    }






}
