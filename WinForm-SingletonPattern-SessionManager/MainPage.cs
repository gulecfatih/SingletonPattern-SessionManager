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
    public partial class MainPage : CustomForm
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.SignOut();
            Login form1 = new Login();
            this.Hide();
            form1.Show();
        }

        private void myUser_Click(object sender, EventArgs e)
        {
            MyUser myUser = new MyUser();
            this.Hide();
            myUser.Show();
        }

        private void myFavorite_Click(object sender, EventArgs e)
        {
            MyFavorite myFavorite = new MyFavorite();
            this.Hide();
            myFavorite.Show();
        }

        private void myBasket_Click(object sender, EventArgs e)
        {
            MyBasket myBasket = new MyBasket();
            this.Hide();
            myBasket.Show();
        }
    }
}
