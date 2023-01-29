using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,1722";

            textBox2.Text = "6,33";

            textBox3.Text = "3,25e-4";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text += "Лаб.раб №2 Ст. гр. ПОКС-33";

            double x = Double.Parse(textBox1.Text);

            textBox5.Text += Environment.NewLine + "X = " + x.ToString();

            double y = Double.Parse(textBox2.Text);

            textBox5.Text += Environment.NewLine + "Y = " + y.ToString();

            double z = Double.Parse(textBox3.Text);

            textBox5.Text += Environment.NewLine + "Z = " + z.ToString();

            double a = 5 * Math.Atan(x);

            double b = (1 / 4.0) * Math.Acos(x);

            double c = (x + 3 * Math.Abs(x - y) + Math.Pow(x, 2)) / (Math.Abs(x - y) * z + Math.Pow(x, 2));

            double Y = a - b * c;


            textBox5.Text += Environment.NewLine + "Результат y = " + Y.ToString();


        }
    }
}
