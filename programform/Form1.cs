using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programform
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            int num1, num2, res;
            num1 = int.Parse(this.text1.Text);
            num2 = int.Parse(this.text2.Text);
            res = num1 + num2;

            MessageBox.Show("el resultado es: "+ res);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = int.Parse(this.text1.Text);
            num2 = int.Parse(this.text2.Text);
            res = num1 - num2;

            MessageBox.Show("el resultado es: " + res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = int.Parse(this.text1.Text);
            num2 = int.Parse(this.text2.Text);
            res = num1 * num2;

            MessageBox.Show("el resultado es: " + res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double  num1, num2, res;
            num1 = double.Parse(this.text1.Text);
            num2 = double.Parse(this.text2.Text);
            res = num1 / num2;

            MessageBox.Show("el resultado es: " + res);
        }
    }
}
