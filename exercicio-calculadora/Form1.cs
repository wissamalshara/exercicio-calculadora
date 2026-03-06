using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numero1, numero2, div;

            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);

            div = numero1/numero2;

            label3.Text = "Resultado: " + div.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, soma;

            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);

            soma = numero1 + numero2;

            label3.Text = "Resultado: " + soma.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero1, numero2, sub;

            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);

            sub = numero1 - numero2;

            label3.Text = "Resultado: " + sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double numero1, numero2, multi;

            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);

            multi = numero1 * numero2;

            label3.Text = "Resultado: " + multi.ToString();
        }
    }
}
