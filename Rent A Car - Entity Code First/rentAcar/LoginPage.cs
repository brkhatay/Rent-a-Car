using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BM;
using rentAcar.DATA;
using System.Runtime.InteropServices;

namespace rentAcar
{
    public partial class LoginPage : Form
    {
        dataContext db = new dataContext();

        public LoginPage()
        {
            InitializeComponent();
        }


        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegistryPage rp = new RegistryPage();
            rp.Show();
            this.Hide();
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Text = "";
            txtUserName.ForeColor = System.Drawing.SystemColors.Window;

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
            char a = '*';
            txtPassword.PasswordChar = a;
            txtPassword.ForeColor = System.Drawing.SystemColors.Window;
        }


        private void buttonLog_Click_1(object sender, EventArgs e)
        {
            buttonLog.c0 = Color.Pink;

            string UserTC = txtUserName.Text;

            User u = db.Users.Where(x => x.TC == UserTC).First();
            string userPassword = u.password;
            string inPassword = txtPassword.Text;


            if (userPassword != inPassword )
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı!");
            }
            else
            {
                MainPage mp = new MainPage();
                mp.userid = u.userID;
                mp.Show();
                this.Hide();
            }



        }

        private void buttonLog_MouseHover(object sender, EventArgs e)
        {
            buttonLog.c0 = Color.DeepPink;
            buttonLog.Font = new Font("MicrosoftTaiLe", 25, FontStyle.Bold); ;
        }

        private void buttonLog_MouseLeave(object sender, EventArgs e)
        {
            buttonLog.c0 = Color.Purple;
            buttonLog.Font = new Font("MicrosoftTaiLe", 23, FontStyle.Bold); ;

        }

        private void buttonRGPclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistryPage rp = new RegistryPage();
            rp.Show();
            this.Hide();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtUserName.ForeColor = System.Drawing.SystemColors.Window;

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            char a = '*';
            txtPassword.PasswordChar = a;
            txtPassword.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage ap = new AdminPage();
            ap.Show();
            this.Hide();

        }


        #region panel1_MouseMove

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void LoginPageUpPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion


   
    }
}
