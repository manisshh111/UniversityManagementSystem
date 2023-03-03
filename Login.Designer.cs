namespace UniversityMSApp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.left.SuspendLayout();
            this.panel5.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(228, 647);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.loginBtn);
            this.panel5.Controls.Add(this.passwordText);
            this.panel5.Controls.Add(this.usernameText);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Size = new System.Drawing.Size(228, 607);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(1242, 647);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(1242, 607);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1242, 40);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(46, 163);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(146, 23);
            this.usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(43, 218);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(149, 23);
            this.passwordText.TabIndex = 3;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(43, 258);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(82, 28);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 647);
            this.ControlBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.left.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button loginBtn;
        private TextBox passwordText;
        private TextBox usernameText;
        private Label label2;
        private Label label1;
    }
}