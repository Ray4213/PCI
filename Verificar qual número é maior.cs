using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exArray2
{
    public partial class Form1 : Form
    {
        int[] Numeros = new int[5];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                MessageBox.Show("Insira um número");
            }
            else
            {
                if (i < Numeros.Length)
                {
                    Numeros[i] = int.Parse(txtNum.Text);
                    i++;
                    txtNum.Text = "";
                }
                else
                {
                    MessageBox.Show("Limite de números atingido!");
                }
            }
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int maior;
            maior = Numeros[0];
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] > maior)
                {
                    maior = Numeros[i];
                }
            }
            lblMaior.Text = ("O maior número é: " + maior);
        }
    }
}
