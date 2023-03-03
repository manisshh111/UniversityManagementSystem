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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            MainClass.showWindow(staff, this, MDI.ActiveForm);
        }

        private void departmentBtn_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            MainClass.showWindow(departments, this, MDI.ActiveForm);
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            Students students = new Students(); 
            MainClass.showWindow(students, this, MDI.ActiveForm);    
        }

        private void feeBtn_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();    
            MainClass.showWindow(fee, this, MDI.ActiveForm);
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
           Roles roles = new Roles();
           MainClass.showWindow(roles, this, MDI.ActiveForm); 

            
        }

        private void SectionsBtn_Click(object sender, EventArgs e)
        {
            Sections sections = new Sections();
            MainClass.showWindow(sections, this, MDI.ActiveForm);   
        }

        private void subjectsBtn_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            MainClass.showWindow(subjects, this, MDI.ActiveForm);
        }

        private void ClassTimingsbtn_Click(object sender, EventArgs e)
        {
            ClassTimings classTimings = new ClassTimings();
            MainClass.showWindow(classTimings, this, MDI.ActiveForm);   
        }

        private void ShiftsBtn_Click(object sender, EventArgs e)
        {
            Shifts shifts = new Shifts();   
            MainClass.showWindow(shifts, this, MDI.ActiveForm);
        }

        private void rolesBtn_Click_1(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            MainClass.showWindow(roles, this, MDI.ActiveForm);

        }

        private void admissionBtn_Click(object sender, EventArgs e)
        {
            Admission a= new Admission();
            MainClass.showWindow(a, this, MDI.ActiveForm);
        }

        private void batchButton_Click(object sender, EventArgs e)
        {
            Batches batch = new Batches();  
            MainClass.showWindow(batch, this, MDI.ActiveForm);
        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            MainClass.showWindow(attendance, this, MDI.ActiveForm);
        }

        private void resultsBtn_Click(object sender, EventArgs e)
        {
            Results res= new Results();
            MainClass.showWindow(res, this, MDI.ActiveForm);
        }
    }
}
