namespace WinForm_SingletonPattern_SessionManager
{
    partial class MainPage
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
            Out = new Button();
            myBasket = new Button();
            myFavorite = new Button();
            myUser = new Button();
            SuspendLayout();
            // 
            // Out
            // 
            Out.Location = new Point(700, 12);
            Out.Name = "Out";
            Out.Size = new Size(75, 23);
            Out.TabIndex = 4;
            Out.Text = "Out";
            Out.UseVisualStyleBackColor = true;
            Out.Click += Out_Click;
            // 
            // myBasket
            // 
            myBasket.Location = new Point(544, 282);
            myBasket.Name = "myBasket";
            myBasket.Size = new Size(125, 23);
            myBasket.TabIndex = 3;
            myBasket.Text = "My Basket";
            myBasket.UseVisualStyleBackColor = true;
            myBasket.Click += myBasket_Click;
            // 
            // myFavorite
            // 
            myFavorite.Location = new Point(324, 282);
            myFavorite.Name = "myFavorite";
            myFavorite.Size = new Size(125, 23);
            myFavorite.TabIndex = 2;
            myFavorite.Text = "My Favorite";
            myFavorite.UseVisualStyleBackColor = true;
            myFavorite.Click += myFavorite_Click;
            // 
            // myUser
            // 
            myUser.Location = new Point(64, 282);
            myUser.Name = "myUser";
            myUser.Size = new Size(125, 23);
            myUser.TabIndex = 1;
            myUser.Text = "My User";
            myUser.UseVisualStyleBackColor = true;
            myUser.Click += myUser_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myUser);
            Controls.Add(myFavorite);
            Controls.Add(myBasket);
            Controls.Add(Out);
            Name = "MainPage";
            Text = "AnaSayfa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Out;
        private Button myBasket;
        private Button myFavorite;
        private Button myUser;
    }
}