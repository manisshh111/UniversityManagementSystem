using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Logging;

namespace UniversityMSApp
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

       


        private void MDI_Load(object sender, EventArgs e)
        {
            // if connection string is already made, show login window, else settings window
            //string path= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(MainClass.path + "\\connect"))
            {
                Login login = new Login();   
                login.MdiParent = this;
               login.WindowState = FormWindowState.Maximized;
               login.Show();
            }
            else
            {
                Settings settings = new Settings();
                settings.MdiParent = this;
                settings.WindowState = FormWindowState.Maximized;
                settings.Show();
            }
        }
    }
}
