using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentAcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime StartingDate = dateTimePicker1.Value;
            DateTime EndingDate = dateTimePicker2.Value;

            List<DateTime> rv = new List<DateTime>();

            DateTime tmpDate = StartingDate;
            do
            {
                rv.Add(tmpDate);
                tmpDate = tmpDate.AddDays(1);

            }
            while (tmpDate <= EndingDate);
            listBox1.DataSource = rv;


            int ilksecim = DateTime.Compare(EndingDate, DataStartingDate);
                
                

            int sonsecim = DateTime.Compare(StartingDate, DataStartingDateTwo);


            if (ilksecim == 1 && sonsecim == 1)
                label1.Text = "uygun";
            else
                label1.Text = "olmaz";



        }

        void control()
        {

        }

        List<DateTime> dataDateList;
        DateTime DataStartingDate;
        DateTime DataStartingDateTwo;

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            DataStartingDate = dateTimePicker3.Value;
            DataStartingDateTwo = dateTimePicker4.Value;

            dataDateList = new List<DateTime>();
            DateTime tmpDate = DataStartingDate;
            do
            {
                dataDateList.Add(tmpDate);
                tmpDate = tmpDate.AddDays(1);

            }
            while (tmpDate <= DataStartingDateTwo) ;
            listBox2.DataSource = dataDateList;

        }
    }
}
