using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIdeas
{
    public partial class FormModificarDatos : Form
    {
        public ITrasladoInfo interfaz;
        public FormModificarDatos(ITrasladoInfo padre)
        {
            interfaz = padre;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            interfaz.TrasladoInfo(txtDato.Text);
            this.Close();

        }        
    }
}
