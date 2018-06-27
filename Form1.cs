using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cloth, hair, item, shoe, time, times, studio, wtotal, mtotal,a;
            

            cloth = float.Parse(textBox1.Text);
            hair = float.Parse(textBox2.Text);
            item = float.Parse(textBox3.Text);
            shoe = float.Parse(textBox4.Text);
            studio = float.Parse(textBox8.Text);

            time = float.Parse(textBox5.Text);
            times = float.Parse(textBox6.Text);



            a = Math.Round(studio * 2 / (cloth + hair + item + shoe));

            propose.Text = a.ToString();

            mtotal = Math.Round (cloth + hair + item + shoe + studio);
            wtotal = Math.Round (mtotal - mtotal * (((100 / (10 - time))/100) + ((100 / (5 - times)) / 100)));


            if (time >= 10 && times>= 5)
            {
                wtotal = 0;
            }
            if (time >= 10)
            {
                wtotal = 0;
            }
            if (times >= 5)
            {
                wtotal = 0;
            }

            price.Text = mtotal.ToString();
            SecPrice.Text = wtotal.ToString();

            double s = 100;
            int result = 0;
            result = Convert.ToInt16(Math.Ceiling(s / 3));


           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
