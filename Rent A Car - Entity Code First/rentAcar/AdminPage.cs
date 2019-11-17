using rentAcar.DATA;
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
namespace rentAcar
{
    public partial class AdminPage : Form
    {

        Car carUpdate;

        dataContext db = new dataContext();

        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            groupBox1.Show();

        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            carList();
            userList();
            hireList();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox4.Hide();
            comboFill();
        }

        void carList()
        {
            listView1.Items.Clear();
            foreach (Car item in db.Cars.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.CarID.ToString();
                lvi.SubItems.Add(item.carBrand);
                lvi.SubItems.Add(item.carModel);
                lvi.SubItems.Add(item.licensePlate);
                lvi.SubItems.Add(item.carType);
                lvi.SubItems.Add(item.gear);
                lvi.SubItems.Add(item.fuel);
                lvi.SubItems.Add(item.priceClass.ToString());
                lvi.SubItems.Add(item.carPic);

                lvi.Tag = item.CarID;
                listView1.Items.Add(lvi);

            }
        }



        void userList()
        {
            listView2.Items.Clear();
            foreach (User item in db.Users.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.userID.ToString();
                lvi.SubItems.Add(item.name);
                lvi.SubItems.Add(item.lastName);
                lvi.SubItems.Add(item.TC);
                lvi.SubItems.Add(item.driveLicense);
                lvi.SubItems.Add(item.phone);
                lvi.SubItems.Add(item.eMail);

                lvi.Tag = item.userID;
                listView2.Items.Add(lvi);

            }
        }


        void hireList()
        {
            listView3.Items.Clear();
            foreach (Hire item in db.Hires.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.hireID.ToString();

                lvi.SubItems.Add(item.carID.ToString());
                lvi.SubItems.Add(item.UserID.ToString());
                lvi.SubItems.Add(item.hireStart.ToString());
                lvi.SubItems.Add(item.hireEnd.ToString());
                lvi.SubItems.Add(item.hireTime.ToString());
                lvi.SubItems.Add(item.price.ToString());

                lvi.Tag = item.hireID;
                listView3.Items.Add(lvi);

            }
        }


       

        void comboFill()
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");

        }



        private void cBUTTONLogIn_Click(object sender, EventArgs e)
        {
            string adminPassword = "1";


            if (txtAdminPassword.Text == adminPassword)
            {
                groupBox3.Hide();
                groupBox1.Show();


            }


        }



        private void listView1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(listView1.SelectedItems[0].Tag);
            carUpdate = db.Cars.Find(id);

            txtCarBrad.Text = carUpdate.carBrand;
            txtCarModel.Text = carUpdate.carModel;
            txtLicnPlate.Text = carUpdate.licensePlate;
            txtType.Text = carUpdate.carType;
            txtGear.Text = carUpdate.gear;
            txtFuel.Text = carUpdate.fuel;
            txtPicRL.Text = carUpdate.carPic;
            comboBox1.SelectedItem = carUpdate.priceClass.ToString();

            colorSet();
        }
        void colorSet()
        {
            txtCarBrad.ForeColor = System.Drawing.SystemColors.Window;
            txtCarModel.ForeColor = System.Drawing.SystemColors.Window;
            txtLicnPlate.ForeColor = System.Drawing.SystemColors.Window;
            txtType.ForeColor = System.Drawing.SystemColors.Window;
            txtGear.ForeColor = System.Drawing.SystemColors.Window;
            txtFuel.ForeColor = System.Drawing.SystemColors.Window;
            txtPicRL.ForeColor = System.Drawing.SystemColors.Window;
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox4.Hide();
            groupBox2.Show();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp;)|*.jpg; *.jpeg; *.gif; *.png; *.bmp;";
            if (open.ShowDialog()==DialogResult.OK)
            {
                txtPicRL.Text = open.FileName;

            }
        }
        private void btbSave_Click(object sender, EventArgs e)
        {
            var date1 = new DateTime(1900, 1, 1, 8, 30, 52);
            var date2 = new DateTime(1900, 1, 1, 8, 30, 52);

            Car cr = new Car();
            cr.carBrand = txtCarBrad.Text;
            cr.carModel = txtCarModel.Text;
            cr.fuel = txtFuel.Text;
            cr.gear = txtGear.Text;
            cr.licensePlate = txtLicnPlate.Text;
            cr.carType = txtType.Text;
            cr.carPic = txtPicRL.Text;
            cr.hireStart = date1;
            cr.hireEnd = date2;
            cr.priceClass = int.Parse(comboBox1.SelectedItem.ToString());

            db.Cars.Add(cr);
            db.SaveChanges();

            ResetText();
            carList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0 && carUpdate == null)
                return;

            carUpdate.carBrand = txtCarBrad.Text;
            carUpdate.carModel = txtCarModel.Text;
            carUpdate.licensePlate = txtLicnPlate.Text;
            carUpdate.carType = txtType.Text;
            carUpdate.gear = txtGear.Text ;
            carUpdate.fuel = txtFuel.Text ;
            carUpdate.carPic = txtPicRL.Text;
            carUpdate.priceClass = int.Parse(comboBox1.SelectedItem.ToString());

            db.Entry(db.Cars.Find(carUpdate.CarID)).CurrentValues.SetValues(carUpdate);
            db.SaveChanges();

            txtreset();
            carList();
        }


        private void cutomButton2_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            Car deleted = db.Cars.Find(id);
            db.Cars.Remove(deleted);
            db.SaveChanges();
            userList();


            carList();
        }


        void txtreset()
        {
            txtCarBrad.Text = "Marka";
            txtCarBrad.ForeColor = Color.Silver;

            txtCarModel.Text = "Model";
            txtCarModel.ForeColor = Color.Silver;

            txtLicnPlate.Text = "Plaka";
            txtLicnPlate.ForeColor = Color.Silver;

            txtType.Text = "Araç Tipi";
            txtType.ForeColor = Color.Silver;

            txtGear.Text = "Vites";
            txtGear.ForeColor = Color.Silver;

            txtFuel.Text = "Yakıt";
            txtFuel.ForeColor = Color.Silver;

            txtPicRL.Text = "Fotoğraf Yolu";
            txtPicRL.ForeColor = Color.Silver;        
        }


        #region panel1_MouseMove

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region buttons
        private void btbSave_MouseHover(object sender, EventArgs e)
        {
            btbSave.c0 = Color.DeepPink;
            btbSave.Font = new Font("MicrosoftTaiLe", 14, FontStyle.Bold);
        }

        private void btbSave_MouseLeave(object sender, EventArgs e)
        {
            btbSave.c0 = Color.DeepPink;
            btbSave.Font = new Font("MicrosoftTaiLe", 12, FontStyle.Bold);
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.c0 = Color.DeepPink;
            btnUpdate.Font = new Font("MicrosoftTaiLe", 14, FontStyle.Bold); 
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.c0 = Color.DeepPink;
            btnUpdate.Font = new Font("MicrosoftTaiLe", 12, FontStyle.Bold); 
        }


        #endregion

        private void btnCars_Click_1(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox4.Hide();
            groupBox1.Show();
        }

        User usUpdate;

        private void listView2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(listView2.SelectedItems[0].Tag);
            usUpdate = db.Users.Find(id);

            txtName.Text = usUpdate.name;
            txtLastname.Text = usUpdate.lastName;
            txtTC.Text = usUpdate.TC;
            txtDlicen.Text = usUpdate.driveLicense;
            txtmail.Text = usUpdate.eMail;
            txtphone.Text = usUpdate.phone;



            colorSetUser();
        }

        private void cutomButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listView2.SelectedItems[0].Tag);
            User deleted = db.Users.Find(id);
            db.Users.Remove(deleted);
            db.SaveChanges();
            userList();
        }
       


        void colorSetUser()
        {
            txtName.ForeColor = System.Drawing.SystemColors.Window;
            txtLastname.ForeColor = System.Drawing.SystemColors.Window;
            txtTC.ForeColor = System.Drawing.SystemColors.Window;
            txtDlicen.ForeColor = System.Drawing.SystemColors.Window;
            txtmail.ForeColor = System.Drawing.SystemColors.Window;
            txtphone.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void cBTNsave_Click(object sender, EventArgs e)
        {
            User us = new User();

            us.name = txtName.Text;
            us.lastName = txtLastname.Text;
            us.TC = txtTC.Text;
            us.phone = txtphone.Text;
            us.eMail = txtmail.Text;
            us.driveLicense = txtDlicen.Text;

            db.Users.Add(us);
            db.SaveChanges();

            txtUserreset();
            userList();
        }

        private void cBTNupdate_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count <= 0 && usUpdate == null)
                return;

            usUpdate.name = txtName.Text;
            usUpdate.lastName = txtLastname.Text;
            usUpdate.phone = txtphone.Text;
            usUpdate.eMail = txtmail.Text;
            usUpdate.driveLicense = txtDlicen.Text;
            usUpdate.TC = txtTC.Text;

            db.Entry(db.Cars.Find(usUpdate.userID)).CurrentValues.SetValues(usUpdate);
            db.SaveChanges();

            txtUserreset();
            userList();
        }

        void txtUserreset()
        {
            txtName.Text = "Isim";
            txtName.ForeColor = Color.Silver;

            txtLastname.Text = "Soyisim";
            txtLastname.ForeColor = Color.Silver;

            txtphone.Text = "Telefon";
            txtphone.ForeColor = Color.Silver;

            txtmail.Text = "E-Mail";
            txtmail.ForeColor = Color.Silver;

            txtDlicen.Text = "Ehliyet no";
            txtDlicen.ForeColor = Color.Silver;

            txtTC.Text = "TC";
            txtTC.ForeColor = Color.Silver;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void txtAdminPassword_Click(object sender, EventArgs e)
        {
            txtAdminPassword.Text = "";
            char a = '*';
            txtAdminPassword.PasswordChar = a;
            txtAdminPassword.ForeColor = System.Drawing.SystemColors.Window;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox4.Show();
        }

        #region carpanel txts

        private void txtCarBrad_Click(object sender, EventArgs e)
        {
            txtCarBrad.Text = "";
            txtCarBrad.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtLicnPlate_Click(object sender, EventArgs e)
        {
            txtLicnPlate.Text = "";
            txtLicnPlate.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtCarModel_Click(object sender, EventArgs e)
        {
            txtCarModel.Text = "";
            txtCarModel.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtType_Click(object sender, EventArgs e)
        {
            txtType.Text = "";
            txtType.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtGear_Click(object sender, EventArgs e)
        {
            txtGear.Text = "";
            txtGear.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtFuel_Click(object sender, EventArgs e)
        {
            txtFuel.Text = "";
            txtFuel.ForeColor = System.Drawing.SystemColors.Window;
        }

        private void txtPicRL_Click(object sender, EventArgs e)
        {
            txtPicRL.Text = "";
            txtPicRL.ForeColor = System.Drawing.SystemColors.Window;
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
