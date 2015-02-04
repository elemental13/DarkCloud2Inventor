using System;
using System.Drawing;
using System.Windows.Forms;
using DarkCloud2Inventor.Properties;

namespace DarkCloud2Inventor
{
    public partial class LogIn : Form
    {
        public static LogIn LogInMenu
        {
            get { return _logInMenu ?? (_logInMenu = new LogIn()); }
        }
        private static LogIn _logInMenu;

        private readonly DataConnection _dbConnection = new DataConnection();

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
           var correctLogin = _dbConnection.LogIn(Username.Text, Password.Text);

            if (correctLogin == false)
            {
                MessageBox.Show(Resources.IncorrectLogin);
            }
            else
            {
                var mainScreen = MainScreen.ScreenMenu;
                mainScreen.UserAccount = Username.Text;
                mainScreen.Visible = true;
                mainScreen.Show();
                Hide();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            SelectLogin.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            SelectLogin.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            SelectNewUser.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            SelectNewUser.Visible = false;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var addUser = _dbConnection.AddUser(Username.Text, Password.Text);


            if ( String.IsNullOrEmpty(Username.Text) || String.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show(Resources.CantBeBlank);
            }
            else if (addUser == false)
            {
                MessageBox.Show(Resources.UserTaken);
            }
            else
            {
                MessageBox.Show(Resources.NewUserMsg);

                var mainScreen = MainScreen.ScreenMenu;
                mainScreen.UserAccount = Username.Text;
                mainScreen.Visible = true;
                mainScreen.Show();
                Hide();
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
