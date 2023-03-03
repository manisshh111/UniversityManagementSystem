namespace UniversityMSApp
{
    partial class Batches
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
            this.batchText = new System.Windows.Forms.TextBox();
            this.batchErrorLabel = new System.Windows.Forms.Label();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.batchIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.left.Size = new System.Drawing.Size(228, 604);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.batchText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.batchErrorLabel);
            this.panel5.Size = new System.Drawing.Size(228, 564);
            this.panel5.Controls.SetChildIndex(this.batchErrorLabel, 0);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.batchText, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1132, 604);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.detailsGB);
            this.panel6.Size = new System.Drawing.Size(1132, 564);
            this.panel6.Controls.SetChildIndex(this.detailsGB, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1132, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Batch Name";
            // 
            // batchText
            // 
            this.batchText.Location = new System.Drawing.Point(12, 79);
            this.batchText.Name = "batchText";
            this.batchText.Size = new System.Drawing.Size(210, 23);
            this.batchText.TabIndex = 2;
            // 
            // batchErrorLabel
            // 
            this.batchErrorLabel.AutoSize = true;
            this.batchErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.batchErrorLabel.Location = new System.Drawing.Point(203, 62);
            this.batchErrorLabel.Name = "batchErrorLabel";
            this.batchErrorLabel.Size = new System.Drawing.Size(16, 20);
            this.batchErrorLabel.TabIndex = 3;
            this.batchErrorLabel.Text = "*";
            // 
            // detailsGB
            // 
            this.detailsGB.Controls.Add(this.dataGridView1);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Location = new System.Drawing.Point(0, 50);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(1132, 514);
            this.detailsGB.TabIndex = 3;
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
            this.batchIDGV,
            this.batchGV});
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 492);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // batchIDGV
            // 
            this.batchIDGV.HeaderText = "Batch ID";
            this.batchIDGV.Name = "batchIDGV";
            this.batchIDGV.ReadOnly = true;
            // 
            // batchGV
            // 
            this.batchGV.HeaderText = "Batch";
            this.batchGV.Name = "batchGV";
            this.batchGV.ReadOnly = true;
            // 
            // Batches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 604);
            this.Name = "Batches";
            this.Text = "Batches";
            this.Load += new System.EventHandler(this.Batches_Load);
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

        private TextBox batchText;
        private Label label2;
        private Label batchErrorLabel;
        private GroupBox detailsGB;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn batchIDGV;
        private DataGridViewTextBoxColumn batchGV;
    }
}