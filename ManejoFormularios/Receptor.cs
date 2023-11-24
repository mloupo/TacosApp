using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoFormularios
{
    public partial class Receptor : Form
    {
        private string mensaje;
        public Receptor()
        {
            InitializeComponent();            
        }

        public string Mensaje 
        {
            set 
            {
                mensaje = value;
                lblInformacion.Text = mensaje;
            }
            get 
            {
                return mensaje;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mensaje = txbMensaje.Text;
            this.Close();
        }
    }
}
