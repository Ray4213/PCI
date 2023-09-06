using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exArray1
{
    public partial class Form1 : Form
    {

    /*Calcular a média de 10 números digitados pelo usuário.*/
        float[] Num = new float[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                MessageBox.Show("Insira o número!");
            }
            else
            {
                if (i < Num.Length)
                {
                    Num[i] = float.Parse(txtNum.Text);
                    i++;
                    txtNum.Text = "";
                }
                else
                {
                    MessageBox.Show("Limite de números atingido!");
                }
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            float media = 0;
            for(int i = 0; i< Num.Length; i++)
            {
                media = media + Num[i];
            }
            lblMedia.Text = (" A média dos números é: " + media/Num.Length);
        }
    }
}
