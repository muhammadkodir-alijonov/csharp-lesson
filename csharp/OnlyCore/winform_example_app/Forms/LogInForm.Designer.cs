namespace winform_example_app
{
    partial class LogInForm
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
            Email = new System.Windows.Forms.Label();
            tbEmail = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tbPassword = new System.Windows.Forms.TextBox();
            btmLogIn = new System.Windows.Forms.Button();
            tbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = System.Drawing.SystemColors.Info;
            Email.Location = new System.Drawing.Point(23, 9);
            Email.Name = "Email";
            Email.Size = new System.Drawing.Size(46, 20);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new System.Drawing.Point(23, 46);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new System.Drawing.Size(321, 27);
            tbEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Info;
            label1.Location = new System.Drawing.Point(23, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(23, 139);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new System.Drawing.Size(321, 27);
            tbPassword.TabIndex = 5;
            // 
            // btmLogIn
            // 
            btmLogIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btmLogIn.Location = new System.Drawing.Point(67, 196);
            btmLogIn.Name = "btmLogIn";
            btmLogIn.Size = new System.Drawing.Size(185, 42);
            btmLogIn.TabIndex = 6;
            btmLogIn.Text = "Log In";
            btmLogIn.UseVisualStyleBackColor = false;
            btmLogIn.Click += this.btmLogIn_Click;
            // 
            // tbMessage
            // 
            tbMessage.AutoSize = true;
            tbMessage.Location = new System.Drawing.Point(250, 262);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new System.Drawing.Size(0, 20);
            tbMessage.TabIndex = 7;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = winform_example_app.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 451);
            this.Controls.Add(tbMessage);
            this.Controls.Add(btmLogIn);
            this.Controls.Add(tbPassword);
            this.Controls.Add(label1);
            this.Controls.Add(tbEmail);
            this.Controls.Add(Email);
            this.Name = "LogInForm";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label Email;
        private TextBox tbEmail;
        private Label label1;
        private TextBox tbPassword;
        private Button btmLogIn;
        private Label tbMessage;
    }
}