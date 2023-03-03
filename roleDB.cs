using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace UniversityMSApp
{
    internal class roleDB
    {
        //private static string s = "Data Source= DESKTOP-BN6S5L2\\SQLEXPRESS; Initial Catalog= ums; User ID= admin; Password=manish";

        // using connection classes

       // public  SqlConnection con = new SqlConnection(s);

        /*
        public void getAllRoles(DataGridView gv)
        {
            try
            {
                SqlCommand cmd= new SqlCommand("st_getAllRoles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da= new SqlDataAdapter(cmd);  //sqlDataAdapter holds all the data received from the database
                con.Open();
                DataTable dt= new DataTable();  // Transform data from data adapter to data table
                da.Fill(dt);  //data adapter will fill all the data into dt
                con.Close();

                

                gv.DataSource = dt; // Passing data table value to data gridView
                
                


            }
            catch(Exception ex)
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
        */

    }
}
