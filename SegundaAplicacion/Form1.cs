using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaAplicacion
{
    public partial class Form1 : Form
    {
        VentanaPrincipal ventana;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "LISTO!";
            txtCorreo.Text = "pepe@yahoo.es";
        }

        private void evento_sumar(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado = " +  (double.Parse(num1.Text) + double.Parse(num2.Text)) + "";
        }
        private void algun_evento(object sender, EventArgs e)
        {
            txtCorreo.Text = "Estas listo para sumar?";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Abrir segundo formulario
            if(ventana == null)
                ventana = new VentanaPrincipal(this);
            ventana.Show();
            //btnAbrir.Enabled = false;
        }
    }
}
