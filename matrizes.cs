using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] x = new int[3, 4];
        int[,] y = new int[4, 4];
        int[,] z = new int[5, 3];

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    x[linha, coluna] = linha * coluna;
                }
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    label1.Text += x[linha,coluna] + " ";
                }
                label1.Text += "\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    y[linha, coluna] = coluna;
                }
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    label1.Text += y[linha, coluna] + " ";
                }
                label1.Text += "\n";
            }

        }