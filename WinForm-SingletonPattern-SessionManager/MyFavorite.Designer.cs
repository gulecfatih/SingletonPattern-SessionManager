namespace WinForm_SingletonPattern_SessionManager
{
    partial class MyFavorite
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
            Back = new Button();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(713, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 3;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // MyFavorite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Name = "MyFavorite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyFavorite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
    }
}