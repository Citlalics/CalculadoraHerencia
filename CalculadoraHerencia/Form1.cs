using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraHerencia
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            Suma opsuma = new Suma();
            //opsuma.Valor1 = double.Parse(textBox1.Text);
           // opsuma.Valor2 = double.Parse(textBox2.Text);
            txt3.Text = opsuma.operar(double.Parse(txt1.Text), double.Parse(txt2.Text)).ToString();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {

            Resta opresta = new Resta();// comentario
            //opsuma.Valor1 = double.Parse(textBox1.Text);
            // opsuma.Valor2 = double.Parse(textBox2.Text);
            txt3.Text = opresta.operar(double.Parse(txt1.Text), double.Parse(txt2.Text)).ToString();

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            Multi opmulti = new Multi();// comentario
            //opsuma.Valor1 = double.Parse(textBox1.Text);
            // opsuma.Valor2 = double.Parse(textBox2.Text);
            txt3.Text = opmulti.operar(double.Parse(txt1.Text), double.Parse(txt2.Text)).ToString();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Division opdivi = new Division();// comentario
            //opsuma.Valor1 = double.Parse(textBox1.Text);
            // opsuma.Valor2 = double.Parse(textBox2.Text);
            txt3.Text = opdivi.operar(double.Parse(txt1.Text), double.Parse(txt2.Text)).ToString();

        }
    }
    }

