using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C20Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string nomeproduto = txt_Nome.Text;
            double valorproduto = double.Parse(txt_Valor.Text), calculo = 0, dolar = 0;
            int quantidade = Convert.ToInt32(Math.Round(nmrd_quantidade.Value, 0));

            calculo = quantidade * valorproduto;
            dolar = calculo * 5.51;

            lbl_Valor.Text = "O valor atual a ser pago é de: " + dolar;

            txt_Nome.Text = "";
            txt_Valor.Text = "";
            nmrd_quantidade.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_Nome.Text = "";
            txt_Valor.Text = "";
            nmrd_quantidade.Text = "";
            lbl_Valor.Text = "";
        }
    }
}
