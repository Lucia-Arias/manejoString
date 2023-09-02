using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLongitud_Click(object sender, EventArgs e)
        {
            int CantCaracteres = 0;
            CantCaracteres = txtString.Text.Length;

            lblResultado.Text = CantCaracteres.ToString();
        }

        private void btPrueba_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "pepe es un sobrenombre".Length.ToString();
        }

        private void btMayuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.ToUpper();
        }

        private void btMinuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.ToLower();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (txtString.Text.Contains(txtBuscado.Text))
            {
                lblResultado.Text = "SI";
            }
            else
            {
                lblResultado.Text = "NO";
            }
        }

        private void btDeletrear_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            for (int i = 0; i < txtString.Text.Length; i++)
            {
                lblResultado.Text = lblResultado.Text + txtString.Text.Substring(i, 1) + "\r\n";
            }
        }

        private void btExtraer_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtString.Text.Replace(txtBuscado.Text, "");
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            txtBuscado.Text = txtString.Text;
        }

        private void txtBuscado_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Text = txtBuscado.Text;
        }

        
    }
}