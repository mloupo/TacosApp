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
    public partial class FormHijo3 : Form, ITrasladoInfo
    {
        public FormHijo3()
        {
            InitializeComponent();
        }

        public void TrasladoInfo(string nombre)
        {
            txtDato.Text = nombre;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FormModificarDatos frm = new FormModificarDatos(this);
            frm.ShowDialog();

        }
    }
}
