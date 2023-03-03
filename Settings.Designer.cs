namespace UniversityMSApp
{
    partial class Settings
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseText = new System.Windows.Forms.TextBox();
            this.datasourceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.datasourceerrorlabel = new System.Windows.Forms.Label();
            this.dberrorlabel = new System.Windows.Forms.Label();
            this.usernameerrorlabel = new System.Windows.Forms.Label();
            this.passworderrorlabel = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 642);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.isCB);
            this.panel5.Controls.Add(this.databaseText);
            this.panel5.Controls.Add(this.datasourceText);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.saveBtn);
            this.panel5.Controls.Add(this.passwordText);
            this.panel5.Controls.Add(this.usernameText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.datasourceerrorlabel);
            this.panel5.Controls.Add(this.dberrorlabel);
            this.panel5.Controls.Add(this.usernameerrorlabel);
            this.panel5.Controls.Add(this.passworderrorlabel);
            this.panel5.Size = new System.Drawing.Size(228, 602);
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1242, 642);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(1242, 602);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1242, 40);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(14, 441);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 28);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(14, 385);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(197, 23);
            this.passwordText.TabIndex = 3;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(11, 331);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(194, 23);
            this.usernameText.TabIndex = 2;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // databaseText
            // 
            this.databaseText.Location = new System.Drawing.Point(14, 238);
            this.databaseText.Name = "databaseText";
            this.databaseText.Size = new System.Drawing.Size(197, 23);
            this.databaseText.TabIndex = 1;
            this.databaseText.TextChanged += new System.EventHandler(this.databaseText_TextChanged);
            // 
            // datasourceText
            // 
            this.datasourceText.Location = new System.Drawing.Point(14, 183);
            this.datasourceText.Name = "datasourceText";
            this.datasourceText.Size = new System.Drawing.Size(194, 23);
            this.datasourceText.TabIndex = 0;
            this.datasourceText.TextChanged += new System.EventHandler(this.datasourceText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Source";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(14, 274);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(125, 19);
            this.isCB.TabIndex = 4;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // datasourceerrorlabel
            // 
            this.datasourceerrorlabel.AutoSize = true;
            this.datasourceerrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datasourceerrorlabel.Location = new System.Drawing.Point(191, 168);
            this.datasourceerrorlabel.Name = "datasourceerrorlabel";
            this.datasourceerrorlabel.Size = new System.Drawing.Size(17, 21);
            this.datasourceerrorlabel.TabIndex = 15;
            this.datasourceerrorlabel.Text = "*";
            this.datasourceerrorlabel.Visible = false;
            // 
            // dberrorlabel
            // 
            this.dberrorlabel.AutoSize = true;
            this.dberrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dberrorlabel.Location = new System.Drawing.Point(191, 223);
            this.dberrorlabel.Name = "dberrorlabel";
            this.dberrorlabel.Size = new System.Drawing.Size(17, 21);
            this.dberrorlabel.TabIndex = 16;
            this.dberrorlabel.Text = "*";
            this.dberrorlabel.Visible = false;
            // 
            // usernameerrorlabel
            // 
            this.usernameerrorlabel.AutoSize = true;
            this.usernameerrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameerrorlabel.Location = new System.Drawing.Point(191, 316);
            this.usernameerrorlabel.Name = "usernameerrorlabel";
            this.usernameerrorlabel.Size = new System.Drawing.Size(17, 21);
            this.usernameerrorlabel.TabIndex = 17;
            this.usernameerrorlabel.Text = "*";
            this.usernameerrorlabel.Visible = false;
            // 
            // passworderrorlabel
            // 
            this.passworderrorlabel.AutoSize = true;
            this.passworderrorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passworderrorlabel.Location = new System.Drawing.Point(191, 370);
            this.passworderrorlabel.Name = "passworderrorlabel";
            this.passworderrorlabel.Size = new System.Drawing.Size(17, 21);
            this.passworderrorlabel.TabIndex = 18;
            this.passworderrorlabel.Text = "*";
            this.passworderrorlabel.Visible = false;
            // 
            // Settings
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 642);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox isCB;
        private TextBox databaseText;
        private TextBox datasourceText;
        private Label label3;
        private Label label4;
        private Button saveBtn;
        private TextBox passwordText;
        private TextBox usernameText;
        private Label label2;
        private Label label1;
        private Label datasourceerrorlabel;
        private Label dberrorlabel;
        private Label usernameerrorlabel;
        private Label passworderrorlabel;
    }
}