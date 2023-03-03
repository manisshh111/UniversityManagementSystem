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
    public partial class gvExample : Form
    {
        public gvExample()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            roleDB obj = new roleDB();
           // obj.getAllRoles(dataGridView1);
        }
    }
}
