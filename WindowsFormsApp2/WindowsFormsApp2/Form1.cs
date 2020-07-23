using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            {
                Console.WriteLine(z.Id);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo otraZona = TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time");
            TimeZoneInfo otraZona2 = TimeZoneInfo.FindSystemTimeZoneById("Egypt Standard Time");
            DateTime UTCmenos6 =  TimeZoneInfo.ConvertTime(DateTime.Now, otraZona);
            DateTime UTCmas2 = TimeZoneInfo.ConvertTime(DateTime.Now, otraZona2);
            label1.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
            label2.Text = Convert.ToString(UTCmenos6.ToLongTimeString());
            label3.Text = Convert.ToString(UTCmas2.ToLongTimeString());
        }
    }
}
