namespace UniversityMSApp
{
    partial class Results
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.enrollmentText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.batchDD = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectDD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.marksText = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enrollErrorLabel = new System.Windows.Forms.Label();
            this.batchErrorLabel = new System.Windows.Forms.Label();
            this.subjectErrorLabel = new System.Windows.Forms.Label();
            this.marksErrorLabel = new System.Windows.Forms.Label();
            this.totalErrorLabel = new System.Windows.Forms.Label();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.resultGV = new System.Windows.Forms.DataGridView();
            this.ResultIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.detailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGV)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 629);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.totalText);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.marksText);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.subjectDD);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.batchDD);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.enrollmentText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.enrollErrorLabel);
            this.panel5.Controls.Add(this.batchErrorLabel);
            this.panel5.Controls.Add(this.subjectErrorLabel);
            this.panel5.Controls.Add(this.marksErrorLabel);
            this.panel5.Controls.Add(this.totalErrorLabel);
            this.panel5.Size = new System.Drawing.Size(228, 589);
            this.panel5.Controls.SetChildIndex(this.totalErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.marksErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.subjectErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.batchErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.enrollErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.enrollmentText, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.batchDD, 0);
            this.panel5.Controls.SetChildIndex(this.label4, 0);
            this.panel5.Controls.SetChildIndex(this.subjectDD, 0);
            this.panel5.Controls.SetChildIndex(this.label5, 0);
            this.panel5.Controls.SetChildIndex(this.marksText, 0);
            this.panel5.Controls.SetChildIndex(this.label6, 0);
            this.panel5.Controls.SetChildIndex(this.totalText, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1031, 629);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.detailsGB);
            this.panel6.Size = new System.Drawing.Size(1031, 589);
            this.panel6.Controls.SetChildIndex(this.detailsGB, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1031, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Enrollment No.";
            // 
            // enrollmentText
            // 
            this.enrollmentText.Location = new System.Drawing.Point(15, 83);
            this.enrollmentText.Name = "enrollmentText";
            this.enrollmentText.Size = new System.Drawing.Size(192, 23);
            this.enrollmentText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Batch";
            // 
            // batchDD
            // 
            this.batchDD.FormattingEnabled = true;
            this.batchDD.Location = new System.Drawing.Point(14, 139);
            this.batchDD.Name = "batchDD";
            this.batchDD.Size = new System.Drawing.Size(193, 23);
            this.batchDD.TabIndex = 4;
            this.batchDD.SelectedIndexChanged += new System.EventHandler(this.batchDD_SelectedIndexChanged);
            // 
            // subjectDD
            // 
            this.subjectDD.FormattingEnabled = true;
            this.subjectDD.Location = new System.Drawing.Point(14, 198);
            this.subjectDD.Name = "subjectDD";
            this.subjectDD.Size = new System.Drawing.Size(193, 23);
            this.subjectDD.TabIndex = 6;
            this.subjectDD.SelectedIndexChanged += new System.EventHandler(this.subjectDD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Marks Obtained";
            // 
            // marksText
            // 
            this.marksText.Location = new System.Drawing.Point(12, 260);
            this.marksText.Name = "marksText";
            this.marksText.Size = new System.Drawing.Size(192, 23);
            this.marksText.TabIndex = 8;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(12, 318);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(192, 23);
            this.totalText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Marks Total";
            // 
            // enrollErrorLabel
            // 
            this.enrollErrorLabel.AutoSize = true;
            this.enrollErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enrollErrorLabel.Location = new System.Drawing.Point(187, 68);
            this.enrollErrorLabel.Name = "enrollErrorLabel";
            this.enrollErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.enrollErrorLabel.TabIndex = 11;
            this.enrollErrorLabel.Text = "*";
            // 
            // batchErrorLabel
            // 
            this.batchErrorLabel.AutoSize = true;
            this.batchErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.batchErrorLabel.Location = new System.Drawing.Point(187, 124);
            this.batchErrorLabel.Name = "batchErrorLabel";
            this.batchErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.batchErrorLabel.TabIndex = 12;
            this.batchErrorLabel.Text = "*";
            // 
            // subjectErrorLabel
            // 
            this.subjectErrorLabel.AutoSize = true;
            this.subjectErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectErrorLabel.Location = new System.Drawing.Point(187, 183);
            this.subjectErrorLabel.Name = "subjectErrorLabel";
            this.subjectErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.subjectErrorLabel.TabIndex = 13;
            this.subjectErrorLabel.Text = "*";
            // 
            // marksErrorLabel
            // 
            this.marksErrorLabel.AutoSize = true;
            this.marksErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marksErrorLabel.Location = new System.Drawing.Point(187, 244);
            this.marksErrorLabel.Name = "marksErrorLabel";
            this.marksErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.marksErrorLabel.TabIndex = 14;
            this.marksErrorLabel.Text = "*";
            // 
            // totalErrorLabel
            // 
            this.totalErrorLabel.AutoSize = true;
            this.totalErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalErrorLabel.Location = new System.Drawing.Point(187, 301);
            this.totalErrorLabel.Name = "totalErrorLabel";
            this.totalErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.totalErrorLabel.TabIndex = 15;
            this.totalErrorLabel.Text = "*";
            // 
            // detailsGB
            // 
            this.detailsGB.Controls.Add(this.resultGV);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Location = new System.Drawing.Point(0, 50);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(1031, 539);
            this.detailsGB.TabIndex = 4;
            this.detailsGB.TabStop = false;
            this.detailsGB.Text = "Details";
            // 
            // resultGV
            // 
            this.resultGV.AllowUserToAddRows = false;
            this.resultGV.AllowUserToDeleteRows = false;
            this.resultGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultGV.BackgroundColor = System.Drawing.Color.White;
            this.resultGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultIDGV,
            this.studentIDGV,
            this.nameGV,
            this.batchGV,
            this.subjectGV,
            this.marksGV,
            this.totalMarksGV});
            this.resultGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGV.Location = new System.Drawing.Point(3, 19);
            this.resultGV.Name = "resultGV";
            this.resultGV.ReadOnly = true;
            this.resultGV.RowHeadersVisible = false;
            this.resultGV.RowTemplate.Height = 25;
            this.resultGV.Size = new System.Drawing.Size(1025, 517);
            this.resultGV.TabIndex = 0;
            this.resultGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceGV_CellClick);
            // 
            // ResultIDGV
            // 
            this.ResultIDGV.HeaderText = "Result ID";
            this.ResultIDGV.Name = "ResultIDGV";
            this.ResultIDGV.ReadOnly = true;
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
            // batchGV
            // 
            this.batchGV.HeaderText = "Batch";
            this.batchGV.Name = "batchGV";
            this.batchGV.ReadOnly = true;
            // 
            // subjectGV
            // 
            this.subjectGV.HeaderText = "Subject";
            this.subjectGV.Name = "subjectGV";
            this.subjectGV.ReadOnly = true;
            // 
            // marksGV
            // 
            this.marksGV.HeaderText = "Marks Obtained";
            this.marksGV.Name = "marksGV";
            this.marksGV.ReadOnly = true;
            // 
            // totalMarksGV
            // 
            this.totalMarksGV.HeaderText = "Total Marks";
            this.totalMarksGV.Name = "totalMarksGV";
            this.totalMarksGV.ReadOnly = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 629);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.detailsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox totalText;
        private Label label6;
        private TextBox marksText;
        private Label label5;
        private ComboBox subjectDD;
        private Label label4;
        private ComboBox batchDD;
        private Label label3;
        private TextBox enrollmentText;
        private Label label2;
        private Label enrollErrorLabel;
        private Label batchErrorLabel;
        private Label subjectErrorLabel;
        private Label marksErrorLabel;
        private Label totalErrorLabel;
        private BindingSource bindingSource1;
        private GroupBox detailsGB;
        private DataGridView resultGV;
        private DataGridViewTextBoxColumn ResultIDGV;
        private DataGridViewTextBoxColumn studentIDGV;
        private DataGridViewTextBoxColumn nameGV;
        private DataGridViewTextBoxColumn batchGV;
        private DataGridViewTextBoxColumn subjectGV;
        private DataGridViewTextBoxColumn marksGV;
        private DataGridViewTextBoxColumn totalMarksGV;
    }
}