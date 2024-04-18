using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_SingletonPattern_SessionManager.Manager;

namespace WinForm_SingletonPattern_SessionManager
{
    public partial class CustomForm : Form
    {
        public Label customLabel;

        public CustomForm()
        {
            InitializeComponent();
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            // Sol üst köşede bir label oluştur
            customLabel = new Label();
            
            if (SessionManager.Instance.IsSessionStarted())
                customLabel.Text = "Connected - " + SessionManager.Instance.GetSessionId();
            else
                customLabel.Text = "Not Connected";
            customLabel.AutoSize = true;
            customLabel.Location = new Point( 10, 10); // Sabit konum belirle
            customLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left; // Label'in formun sol üst köşesine sabitlenmesini sağlar
            // Label'i forma ekle
            this.Controls.Add(customLabel);
        }
    }
}
