using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C20Ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(Math.Round(nmr_mes.Value, 0));

            if(mes == 1)
            {
                lbl_meses.Text = "Mês: Janeiro";
            }else if(mes == 2)
            {
                lbl_meses.Text = "Mês: Fevereiro";
            }else if(mes == 3)
            { 
                lbl_meses.Text = "Mês: Março";
            }
            else if (mes == 4)
            {
                lbl_meses.Text = "Mês: Abril";
            }
            else if (mes == 5)
            {
                lbl_meses.Text = "Mês: Maio";
            }
            else if (mes == 6)
            {
                lbl_meses.Text = "Mês: Junho";
            }
            else if (mes == 7)
            {
                lbl_meses.Text = "Mês: Julho";
            }
            else if (mes == 8)
            {
                lbl_meses.Text = "Mês: Agosto";
            }
            else if (mes == 9)
            {
                lbl_meses.Text = "Mês: Setembro";
            }
            else if (mes == 10)
            {
                lbl_meses.Text = "Mês: Outubro";
            }
            else if (mes == 11)
            {
                lbl_meses.Text = "Mês: Novembro";
            }
            else if(mes == 12)
            {
                lbl_meses.Text = "Mês: Dezembro";
            }
            else if(mes > 12)
            {
                MessageBox.Show("Número Invalido. Selecione outro número!");
                nmr_mes.Value = 0;
            }
            else
            {
                MessageBox.Show("Selecione um número!");
                nmr_mes.Value = 0;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            nmr_mes.Value = 0;
            lbl_meses.Text = "Mês ";

        }
    }
}
