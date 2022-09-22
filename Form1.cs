using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMatrices0_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntMatriz_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[2, 2];
            //Almacenar valores en la matriz 
            valores[0, 0] = 100;
            valores[0, 1] = 50;
            valores[1, 0] = 60;
            valores[1, 1] = 25;

            //Insertar valores de la matriz al listBox
            listBox1.Items.Add(valores[0, 0]);
            listBox1.Items.Add(valores[0, 1]);
            listBox1.Items.Add(valores[1, 0]);
            listBox1.Items.Add(valores[1, 1]);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string[,] Matriz_2 = new string[3, 2];
            Matriz_2[0, 0] = "a";
            Matriz_2[0, 1] = "1";
            Matriz_2[1, 0] = "b";
            Matriz_2[1, 1] = "2";
            Matriz_2[2, 0] = "c";
            Matriz_2[2, 1] = "3";

            listBox2.Items.Add(Matriz_2[0, 0]);
            listBox2.Items.Add(Matriz_2[1, 0]);
            listBox2.Items.Add(Matriz_2[2, 0]);
            listBox2.Items.Add(Matriz_2[0, 1]);
            listBox2.Items.Add(Matriz_2[1, 1]);
            listBox2.Items.Add(Matriz_2[2, 1]);

        }
    }
}
