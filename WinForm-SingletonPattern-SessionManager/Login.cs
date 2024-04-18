using WinForm_SingletonPattern_SessionManager.Manager;

namespace WinForm_SingletonPattern_SessionManager
{
    public partial class Login : CustomForm
    {
        public Login()
        {
            InitializeComponent();

        }

        private void signin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "fatih" && txtPassword.Text == "123")
            {
                SessionManager.Instance.StartSession();
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();

            }
        }
    }

}
