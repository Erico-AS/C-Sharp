using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradaDados
{
    public partial class EntradaDados : Form
    {
        public EntradaDados()
        {
            InitializeComponent();
        }
        int[,] matrizNumeros = new int[3,3];

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    String valor = Interaction.InputBox("Insira nove elementos e obtenha uma matriz 3X3", "Matrizes");
                    matrizNumeros[i, j] = int.Parse(valor);
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lblResultado.Text += matrizNumeros[i, j] + "";
                }

                lblResultado.Text += "\n";
            }
        }
    }
}
