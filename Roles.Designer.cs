namespace UniversityMSApp
{
    partial class Roles
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
            this.label3 = new System.Windows.Forms.Label();
            this.roleText = new System.Windows.Forms.TextBox();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolesGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
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
            this.left.Size = new System.Drawing.Size(228, 639);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.statusDD);
            this.panel5.Controls.Add(this.roleText);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.roleErrorLabel);
            this.panel5.Controls.Add(this.statusErrorLabel);
            this.panel5.Size = new System.Drawing.Size(228, 599);
            this.panel5.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.roleErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.roleText, 0);
            this.panel5.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1163, 639);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.detailsGB);
            this.panel6.Size = new System.Drawing.Size(1163, 599);
            this.panel6.Controls.SetChildIndex(this.detailsGB, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1163, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // roleText
            // 
            this.roleText.Location = new System.Drawing.Point(20, 90);
            this.roleText.MaxLength = 50;
            this.roleText.Name = "roleText";
            this.roleText.Size = new System.Drawing.Size(180, 23);
            this.roleText.TabIndex = 3;
            this.roleText.TextChanged += new System.EventHandler(this.roleText_TextChanged);
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.statusDD.Location = new System.Drawing.Point(15, 145);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(185, 23);
            this.statusDD.TabIndex = 4;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // detailsGB
            // 
            this.detailsGB.Controls.Add(this.dataGridView1);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Location = new System.Drawing.Point(0, 50);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(1163, 549);
            this.detailsGB.TabIndex = 1;
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
            this.roleIDGV,
            this.RolesGV,
            this.StatusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 527);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roleIDGV
            // 
            this.roleIDGV.HeaderText = "Role ID";
            this.roleIDGV.Name = "roleIDGV";
            this.roleIDGV.ReadOnly = true;
            // 
            // RolesGV
            // 
            this.RolesGV.HeaderText = "Roles";
            this.RolesGV.Name = "RolesGV";
            this.RolesGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // roleErrorLabel
            // 
            this.roleErrorLabel.AutoSize = true;
            this.roleErrorLabel.Location = new System.Drawing.Point(184, 79);
            this.roleErrorLabel.Name = "roleErrorLabel";
            this.roleErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.roleErrorLabel.TabIndex = 5;
            this.roleErrorLabel.Text = "*";
            this.roleErrorLabel.Visible = false;
            this.roleErrorLabel.Click += new System.EventHandler(this.roleErrorLabel_Click);
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Location = new System.Drawing.Point(184, 135);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.statusErrorLabel.TabIndex = 6;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 639);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
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

        private ComboBox statusDD;
        private TextBox roleText;
        private Label label3;
        private Label label2;
        private GroupBox detailsGB;
        private DataGridView dataGridView1;
        private Label roleErrorLabel;
        private Label statusErrorLabel;
        private DataGridViewTextBoxColumn roleIDGV;
        private DataGridViewTextBoxColumn RolesGV;
        private DataGridViewTextBoxColumn StatusGV;
    }
}