namespace UniversityMSApp
{
    partial class ClassTimings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.timingNameText = new System.Windows.Forms.TextBox();
            this.timingShiftText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timingSHiftCB = new System.Windows.Forms.ComboBox();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTiming = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 635);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.ToTimePicker);
            this.panel5.Controls.Add(this.toTiming);
            this.panel5.Controls.Add(this.FromTimePicker);
            this.panel5.Controls.Add(this.timingSHiftCB);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.timingShiftText);
            this.panel5.Controls.Add(this.timingNameText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Size = new System.Drawing.Size(228, 595);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.timingNameText, 0);
            this.panel5.Controls.SetChildIndex(this.timingShiftText, 0);
            this.panel5.Controls.SetChildIndex(this.label4, 0);
            this.panel5.Controls.SetChildIndex(this.timingSHiftCB, 0);
            this.panel5.Controls.SetChildIndex(this.FromTimePicker, 0);
            this.panel5.Controls.SetChildIndex(this.toTiming, 0);
            this.panel5.Controls.SetChildIndex(this.ToTimePicker, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(877, 635);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(877, 595);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(877, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timing Name";
            // 
            // timingNameText
            // 
            this.timingNameText.Location = new System.Drawing.Point(12, 89);
            this.timingNameText.Name = "timingNameText";
            this.timingNameText.Size = new System.Drawing.Size(210, 23);
            this.timingNameText.TabIndex = 2;
            // 
            // timingShiftText
            // 
            this.timingShiftText.AutoSize = true;
            this.timingShiftText.Location = new System.Drawing.Point(12, 126);
            this.timingShiftText.Name = "timingShiftText";
            this.timingShiftText.Size = new System.Drawing.Size(71, 15);
            this.timingShiftText.TabIndex = 3;
            this.timingShiftText.Text = "Timing Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "From Timing";
            // 
            // timingSHiftCB
            // 
            this.timingSHiftCB.FormattingEnabled = true;
            this.timingSHiftCB.Location = new System.Drawing.Point(12, 148);
            this.timingSHiftCB.Name = "timingSHiftCB";
            this.timingSHiftCB.Size = new System.Drawing.Size(210, 23);
            this.timingSHiftCB.TabIndex = 7;
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.CustomFormat = "hh:mm";
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromTimePicker.Location = new System.Drawing.Point(14, 197);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShowUpDown = true;
            this.FromTimePicker.Size = new System.Drawing.Size(200, 23);
            this.FromTimePicker.TabIndex = 8;
            this.FromTimePicker.Value = new System.DateTime(2022, 11, 2, 8, 22, 40, 0);
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.CustomFormat = "hh:mm";
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTimePicker.Location = new System.Drawing.Point(14, 254);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShowUpDown = true;
            this.ToTimePicker.Size = new System.Drawing.Size(200, 23);
            this.ToTimePicker.TabIndex = 10;
            this.ToTimePicker.Value = new System.DateTime(2022, 11, 2, 8, 22, 40, 0);
            // 
            // toTiming
            // 
            this.toTiming.AutoSize = true;
            this.toTiming.Location = new System.Drawing.Point(12, 234);
            this.toTiming.Name = "toTiming";
            this.toTiming.Size = new System.Drawing.Size(59, 15);
            this.toTiming.TabIndex = 9;
            this.toTiming.Text = "To Timing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Timing Day";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox1.Location = new System.Drawing.Point(12, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // ClassTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 635);
            this.Name = "ClassTimings";
            this.Text = "Class Timings";
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker FromTimePicker;
        private ComboBox timingSHiftCB;
        private Label label4;
        private Label timingShiftText;
        private TextBox timingNameText;
        private Label label2;
        private DateTimePicker ToTimePicker;
        private Label toTiming;
        private ComboBox comboBox1;
        private Label label3;
    }
}