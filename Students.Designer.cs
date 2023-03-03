namespace UniversityMSApp
{
    partial class Students
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
            this.enrollText = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.detailsGV = new System.Windows.Forms.DataGridView();
            this.studentNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceGV = new System.Windows.Forms.DataGridView();
            this.sessionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsGV = new System.Windows.Forms.DataGridView();
            this.subjectGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.left.SuspendLayout();
            this.panel3.SuspendLayout();
            this.right.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 640);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(228, 600);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.SetChildIndex(this.button1, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1216, 640);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Size = new System.Drawing.Size(1216, 600);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1216, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Enrollment Number";
            // 
            // enrollText
            // 
            this.enrollText.Location = new System.Drawing.Point(241, 41);
            this.enrollText.Name = "enrollText";
            this.enrollText.Size = new System.Drawing.Size(165, 23);
            this.enrollText.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(430, 41);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(95, 23);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // detailsGV
            // 
            this.detailsGV.BackgroundColor = System.Drawing.Color.White;
            this.detailsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameGV,
            this.batchGV,
            this.genderGV,
            this.dobGV,
            this.addressGV,
            this.fatherGV,
            this.motherGV,
            this.phoneGV,
            this.emailGV});
            this.detailsGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsGV.Location = new System.Drawing.Point(0, 0);
            this.detailsGV.Name = "detailsGV";
            this.detailsGV.RowTemplate.Height = 25;
            this.detailsGV.Size = new System.Drawing.Size(1216, 70);
            this.detailsGV.TabIndex = 4;
            // 
            // studentNameGV
            // 
            this.studentNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentNameGV.HeaderText = "Name";
            this.studentNameGV.Name = "studentNameGV";
            this.studentNameGV.ReadOnly = true;
            // 
            // batchGV
            // 
            this.batchGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.batchGV.HeaderText = "Batch";
            this.batchGV.Name = "batchGV";
            this.batchGV.ReadOnly = true;
            // 
            // genderGV
            // 
            this.genderGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genderGV.HeaderText = "Gender";
            this.genderGV.Name = "genderGV";
            this.genderGV.ReadOnly = true;
            // 
            // dobGV
            // 
            this.dobGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dobGV.HeaderText = "DOB";
            this.dobGV.Name = "dobGV";
            this.dobGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // fatherGV
            // 
            this.fatherGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fatherGV.HeaderText = "Father\'s Name";
            this.fatherGV.Name = "fatherGV";
            this.fatherGV.ReadOnly = true;
            // 
            // motherGV
            // 
            this.motherGV.HeaderText = "Mother\'s Name";
            this.motherGV.Name = "motherGV";
            this.motherGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneGV.HeaderText = "Phone ";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // emailGV
            // 
            this.emailGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailGV.HeaderText = "Email";
            this.emailGV.Name = "emailGV";
            this.emailGV.ReadOnly = true;
            // 
            // attendanceGV
            // 
            this.attendanceGV.BackgroundColor = System.Drawing.Color.White;
            this.attendanceGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendanceGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionGV,
            this.presentGV,
            this.totalGV});
            this.attendanceGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceGV.Location = new System.Drawing.Point(0, 0);
            this.attendanceGV.Name = "attendanceGV";
            this.attendanceGV.RowTemplate.Height = 25;
            this.attendanceGV.Size = new System.Drawing.Size(1216, 87);
            this.attendanceGV.TabIndex = 5;
            // 
            // sessionGV
            // 
            this.sessionGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sessionGV.HeaderText = "Session";
            this.sessionGV.Name = "sessionGV";
            this.sessionGV.ReadOnly = true;
            // 
            // presentGV
            // 
            this.presentGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.presentGV.HeaderText = "Present Days";
            this.presentGV.Name = "presentGV";
            this.presentGV.ReadOnly = true;
            // 
            // totalGV
            // 
            this.totalGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalGV.HeaderText = "Total Days";
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // resultsGV
            // 
            this.resultsGV.BackgroundColor = System.Drawing.Color.White;
            this.resultsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectGV,
            this.marksGV,
            this.totalMarksGV});
            this.resultsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGV.Location = new System.Drawing.Point(0, 0);
            this.resultsGV.Name = "resultsGV";
            this.resultsGV.RowTemplate.Height = 25;
            this.resultsGV.Size = new System.Drawing.Size(1216, 276);
            this.resultsGV.TabIndex = 6;
            // 
            // subjectGV
            // 
            this.subjectGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectGV.HeaderText = "Subjects";
            this.subjectGV.Name = "subjectGV";
            this.subjectGV.ReadOnly = true;
            // 
            // marksGV
            // 
            this.marksGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marksGV.HeaderText = "MarksObtained";
            this.marksGV.Name = "marksGV";
            this.marksGV.ReadOnly = true;
            // 
            // totalMarksGV
            // 
            this.totalMarksGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalMarksGV.HeaderText = "Total Marks";
            this.totalMarksGV.Name = "totalMarksGV";
            this.totalMarksGV.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Details :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Attendance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Results :";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(548, 41);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(89, 23);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.enrollText);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 100);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.detailsGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 103);
            this.panel2.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1216, 28);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.attendanceGV);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 203);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1216, 87);
            this.panel8.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 290);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1216, 34);
            this.panel9.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.resultsGV);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 324);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1216, 276);
            this.panel10.TabIndex = 15;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 640);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.left.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.right.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView resultsGV;
        private DataGridView attendanceGV;
        private DataGridView detailsGV;
        private Button enterButton;
        private TextBox enrollText;
        private Label label2;
        private Button button1;
        private Button resetBtn;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn studentNameGV;
        private DataGridViewTextBoxColumn batchGV;
        private DataGridViewTextBoxColumn genderGV;
        private DataGridViewTextBoxColumn dobGV;
        private DataGridViewTextBoxColumn addressGV;
        private DataGridViewTextBoxColumn fatherGV;
        private DataGridViewTextBoxColumn motherGV;
        private DataGridViewTextBoxColumn phoneGV;
        private DataGridViewTextBoxColumn emailGV;
        private Panel panel10;
        private DataGridViewTextBoxColumn subjectGV;
        private DataGridViewTextBoxColumn marksGV;
        private DataGridViewTextBoxColumn totalMarksGV;
        private Panel panel9;
        private Panel panel8;
        private DataGridViewTextBoxColumn sessionGV;
        private DataGridViewTextBoxColumn presentGV;
        private DataGridViewTextBoxColumn totalGV;
        private Panel panel7;
    }
}