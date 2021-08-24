using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Indexers
{
    public partial class Form1 : Form
    {
        MeasurmentManagement measurmentManagement = new MeasurmentManagement();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Measurments measurments = new Measurments();
            measurments.City = textBox1.Text.ToString();
            measurments.Day = int.Parse(textBox2.Text);
            measurments.Month = int.Parse(textBox7.Text);
            measurments.TempInCelcius = double.Parse(textBox3.Text);
            measurmentManagement.Add(measurments);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var measureManage = measurmentManagement[int.Parse(textBox4.Text)];
            textBox8.Text = measureManage.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var measureManage = measurmentManagement[textBox5.Text];
            textBox9.Text = measureManage.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var measureManage = measurmentManagement[textBox6.Text, int.Parse(textBox11.Text), int.Parse(textBox12.Text)];
            if (measureManage)
            {
                textBox10.Text = "Exist";
            }
            else
            {
                textBox10.Text = "Not Exist";
            }
        }
    }
}
