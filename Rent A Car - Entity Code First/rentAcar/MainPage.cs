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
using panel;
using rentAcar.DATA;

namespace rentAcar
{
    public partial class MainPage : Form
    {

        public int userid;
        dataContext db = new dataContext();

        public MainPage()
        {
            InitializeComponent();

        }

        private void cutomButton1_MouseHover(object sender, EventArgs e)
        {
            cutomButton1.c0 = Color.DeepPink;
            cutomButton1.Font = new Font("MicrosoftTaiLe", 25, FontStyle.Bold); ; 
        }

        private void cutomButton1_MouseLeave(object sender, EventArgs e)
        {
            cutomButton1.c0 = Color.Purple;
            cutomButton1.Font = new Font("MicrosoftTaiLe", 23, FontStyle.Bold); ;

        }

        #region panel1_MouseMove

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void MaınPage_Load(object sender, EventArgs e)
        {
            User us = db.Users.Where(x => x.userID == userid).First();
            label4.Text = us.name;
            flowLayoutPanel1.Hide();
            hireCTRL();

        }

        public void hireCTRL()
        {
            User us = db.Users.Where(x => x.userID == userid).First();
            Hire hr = new Hire();

            int count = db.Hires.Count();

            if (count <= 0)
            {
                return;
            }
            else
            {
                hr = db.Hires.Where(x => x.UserID == userid).First();
            }


            DateTime now = DateTime.Now;
            foreach (Hire item in db.Hires.Where(x => x.UserID == userid).ToList())
            {
                DataStartingDate = item.hireStart;
                DataStartingEnd = item.hireEnd;

                int ilksecim = DateTime.Compare(now, DataStartingDate);
                int sonsecim = DateTime.Compare(now, DataStartingEnd);

                if (ilksecim == 1 && sonsecim == 1)
                {

                }
                else
                {
                    Car cr = db.Cars.Where(x => x.CarID == item.carID).First();
                    flowLayoutPanel1.Show();
                    label5.Hide();
                    hiredCarPanel hcp = new hiredCarPanel();
                    hcp.Brand = cr.carBrand;
                    hcp.Model = cr.carModel;
                    hcp.Gear = cr.gear;
                    hcp.Fuel = cr.fuel;
                    hcp.Type = cr.carType;
                    hcp.image = new Bitmap(cr.carPic);
                    hcp.HireStart = cr.hireStart.ToString();
                    hcp.HireEnd = cr.hireEnd.ToString();

                    flowLayoutPanel1.Controls.Add(hcp);
                }
            }
        }
        
        DateTime DataStartingDate;
        DateTime DataStartingEnd;

        private void cutomButton1_Click(object sender, EventArgs e)
        {
            label5.Hide();
            
            flowLayoutPanel1.Show();
            DateTime StartingDate = dateTimePicker1.Value;
            DateTime EndingDate = dateTimePicker2.Value;
      

            flowLayoutPanel1.Controls.Clear();
            hireCTRL();

            foreach (Car item in db.Cars.ToList())
            {

                DataStartingDate = item.hireStart;
                DataStartingEnd = item.hireEnd;
               
                int ilksecim = DateTime.Compare(EndingDate, DataStartingDate);
                int sonsecim = DateTime.Compare(StartingDate, DataStartingEnd);


                if (ilksecim == 1 && sonsecim == 1)
                {//yes
                        carPanel cp = new carPanel();
                        cp.Brand = item.carBrand;
                        cp.Model = item.carModel;
                        cp.Gear = item.gear;
                        cp.Fuel = item.fuel;
                        cp.Type = item.carType;
                        cp.image = new Bitmap(item.carPic);
                        cp.Carid = item.CarID;
                        cp.PriceClass = item.priceClass;
                        cp.UserID = userid;
                        cp.StarDate = StartingDate;
                        cp.EndDate = EndingDate;

                        flowLayoutPanel1.Controls.Add(cp);
                }
                else//no
                {
                    reservedCarPanel rcp = new reservedCarPanel();
                    rcp.Brand = item.carBrand;
                    rcp.Model = item.carModel;
                    rcp.Gear = item.gear;
                    rcp.Fuel = item.fuel;
                    rcp.Type = item.carType;
                    rcp.image = new Bitmap(item.carPic);
                   
                    flowLayoutPanel1.Controls.Add(rcp);
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage ap = new AdminPage();
            ap.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }
    }
}
