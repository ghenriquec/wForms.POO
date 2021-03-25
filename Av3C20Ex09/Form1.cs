using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C20Ex09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomePessoa = txt_Pessoa.Text;
            int diarias = int.Parse(txt_Diarias.Text);
            double diaria = 180.00 , total = 0;

            if(nomePessoa == "")
            {
                MessageBox.Show("Insira seu nome!");
                txt_Pessoa.Focus();
            }
            else if (diarias <= 0)
            {
                MessageBox.Show("Insira a quantidade de diarias!");
                txt_Diarias.Focus();
            }
            else
            {
               if(diarias > 15)
                {
                    total = (diaria * diarias) + (10 * diarias);
                }
               else if (diarias == 15)
                {
                    total = (diaria * diarias) + (12 * diarias);
                }
                else
                {
                    total = (diaria * diarias) + (15 * diarias);
                }
            }

            lbl_Cliente.Text = nomePessoa;
            lbl_nmrDiarias.Text = diarias.ToString();
            lbl_total.Text = total.ToString("C");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Pessoa.Text = "";
            txt_Diarias.Text = "";
            lbl_Cliente.Text = "";
            lbl_nmrDiarias.Text = "";
            lbl_total.Text = "";

        }
    }
}
