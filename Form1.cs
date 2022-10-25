using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesenhandoTabelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesenho_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int Linha = 0; Linha < 5; Linha++)
            {

                for (int Coluna = 0; Coluna <= Linha; Coluna++)
                {
                    label1.Text +="*";
                }                
                
                label1.Text += "\n";
            }
        }

        private void btnDesenho3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int Linha = 0; Linha < 5; Linha++)
            {
                for (int Coluna = 0; Coluna >= Linha; Coluna++)
                {
                    label1.Text += "*";
                }
                label1.Text += "\n";
            }
        }
    }
}
