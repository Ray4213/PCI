using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exArray4
{
    public partial class lbNomes : Form
    {
      /*Solicite ao usuário 5 nomes e apresente de forma invertida(do último para o primeiro)*/

        string[] nomes = new string[5];
        int i = 0;
        public lbNomes()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Insira um nome!");
            }
            else
            {
                if (i < nomes.Length)
                {
                    nomes[i] = txtNome.Text;
                    i++;
                    txtNome.Text = "";
                }
                else
                {
                    MessageBox.Show("Limite de cadastro atingido!");
                }
            }
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
           
            for (int i = nomes.Length -1; i>= 0; i--)
            {
                lisNomes.Items.Add(nomes[i]);
            }
        }
    }
}

