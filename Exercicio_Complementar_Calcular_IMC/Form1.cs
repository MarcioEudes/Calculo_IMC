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

            string classificacao = string.Empty;

            if(imc <= 18.5)
            {
                classificacao = "Baixo Peso";
            }
            else if(imc >= 18.6 && imc <= 24.9)
            {
                classificacao = "Peso Normal";
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else if(imc >= 30 && imc <= 34.9)
            {
                classificacao = "Obesidade grau I";
            }
            else if(imc >= 35 && imc <= 39.9)
            {
                classificacao = "Obesidade garu II";
            }
            else
            {
                classificacao = "Obesidade grau III";
            }

            MessageBox.Show($"{imc.ToString("F")}\n\n{classificacao} " , "Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = string.Empty;

            txtPeso.Text = string.Empty;

        }

        
    }
}
