using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityMSApp
{
    internal class MainClass
    {

       public static string path= Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);  

        //Method-1:  For closing and opening window

        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }

        //Method-2:  for showing messageBox
        public static DialogResult ShowMSG(string msg, string heading, string type)
        {
            if(type== "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Method-3: which takes a container and disables it as well as resets all the controls

        public static void disable_reset(Panel p)
        {

            foreach(Control c in p.Controls)
            {
                if(c is TextBox)
                {
                    TextBox t= (TextBox)c; //TypeCasting c to Textbox
                    t.Enabled=false;
                    t.Text = "";
                }

                if(c is ComboBox)
                {
                    ComboBox cb= (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }

                if(c is RadioButton)
                {
                    RadioButton b= (RadioButton)c;    
                    b.Enabled=false;
                    b.Checked = false;
                }

                if (c is CheckBox)
                {
                    CheckBox cbx = (CheckBox)c;
                    cbx.Enabled = false;
                    cbx.Checked = false;
                }

                if(c is DateTimePicker)
                {
                    DateTimePicker d= (DateTimePicker)c;    
                    d.Enabled=false;
                    d.Value= DateTime.Now;

                }

                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;

                }
            }
        }

        //Method-4: Only disable
        public static void disable(Panel p)
        {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c; //TypeCasting c to Textbox
                    t.Enabled = false;
                    
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                   
                }

                if (c is RadioButton)
                {
                    RadioButton b = (RadioButton)c;
                    b.Enabled = false;
                    
                }

                if (c is CheckBox)
                {
                    CheckBox cbx = (CheckBox)c;
                    cbx.Enabled = false;
                    
                }

                if (c is DateTimePicker)
                {
                    DateTimePicker d = (DateTimePicker)c;
                    d.Enabled = false;
                   

                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;

                }
            }
        }

        //Method-5: Enable_Reset

        public static void enable_reset(Panel p)
        {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c; //TypeCasting c to Textbox
                    t.Enabled = true;
                    t.Text = "";
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }

                if (c is RadioButton)
                {
                    RadioButton b = (RadioButton)c;
                    b.Enabled = true;
                    b.Checked = false;
                }

                if (c is CheckBox)
                {
                    CheckBox cbx = (CheckBox)c;
                    cbx.Enabled = true;
                    cbx.Checked = false;
                }

                if (c is DateTimePicker)
                {
                    DateTimePicker d = (DateTimePicker)c;
                    d.Enabled = true;
                    d.Value = DateTime.Now;

                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;

                }
            }
        }

        //Method-6: Overloaded version of enable_reset, Passing GroupBox as parameter instead of Panel p

        public static void enable_reset(GroupBox gb)
        {

            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c; //TypeCasting c to Textbox
                    t.Enabled = true;
                    t.Text = "";
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }

                if (c is RadioButton)
                {
                    RadioButton b = (RadioButton)c;
                    b.Enabled = true;
                    b.Checked = false;
                }

                if (c is CheckBox)
                {
                    CheckBox cbx = (CheckBox)c;
                    cbx.Enabled = true;
                    cbx.Checked = false;
                }

                if (c is DateTimePicker)
                {
                    DateTimePicker d = (DateTimePicker)c;
                    d.Enabled = true;
                    d.Value = DateTime.Now;

                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;

                }
            }
        }

        //Method-7: Enable Only

        public static void enable(Panel p)
        {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c; //TypeCasting c to Textbox
                    t.Enabled = true;
                    
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    
                }

                if (c is RadioButton)
                {
                    RadioButton b = (RadioButton)c;
                    b.Enabled = true;
                    
                }

                if (c is CheckBox)
                {
                    CheckBox cbx = (CheckBox)c;
                    cbx.Enabled = true;
                    
                }

                if (c is DateTimePicker)
                {
                    DateTimePicker d = (DateTimePicker)c;
                    d.Enabled = true;
                    

                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;

                }
            }
        }

       
        
        
    }
}
