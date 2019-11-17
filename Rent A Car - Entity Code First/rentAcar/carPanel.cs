using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rentAcar;
using rentAcar.DATA;

namespace panel
{
    public partial class carPanel : UserControl
    {        
        int carid;
        dataContext db = new dataContext();
        public carPanel()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.label10 = new System.Windows.Forms.Label();

            label13.Text = carid.ToString();
        }

        string brand;
        string model;
        string carType;
        string gear;
        string fuel;
        DateTime starDate;
        DateTime endDate;
        int userID;
        int priceClass;

        Image Image;

        [Category("Cars")]
        public string Brand { get {return brand; } set { brand = value; label1.Text = value; } }

        [Category("Cars")]
        public int Carid { get {return carid; } set { carid = value;  } }

        [Category("Cars")]
        public int UserID { get { return userID; } set { userID = value;  } }

        [Category("Cars")] 
        public string Model { get { return model; } set { model = value; label2.Text = value; } }
        [Category("Cars")]
 
        public string Gear { get { return gear; } set { gear = value; label3.Text = value; } }
        [Category("Cars")]
        public string Fuel { get { return fuel; } set { fuel = value; label4.Text = value; } }
        [Category("Cars")]
        public string Type { get { return carType; } set { carType = value; label5.Text = value; } }
        [Category("Cars")]

        public Image image{ get { return Image; } set { Image = value; pictureBox1.Image = value; } }
        public DateTime StarDate { get { return starDate; } set { starDate = value; dateTimePicker1.Value = value; } }
        public DateTime EndDate { get { return endDate; } set { endDate = value; dateTimePicker2.Value= value; } }

        [Category("Cars")]
        public int PriceClass { get { return priceClass; } set { priceClass = value; } }


        int hireTime;
        int price;
        Hire hr = new Hire();

        public void cutomButton1_Click(object sender, EventArgs e)
        {
            starDate = dateTimePicker1.Value;
            endDate = dateTimePicker2.Value;

            DateTime StartingDate = dateTimePicker1.Value;
            DateTime EndingDate = dateTimePicker2.Value;

            Car carCTRL = db.Cars.Where(x => x.CarID == Carid).First();

          
                DateTime DataStartingDate = carCTRL.hireStart;
                DateTime DataStartingEnd = carCTRL.hireEnd;

                int ilksecim = DateTime.Compare(EndingDate, DataStartingDate);
                int sonsecim = DateTime.Compare(StartingDate, DataStartingEnd);

                if (ilksecim == 1 && sonsecim == 1)
                {//yes
                    if (endDate > starDate)
                    {
                        hireTime = Convert.ToInt32((EndDate - StarDate).TotalDays);

                        hr.hireStart = StarDate;
                        hr.hireEnd = EndDate;
                        hr.carID = Carid;
                        hr.price = price;
                        hr.UserID = UserID;
                        hr.hireTime = hireTime;
                        db.Hires.Add(hr);
                        db.SaveChanges();
                        MessageBox.Show("Araç kiralandı");

                        Car cr = db.Cars.Where(x => x.CarID == Carid).First();
                        cr.hireStart = StarDate;
                        cr.hireEnd = EndDate;
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Kiralama başlangıç tarihi teslim tarihinden önce olmalıdır!!");
                    }

                }
                else
                {
                    MessageBox.Show("araç rezerve");
                }
            

           


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            StarDate = dateTimePicker1.Value;
            EndDate = dateTimePicker2.Value;
            hireTime = Convert.ToInt32((EndDate - StarDate).TotalDays);

            if (priceClass == 1)
            {
                price = hireTime * 10;

            }
            else if (priceClass == 2)
            {
                price = hireTime * 20;
            }
            else if (priceClass == 3)
            {
                price = hireTime * 30;
            }
            else
            price = hireTime * 10;

            label13.Text = price.ToString() + "TL";
        }
    }
}
