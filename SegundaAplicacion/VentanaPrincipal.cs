using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SegundaAplicacion
{
    public partial class VentanaPrincipal : Form
    {
        private Form1 form1;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public VentanaPrincipal(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            form1.Visible = true;
            this.Hide();
        }
    }
}
