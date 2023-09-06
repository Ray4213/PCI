using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exArray3
{
    public partial class Form1 : Form
    {
      /*Solicite ao usuário 10 idades e apresente quantas são maiores de idade e quantas são menores de idade*/

        int[] idade = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text == "")
            {
                MessageBox.Show("Insira uma idade!");
            }
            else
            {
                if (i < idade.Length)
                {
                    idade[i] = int.Parse(txtIdade.Text);
                    i++;
                    txtIdade.Text = "";
                }
                else
                {
                    MessageBox.Show("Limite de cadastro atingido!");
                }
            }
            
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            int maior = 0;
            int menor = 0;

            for(int i = 0; i<idade.Length;i++)
            {
                if (idade[i]<18)
                {
                    menor++;
                }
                else
                {
                    maior++;
                }
            }
            lblMaior.Text = ("Maiores de idade: " + maior);
            lblMenor.Text = ("Menores de idade: " + menor);
        }
    }
}
