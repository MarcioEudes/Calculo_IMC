using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Complementar_Calcular_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            double altura = Convert.ToDouble(txtAltura.Text);

            double peso = Convert.ToDouble(txtPeso.Text);

            double imc = peso / (altura * altura);

            MessageBox.Show($"{imc.ToString("F")}"," Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = string.Empty;

            txtPeso.Text = string.Empty;

        }

        
    }
}
