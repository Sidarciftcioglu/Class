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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car cr = new Car();
            cr.color = "Blue";
            cr.speed = 160;
            cr.enginePower=1234.56;
            cr.price = 50000;
            cr.condition = 'n';

            label1.Text = cr.color;
            label2.Text = cr.speed.ToString();
            label3.Text = cr.enginePower.ToString();
            label4.Text = cr.price.ToString();
            label5.Text = cr.condition.ToString();
            pictureBox1.BackColor = Color.Blue;


        }
    }
}
