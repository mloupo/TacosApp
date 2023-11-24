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
    public partial class frmEmisor : Form
    {
        Receptor frmReceptor = new Receptor();
        public frmEmisor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            frmReceptor.Mensaje = txbInformacion.Text;            
            frmReceptor.Show();
        }
    }
}
