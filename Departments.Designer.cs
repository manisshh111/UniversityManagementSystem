namespace UniversityMSApp
{
    partial class Departments
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
            this.departmentText = new System.Windows.Forms.TextBox();
            this.departmentErrorLabel = new System.Windows.Forms.Label();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.left.Size = new System.Drawing.Size(228, 640);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.departmentText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.departmentErrorLabel);
            this.panel5.Size = new System.Drawing.Size(228, 600);
            this.panel5.Controls.SetChildIndex(this.departmentErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.departmentText, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1222, 640);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.detailsGB);
            this.panel6.Size = new System.Drawing.Size(1222, 600);
            this.panel6.Controls.SetChildIndex(this.detailsGB, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1222, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name";
            // 
            // departmentText
            // 
            this.departmentText.Location = new System.Drawing.Point(12, 95);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(210, 23);
            this.departmentText.TabIndex = 2;
            this.departmentText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // departmentErrorLabel
            // 
            this.departmentErrorLabel.AutoSize = true;
            this.departmentErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentErrorLabel.Location = new System.Drawing.Point(204, 79);
            this.departmentErrorLabel.Name = "departmentErrorLabel";
            this.departmentErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.departmentErrorLabel.TabIndex = 7;
            this.departmentErrorLabel.Text = "*";
            // 
            // detailsGB
            // 
            this.detailsGB.Controls.Add(this.dataGridView1);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Location = new System.Drawing.Point(0, 50);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(1222, 550);
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
            this.snoGV,
            this.departmentIDGV,
            this.departmentsGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 528);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "SNO";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 56;
            // 
            // departmentIDGV
            // 
            this.departmentIDGV.HeaderText = "Department ID";
            this.departmentIDGV.Name = "departmentIDGV";
            this.departmentIDGV.ReadOnly = true;
            // 
            // departmentsGV
            // 
            this.departmentsGV.HeaderText = "Departments";
            this.departmentsGV.Name = "departmentsGV";
            this.departmentsGV.ReadOnly = true;
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 640);
            this.Name = "Departments";
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.Departments_Load);
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

        private Label label2;
        private TextBox departmentText;
        private Label departmentErrorLabel;
        private GroupBox detailsGB;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn departmentIDGV;
        private DataGridViewTextBoxColumn departmentsGV;
    }
}