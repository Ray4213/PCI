using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exArray5
{
    public partial class Form1 : Form
    {
        float[] numeros = new float[10];
        float[] par;
        float[] impar;
        int teste;
        int checkP, checkI;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInse_Click(object sender, EventArgs e)
        {
            /*meu deus do céu eu não aguento mais*/
            if (txtNum.Text=="")
            {
                MessageBox.Show("Insira um número!");
            }
            else
            {
                if (i <numeros.Length)
                {
                    txtNum.Focus();
                    numeros[i] = float.Parse(txtNum.Text);
                    teste = Convert.ToInt32(numeros[i]);
                    listNum.Items.Add(numeros[i]);
                    for (int a = 0; a < numeros.Length; a++)
                    {
                        if ((numeros[a] % 2) == 0)
                        {
                            checkP++;
                        }
                        else
                        {
                            checkI++;
                        }
                    }
                    if (teste != numeros[i] || numeros[i] == 0)
                    {
                        MessageBox.Show("Digite um número inteiro e maior do que zero!");
                    }
                    else
                    {
                        i++;
                        txtNum.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Limite de números atingido");
                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


            Array.Sort(numeros);
            listNum.Items.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {
                listNum.Items.Add(numeros[i]);
            }
            listPar.Sorted = true;
            listImpar.Sorted = true;

        }

        private void btnMostra_Click_1(object sender, EventArgs e)
        {
            par = new float[checkP];
            impar = new float[checkI];
            for (int r = 0; r < numeros.Length; r++)
            {
                if ((numeros[r] % 2) == 0)
                {
                    listPar.Items.Add(numeros[r]);
                }
                else
                {
                    listImpar.Items.Add(numeros[r]);
                }
            }
        }
    }
}
