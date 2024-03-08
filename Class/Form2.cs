using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Car cr2 = new Car();
            cr2.color = "Red";
            cr2.speed = 200;
            cr2.enginePower = 1234.89;
            cr2.price = 150000;
            cr2.condition = 'o';
            cr2.YEAR = -2016;
            cr2.BRAND = "Golf";
            cr2.inspection = 2017;
            cr2.licensePlate = "34 SDR 1998";
            cr2.owner = "Sidar Çiftçioğlu";
            


            label1.Text = cr2.color;
            label2.Text = cr2.speed.ToString();
            label3.Text = cr2.enginePower.ToString();
            label4.Text = cr2.price.ToString();
            label5.Text = cr2.condition.ToString();
            label6.Text = cr2.YEAR.ToString();
            label7.Text = cr2.BRAND.ToString();
            label8.Text = cr2.inspection.ToString();
            label9.Text = cr2.licensePlate;
            label10.Text = cr2.owner;
            pictureBox2.BackColor = Color.Red;

        }
    }
}
