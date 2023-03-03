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
    public partial class Sections : Sample2
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void sectionText_TextChanged(object sender, EventArgs e)
        {
            if (sectionText.Text == "") { sectionNameErrorLabel.Visible = true; } else { sectionNameErrorLabel.Visible = false; }
        }

        private void statusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(statusCB.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

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
    }
}
