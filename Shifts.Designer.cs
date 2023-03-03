namespace UniversityMSApp
{
    partial class Shifts
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
            this.shiftNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 646);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.shiftNameText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Size = new System.Drawing.Size(228, 606);
            this.panel5.Controls.SetChildIndex(this.label2, 0);
            this.panel5.Controls.SetChildIndex(this.shiftNameText, 0);
            this.panel5.Controls.SetChildIndex(this.label3, 0);
            this.panel5.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(867, 646);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(867, 606);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(867, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shift Name";
            // 
            // shiftNameText
            // 
            this.shiftNameText.Location = new System.Drawing.Point(12, 85);
            this.shiftNameText.Name = "shiftNameText";
            this.shiftNameText.Size = new System.Drawing.Size(198, 23);
            this.shiftNameText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shift Number";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(12, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 646);
            this.Name = "Shifts";
            this.Text = "Shifts";
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Label label3;
        private TextBox shiftNameText;
        private Label label2;
    }
}