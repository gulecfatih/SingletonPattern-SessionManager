using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_SingletonPattern_SessionManager
{
    public partial class MyBasket : CustomForm
    {
        public MyBasket()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }
    }
}
