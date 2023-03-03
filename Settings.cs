using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityMSApp
{
    public partial class Settings : Sample // Sample class is parent class
    {
        public Settings()
        {
            InitializeComponent();
        }
        

        private void saveBtn_Click(object sender, EventArgs e)

            
        {
            StringBuilder sb= new StringBuilder();
            // StringBuilder class of .NET is a class to work with strings when repetitive string operations are needed.

            if (isCB.Checked)
            {
                if (datasourceText.Text == "") { datasourceerrorlabel.Visible = true; } else { datasourceerrorlabel.Visible = false; }
                if (databaseText.Text == "") { dberrorlabel.Visible = true; } else { dberrorlabel.Visible = false; }
                
                if(dberrorlabel.Visible || datasourceerrorlabel.Visible)
                {
                    MessageBox.Show("Fields with * are Mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + datasourceText.Text + ";Initial Catalog=" + databaseText.Text + ";Integrated Security= true;MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path + "\\connect",  sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Taken dialogresult here so that when pressing OK Button we go back to login page
                    if(dr== DialogResult.OK)
                    {
                        //Using showWindow method from MainClass which accepts three form objects
                        Login login = new Login();
                       

                        MainClass.showWindow(login, this, MDI.ActiveForm);
                    }    
                }

            }
            else
            {
                if (datasourceText.Text == "") { datasourceerrorlabel.Visible = true; } else { datasourceerrorlabel.Visible = false; }
                if (databaseText.Text == "") { dberrorlabel.Visible = true; } else { dberrorlabel.Visible = false; }
                if (usernameText.Text == "") { usernameerrorlabel.Visible = true; } else { usernameerrorlabel.Visible = false; }
                if (passwordText.Text == "") { passworderrorlabel.Visible = true; } else { passworderrorlabel.Visible = false; }

                if (dberrorlabel.Visible || datasourceerrorlabel.Visible || usernameerrorlabel.Visible || passworderrorlabel.Visible)
                {
                    MessageBox.Show("Fields with * are Mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + datasourceText.Text + ";Initial Catalog=" + databaseText.Text + ";User Id="+ usernameText.Text +";Password="+ passwordText.Text+ ";MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path+ "\\connect",  sb.ToString());

                    DialogResult dr = MessageBox.Show("Settings Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Taken dialogresult here so that when pressing OK Button we go back to login page
                    if (dr == DialogResult.OK)
                    {
                        //Using showWindow method from MainClass which accepts three form objects
                        Login login = new Login();


                        MainClass.showWindow(login, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void datasourceText_TextChanged(object sender, EventArgs e)
        {
            if (datasourceText.Text == "") { datasourceerrorlabel.Visible = true;} else { datasourceerrorlabel.Visible = false;}
        
        }

        private void databaseText_TextChanged(object sender, EventArgs e)
        {
            if (databaseText.Text == "") { dberrorlabel.Visible = true; } else { dberrorlabel.Visible = false; }
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (usernameText.Text == "") { usernameerrorlabel.Visible = true; } else { usernameerrorlabel.Visible = false; }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (passwordText.Text == "") { passworderrorlabel.Visible = true; } else { passworderrorlabel.Visible = false; }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                usernameText.Text = "";
                usernameText.Enabled = false;
                passwordText.Text = "";
                passwordText.Enabled = false;
                usernameerrorlabel.Visible=false;
                passworderrorlabel.Visible = false;
            }
            else
            {
                
                usernameText.Enabled = true;
               
                passwordText.Enabled = true;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
