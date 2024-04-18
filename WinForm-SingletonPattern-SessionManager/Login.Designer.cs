namespace WinForm_SingletonPattern_SessionManager
{
    partial class Login
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
            signin = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // signin
            // 
            signin.Location = new Point(346, 206);
            signin.Name = "signin";
            signin.Size = new Size(75, 23);
            signin.TabIndex = 3;
            signin.Text = "Sign-in";
            signin.UseVisualStyleBackColor = true;
            signin.Click += signin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(317, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(317, 125);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(143, 23);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 128);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 157);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(signin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signin;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
    }
}
