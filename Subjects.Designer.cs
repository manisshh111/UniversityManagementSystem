namespace UniversityMSApp
{
    partial class Subjects
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
            this.subjectText = new System.Windows.Forms.TextBox();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.batchDD = new System.Windows.Forms.ComboBox();
            this.batchErrorLabel = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.panel6.SuspendLayout();
            this.detailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 630);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.batchDD);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.subjectText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.subjectErrorLabel);
            this.panel5.Controls.Add(this.batchErrorLabel);
            this.panel5.Size = new System.Drawing.Size(228, 590);
            this.panel5.Controls.SetChildIndex(this.batchErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.subjectErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.subjectText, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.batchDD, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(880, 630);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.detailsGB);
            this.panel6.Size = new System.Drawing.Size(880, 590);
            this.panel6.Controls.SetChildIndex(this.detailsGB, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(880, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(9, 101);
            this.subjectText.MaxLength = 100;
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(210, 23);
            this.subjectText.TabIndex = 2;
            // 
            // detailsGB
            // 
            this.detailsGB.Controls.Add(this.dataGridView1);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Location = new System.Drawing.Point(0, 50);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(880, 540);
            this.detailsGB.TabIndex = 2;
            this.detailsGB.TabStop = false;
            this.detailsGB.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIDGV,
            this.subjectsGV,
            this.batchGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(874, 518);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // subjectIDGV
            // 
            this.subjectIDGV.HeaderText = "Subject ID";
            this.subjectIDGV.Name = "subjectIDGV";
            this.subjectIDGV.ReadOnly = true;
            // 
            // subjectsGV
            // 
            this.subjectsGV.HeaderText = "Subjects";
            this.subjectsGV.Name = "subjectsGV";
            this.subjectsGV.ReadOnly = true;
            // 
            // batchGV
            // 
            this.batchGV.HeaderText = "Batch";
            this.batchGV.Name = "batchGV";
            this.batchGV.ReadOnly = true;
            // 
            // subjectErrorLabel
            // 
            this.subjectErrorLabel.AutoSize = true;
            this.subjectErrorLabel.Location = new System.Drawing.Point(200, 90);
            this.subjectErrorLabel.Name = "subjectErrorLabel";
            this.subjectErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.subjectErrorLabel.TabIndex = 3;
            this.subjectErrorLabel.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Batch";
            // 
            // batchDD
            // 
            this.batchDD.FormattingEnabled = true;
            this.batchDD.Location = new System.Drawing.Point(11, 155);
            this.batchDD.Name = "batchDD";
            this.batchDD.Size = new System.Drawing.Size(208, 23);
            this.batchDD.TabIndex = 5;
            this.batchDD.SelectedIndexChanged += new System.EventHandler(this.batchDD_SelectedIndexChanged);
            // 
            // batchErrorLabel
            // 
            this.batchErrorLabel.AutoSize = true;
            this.batchErrorLabel.Location = new System.Drawing.Point(200, 142);
            this.batchErrorLabel.Name = "batchErrorLabel";
            this.batchErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.batchErrorLabel.TabIndex = 6;
            this.batchErrorLabel.Text = "*";
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.detailsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox subjectText;
        private Label label2;
        private GroupBox detailsGB;
        private DataGridView dataGridView1;
        private Label subjectErrorLabel;
        private ComboBox batchDD;
        private Label label3;
        private DataGridViewTextBoxColumn subjectIDGV;
        private DataGridViewTextBoxColumn subjectsGV;
        private DataGridViewTextBoxColumn batchGV;
        private Label batchErrorLabel;
    }
}