using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaMultiplicacion;
using BibliotecaResta;
using BibliotecaSuma;
using Division;
using Libreria;

namespace NachoOpera
{
   
    public partial class frmPrincipal : Form
    {
        long  resultado;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
             
             resultado =BibliotecaSuma.Class1.Sumar(int.Parse(txtNum1.Text),int.Parse(txtNum2.Text));
            lblResultado.Text = resultado.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            resultado=BibliotecaResta.Class1.Resta(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text));
            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            resultado = BibliotecaMultiplicacion.Class1.Multiplicacion(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text));
            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
           
            if (int.Parse(txtNum2.Text) == 0)
            {
                MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultado = Division.Class1.Dividir(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text));
                lblResultado.Text = resultado.ToString();
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResultado.Text = "0";
        }
    }
}
