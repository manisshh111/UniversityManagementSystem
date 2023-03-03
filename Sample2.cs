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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        //For overriding, all methods here are made public & virtual keyword is necessary to override
        public virtual void addBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        public  void backBtn_Click(object sender, EventArgs e)

        {
            HomeScreen obj= new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
            obj.Show();
        }

        
    }
}
