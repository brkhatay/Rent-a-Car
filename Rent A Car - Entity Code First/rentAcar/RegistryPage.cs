using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using rentAcar.DATA;
using rentAcar;

namespace BM
{
    public partial class RegistryPage : Form
    {

        dataContext db = new dataContext();

        public RegistryPage()
        {
            InitializeComponent();
        }

       

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void RegistryPageUpPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtRGPUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPUserName.Text = "";
            txtRGPUserName.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtRGPLastName_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPLastName.Text = "";
            txtRGPLastName.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtRGPPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPPassword.Text = "";
            char a = '*';
            txtRGPPassword.PasswordChar = a;
            txtRGPPassword.ForeColor = System.Drawing.SystemColors.Window;
            RPpassPanel.ForeColor = System.Drawing.SystemColors.Window;
        }


        private void txtRGPPassCheck_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPPassCheck.Text = "";
            char a = '*';
            txtRGPPassCheck.PasswordChar = a;
            txtRGPPassCheck.ForeColor = System.Drawing.SystemColors.Window;
            RPpassPanelTwo.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtRGPTC_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPTC.Text = "";
            txtRGPTC.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtRGPphone_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPphone.Text = "";
            txtRGPphone.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtRGPmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPmail.Text = "";
            txtRGPmail.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtRGPadress_MouseClick(object sender, MouseEventArgs e)
        {
           txtRGPadress.Text = "";
           txtRGPadress.ForeColor = System.Drawing.SystemColors.Window;
        }


        private void txtRGPliceneNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtRGPliceneNo.Text = "";
            txtRGPliceneNo.ForeColor = System.Drawing.SystemColors.Window;
        }



        private void buttonRGPclose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void txtRGPTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRGPliceneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cutomButton2_MouseHover(object sender, EventArgs e)
        {
            cutomButton2.c0 = Color.DeepPink;
            cutomButton2.Font = new Font("MicrosoftTaiLe", 25, FontStyle.Bold); ;
        }

        private void cutomButton2_MouseLeave(object sender, EventArgs e)
        {
            cutomButton2.c0 = Color.Purple;
            cutomButton2.Font = new Font("MicrosoftTaiLe", 23, FontStyle.Bold); ;
            
        }

        private void cutomButton2_Click(object sender, EventArgs e)
        {
            User us = new User();
            int cc = db.Users.Count();

            if (txtRGPPassword.Text == txtRGPPassCheck.Text)
            {
                if (cc <= 0)
                {
                    us.TC = txtRGPTC.Text;
                    us.name = txtRGPUserName.Text;
                    us.lastName = txtRGPLastName.Text;
                    us.password = txtRGPPassword.Text;
                    us.eMail = txtRGPmail.Text;
                    us.phone = txtRGPphone.Text;
                    us.driveLicense = txtRGPliceneNo.Text;
                    db.Users.Add(us);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt başarılı");
                }
                else
                {
                    foreach (User item in db.Users.ToList())
                    {
                        if (item.TC != txtRGPTC.Text)
                        {
                            us.TC = txtRGPTC.Text;
                            us.name = txtRGPUserName.Text;
                            us.lastName = txtRGPLastName.Text;
                            us.password = txtRGPPassword.Text;
                            us.eMail = txtRGPmail.Text;
                            us.phone = txtRGPphone.Text;
                            us.driveLicense = txtRGPliceneNo.Text;
                            db.Users.Add(us);
                            db.SaveChanges();
                            MessageBox.Show("Kayıt başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Aynı TC'ye ait başka kullanıcı mevcut.");
                        }
                    }
                }

            }
            else
            {
                txtRGPPassword.ForeColor = Color.Red;
                txtRGPPassCheck.ForeColor = Color.Red;
                MessageBox.Show("Girilen şifreler uyuşmadı!");
            }

        }

    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }
    }
}

