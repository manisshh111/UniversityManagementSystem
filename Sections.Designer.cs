namespace UniversityMSApp
{
    partial class Sections
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
            this.sectionText = new System.Windows.Forms.TextBox();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.sectionNameErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 654);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.statusCB);
            this.panel5.Controls.Add(this.sectionText);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.sectionNameErrorLabel);
            this.panel5.Controls.Add(this.statusErrorLabel);
            this.panel5.Size = new System.Drawing.Size(228, 614);
            this.panel5.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.sectionNameErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.sectionText, 0);
            this.panel5.Controls.SetChildIndex(this.statusCB, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1215, 654);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Size = new System.Drawing.Size(1215, 614);
            this.panel6.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1215, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // sectionText
            // 
            this.sectionText.Location = new System.Drawing.Point(12, 98);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(210, 23);
            this.sectionText.TabIndex = 3;
            this.sectionText.TextChanged += new System.EventHandler(this.sectionText_TextChanged);
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(12, 152);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(210, 23);
            this.statusCB.TabIndex = 4;
            this.statusCB.SelectedIndexChanged += new System.EventHandler(this.statusCB_SelectedIndexChanged);
            // 
            // sectionNameErrorLabel
            // 
            this.sectionNameErrorLabel.AutoSize = true;
            this.sectionNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sectionNameErrorLabel.Location = new System.Drawing.Point(202, 84);
            this.sectionNameErrorLabel.Name = "sectionNameErrorLabel";
            this.sectionNameErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.sectionNameErrorLabel.TabIndex = 5;
            this.sectionNameErrorLabel.Text = "*";
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusErrorLabel.Location = new System.Drawing.Point(203, 138);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(17, 21);
            this.statusErrorLabel.TabIndex = 6;
            this.statusErrorLabel.Text = "*";
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
            this.SectionIDGV,
            this.sectionNameGV,
            this.statusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 564);
            this.dataGridView1.TabIndex = 1;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "SNO";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 56;
            // 
            // SectionIDGV
            // 
            this.SectionIDGV.HeaderText = "Section ID";
            this.SectionIDGV.Name = "SectionIDGV";
            this.SectionIDGV.ReadOnly = true;
            // 
            // sectionNameGV
            // 
            this.sectionNameGV.HeaderText = "Section Name";
            this.sectionNameGV.Name = "sectionNameGV";
            this.sectionNameGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 654);
            this.Name = "Sections";
            this.Text = "Sections";
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox statusCB;
        private TextBox sectionText;
        private Label label3;
        private Label label2;
        private Label sectionNameErrorLabel;
        private Label statusErrorLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn SectionIDGV;
        private DataGridViewTextBoxColumn sectionNameGV;
        private DataGridViewTextBoxColumn statusGV;
    }
}