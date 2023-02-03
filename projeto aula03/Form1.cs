using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_aula03
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

        private void button1_Click(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);
            int Resultado = Valor1 - Valor2;
            txtResultado.Text = Resultado.ToString();
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
