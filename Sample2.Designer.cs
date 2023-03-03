namespace UniversityMSApp
{
    partial class Sample2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.right.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 638);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Size = new System.Drawing.Size(228, 598);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1214, 638);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Size = new System.Drawing.Size(1214, 598);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1214, 40);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 50);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.editBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // viewBtn
            // 
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBtn.Location = new System.Drawing.Point(743, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(180, 35);
            this.viewBtn.TabIndex = 4;
            this.viewBtn.Text = "VIEW";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Location = new System.Drawing.Point(558, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(179, 35);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Location = new System.Drawing.Point(373, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(179, 35);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.Location = new System.Drawing.Point(188, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(179, 35);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(179, 35);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 50);
            this.panel7.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(24, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 638);
            this.ControlBox = false;
            this.Name = "Sample2";
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.right.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button viewBtn;
        private Button deleteBtn;
        private Button saveBtn;
        private Button editBtn;
        private Button addBtn;
        private Panel panel7;
        private Button backBtn;
    }
}