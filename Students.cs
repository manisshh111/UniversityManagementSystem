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
    public partial class Students : Sample
    {
        public Students()
        {
            InitializeComponent();
        }



        private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";



        public SqlConnection con = new SqlConnection(s);

        public void getDetails(DataGridView gv, int studentID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getStudentDetails", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@studentID", studentID);//sqlDataAdapter holds all the data received from the database
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                

                con.Close();
                //sn_name, sn_batch, sn_gender, sn_father, sn_mother, sn_dob, sn_address, sn_phone,
                //sn_email from student where sn_id=@studentID
                studentNameGV.DataPropertyName = "Name";
                batchGV.DataPropertyName = "Batch";
                genderGV.DataPropertyName = "Gender";
                fatherGV.DataPropertyName = "Father";
                motherGV.DataPropertyName = "Mother";
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

        public void getAttendance(DataGridView gv, int studentID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getStudentAttendance", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@studentID", studentID);//sqlDataAdapter holds all the data received from the database
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt


                con.Close();
                
                sessionGV.DataPropertyName = "at_sesion";
                presentGV.DataPropertyName = "at_present";
                totalGV.DataPropertyName = "at_total";
               


                gv.DataSource = dt; // Passing data table value to data gridView




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void getresult(DataGridView gv, int studentID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getStudentResult", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@studentID", studentID);//sqlDataAdapter holds all the data received from the database
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt


                con.Close();
                //select sub_name as 'Subject', res_marks as 'Marks', res_totalMarks as 'Total'
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


        private void enterButton_Click(object sender, EventArgs e)
        {
            int s_id = Convert.ToInt32(enrollText.Text);
            getDetails(detailsGV, s_id);
            getAttendance(attendanceGV, s_id);
            getresult(resultsGV, s_id); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
            obj.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
    }
}
