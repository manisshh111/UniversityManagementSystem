namespace UniversityMSApp
{
    partial class Sample
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.left = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.left.SuspendLayout();
            this.panel3.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.left.Controls.Add(this.panel5);
            this.left.Controls.Add(this.panel3);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.ForeColor = System.Drawing.Color.White;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(228, 645);
            this.left.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 605);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 40);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // right
            // 
            this.right.Controls.Add(this.panel6);
            this.right.Controls.Add(this.panel4);
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.Location = new System.Drawing.Point(228, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(1236, 645);
            this.right.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1236, 605);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1236, 40);
            this.panel4.TabIndex = 0;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1464, 645);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Name = "Sample";
            this.left.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Panel left;
        public Panel panel5;
        public Panel panel3;
        public Panel right;
        public Panel panel6;
        public Panel panel4;
        private Label label1;
    }
}