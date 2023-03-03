namespace UniversityMSApp
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.sessionDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.presentText = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.studentEnrollText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.attendanceGV = new System.Windows.Forms.DataGridView();
            this.attendanceIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollErrorLAbel = new System.Windows.Forms.Label();
            this.sessionErrorLabel = new System.Windows.Forms.Label();
            this.presentErrorLabel = new System.Windows.Forms.Label();
            this.totalErrorLabel = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.panel6.SuspendLayout();
            this.detailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGV)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 631);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.studentEnrollText);
            this.panel5.Controls.Add(this.totalText);
            this.panel5.Controls.Add(this.presentText);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.sessionDD);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.enrollErrorLAbel);
            this.panel5.Controls.Add(this.sessionErrorLabel);
            this.panel5.Controls.Add(this.presentErrorLabel);
            this.panel5.Controls.Add(this.totalErrorLabel);
            this.panel5.Size = new System.Drawing.Size(228, 591);
            this.panel5.Controls.SetChildIndex(this.totalErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.presentErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.sessionErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.enrollErrorLAbel, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.sessionDD, 0);
            this.panel5.Controls.SetChildIndex(this.label4, 0);
            this.panel5.Controls.SetChildIndex(this.presentText, 0);
            this.panel5.Controls.SetChildIndex(this.totalText, 0);
            this.panel5.Controls.SetChildIndex(this.studentEnrollText, 0);
            this.panel5.Controls.SetChildIndex(this.label5, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1107, 631);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.detailsGB);
            this.panel6.Size = new System.Drawing.Size(1107, 591);
            this.panel6.Controls.SetChildIndex(this.detailsGB, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1107, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Enrollment No.";
            // 
            // sessionDD
            // 
            this.sessionDD.FormattingEnabled = true;
            this.sessionDD.Items.AddRange(new object[] {
            "July-December 2019",
            "Janurary- June 2020",
            "July-December 2020",
            "Janurary- June 2021",
            "July-December 2021",
            "Janurary- June 2022",
            "July-December 2022",
            "Janurary- June 2023",
            "July-December 2023",
            "Janurary- June 2024",
            "July-December 2024",
            "Janurary- June 2024",
            "",
            "",
            ""});
            this.sessionDD.Location = new System.Drawing.Point(12, 135);
            this.sessionDD.Name = "sessionDD";
            this.sessionDD.Size = new System.Drawing.Size(191, 23);
            this.sessionDD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Session";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Present Days";
            // 
            // presentText
            // 
            this.presentText.Location = new System.Drawing.Point(14, 189);
            this.presentText.Name = "presentText";
            this.presentText.Size = new System.Drawing.Size(188, 23);
            this.presentText.TabIndex = 6;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(12, 242);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(190, 23);
            this.totalText.TabIndex = 7;
            // 
            // studentEnrollText
            // 
            this.studentEnrollText.Location = new System.Drawing.Point(13, 89);
            this.studentEnrollText.Name = "studentEnrollText";
            this.studentEnrollText.Size = new System.Drawing.Size(190, 23);
            this.studentEnrollText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Days";
            // 
            // detailsGB
            // 
            this.detailsGB.Controls.Add(this.attendanceGV);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Location = new System.Drawing.Point(0, 50);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(1107, 541);
            this.detailsGB.TabIndex = 3;
            this.detailsGB.TabStop = false;
            this.detailsGB.Text = "Details";
            // 
            // attendanceGV
            // 
            this.attendanceGV.AllowUserToAddRows = false;
            this.attendanceGV.AllowUserToDeleteRows = false;
            this.attendanceGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendanceGV.BackgroundColor = System.Drawing.Color.White;
            this.attendanceGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.attendanceGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIDGV,
            this.studentIDGV,
            this.nameGV,
            this.sessionGV,
            this.presentGV,
            this.totalGV});
            this.attendanceGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceGV.Location = new System.Drawing.Point(3, 19);
            this.attendanceGV.Name = "attendanceGV";
            this.attendanceGV.ReadOnly = true;
            this.attendanceGV.RowHeadersVisible = false;
            this.attendanceGV.RowTemplate.Height = 25;
            this.attendanceGV.Size = new System.Drawing.Size(1101, 519);
            this.attendanceGV.TabIndex = 0;
            this.attendanceGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffsGV_CellClick);
            // 
            // attendanceIDGV
            // 
            this.attendanceIDGV.HeaderText = "Attendance ID";
            this.attendanceIDGV.Name = "attendanceIDGV";
            this.attendanceIDGV.ReadOnly = true;
            // 
            // studentIDGV
            // 
            this.studentIDGV.HeaderText = "Student ID";
            this.studentIDGV.Name = "studentIDGV";
            this.studentIDGV.ReadOnly = true;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Student Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // sessionGV
            // 
            this.sessionGV.HeaderText = "Session";
            this.sessionGV.Name = "sessionGV";
            this.sessionGV.ReadOnly = true;
            // 
            // presentGV
            // 
            this.presentGV.HeaderText = "Present";
            this.presentGV.Name = "presentGV";
            this.presentGV.ReadOnly = true;
            // 
            // totalGV
            // 
            this.totalGV.HeaderText = "Total";
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // enrollErrorLAbel
            // 
            this.enrollErrorLAbel.AutoSize = true;
            this.enrollErrorLAbel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enrollErrorLAbel.Location = new System.Drawing.Point(184, 74);
            this.enrollErrorLAbel.Name = "enrollErrorLAbel";
            this.enrollErrorLAbel.Size = new System.Drawing.Size(17, 21);
            this.enrollErrorLAbel.TabIndex = 10;
            this.enrollErrorLAbel.Text = "*";
            this.enrollErrorLAbel.Visible = false;
            // 
            // sessionErrorLabel
            // 
            this.sessionErrorLabel.AutoSize = true;
            this.sessionErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessionErrorLabel.Location = new System.Drawing.Point(186, 121);
            this.sessionErrorLabel.Name = "sessionErrorLabel";
            this.sessionErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.sessionErrorLabel.TabIndex = 11;
            this.sessionErrorLabel.Text = "*";
            this.sessionErrorLabel.Visible = false;
            // 
            // presentErrorLabel
            // 
            this.presentErrorLabel.AutoSize = true;
            this.presentErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.presentErrorLabel.Location = new System.Drawing.Point(185, 174);
            this.presentErrorLabel.Name = "presentErrorLabel";
            this.presentErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.presentErrorLabel.TabIndex = 12;
            this.presentErrorLabel.Text = "*";
            this.presentErrorLabel.Visible = false;
            // 
            // totalErrorLabel
            // 
            this.totalErrorLabel.AutoSize = true;
            this.totalErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalErrorLabel.Location = new System.Drawing.Point(184, 228);
            this.totalErrorLabel.Name = "totalErrorLabel";
            this.totalErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.totalErrorLabel.TabIndex = 13;
            this.totalErrorLabel.Text = "*";
            this.totalErrorLabel.Visible = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 631);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.detailsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label5;
        private TextBox studentEnrollText;
        private TextBox totalText;
        private TextBox presentText;
        private Label label4;
        private ComboBox sessionDD;
        private Label label3;
        private Label label2;
        private GroupBox detailsGB;
        private DataGridView attendanceGV;
        private DataGridViewTextBoxColumn attendanceIDGV;
        private DataGridViewTextBoxColumn studentIDGV;
        private DataGridViewTextBoxColumn nameGV;
        private DataGridViewTextBoxColumn sessionGV;
        private DataGridViewTextBoxColumn presentGV;
        private DataGridViewTextBoxColumn totalGV;
        private Label enrollErrorLAbel;
        private Label sessionErrorLabel;
        private Label presentErrorLabel;
        private Label totalErrorLabel;
    }
}