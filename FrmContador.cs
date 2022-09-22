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
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        int counter = 0;
        int val = 0;
        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            val = Convert.ToInt32(lblContador.Text);
            counter = val;
            counter = counter + 1;
            lblContador.Text = counter.ToString();
            if (counter > 0)
            {
                lblContador.ForeColor = Color.Green;
            }
            else if (counter == 0)
            {
                lblContador.ForeColor = Color.Black;
            }
            else
            {
                lblContador.ForeColor = Color.Red;
            }


        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            val = Convert.ToInt32(lblContador.Text);
            counter = val;
            counter = counter - 1;
            lblContador.Text = counter.ToString();
            if (counter > 0)
            {
                lblContador.ForeColor = Color.Green;
            }
            else if (counter == 0)
            {
                lblContador.ForeColor = Color.Black;
            }
            else
            {
                lblContador.ForeColor = Color.Red;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblContador.Text = "0";
            if (counter > 0)
            {
                lblContador.ForeColor = Color.Green;
            }
            else if (counter == 0)
            {
                lblContador.ForeColor = Color.Black;
            }
            else
            {
                lblContador.ForeColor = Color.Red;
            }
        }

        private void FrmContador_Load(object sender, EventArgs e)
        {

        }
    }
}
