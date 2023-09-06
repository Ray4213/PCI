using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exArray6
{
    public partial class Form1 : Form
    {
        float[] notas = new float[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNota.Text == "")
            {
                MessageBox.Show("Insira uma nota válida!");
            }
            else
            {
                if (i < notas.Length)
                {
                    notas[i] = float.Parse(txtNota.Text);
                    i++;
                    txtNota.Text = "";
                }
                else
                {
                    MessageBox.Show("Limite de cadastro de notas atingido!");
                }
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            float media = 0;
            int contagem = 0;

            for(int i = 0; i < notas.Length; i++)
            {
                media += notas[i];
            }
            media = media / notas.Length;
            lblMedia.Text = ("Média da Turma: " + media);
            for (int j = 0; j < notas.Length; j++)
            {
                if (notas[j] > media)
                {
                    contagem++;
                }
            }
            lblCalc.Text = ("Quantidade de Alunos que atingiram a média da Turma: " + contagem);
        }
    }
}
