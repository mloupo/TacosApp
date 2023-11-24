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
    public partial class FormHijo2 : Form
    {
        private static FormHijo2 instanciaForm = null;
        public static FormHijo2 ventanaUnica()
        {
            if (instanciaForm == null)
            {
                instanciaForm = new FormHijo2();
                return instanciaForm;
            }
            return instanciaForm;
        }
        private FormHijo2()
        {
            InitializeComponent();
        }

        private void FormHijo2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Dirección");
            DataRow dr = dt.NewRow();
            dr[0] = "Carlos Guzman";
            dr[1] = 30;
            dr[2] = "Calle los pinos 135";
            dt.Rows.Add(dr);
            DataRow dr2 = dt.NewRow();
            dr2[0] = "Pedro Aquino";
            dr2[1] = 40;
            dr2[2] = "Av. Brasil 2340";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3[0] = "Juan Guzman";
            dr3[1] = 34;
            dr3[2] = "Calle los pinos 300";
            dt.Rows.Add(dr3);

            dgvParticipantes.DataSource = dt;

        }

        private void dgvParticipantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string nuevo_nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nuevo Nombre", "Cambio de Nombre");

                dgvParticipantes.Rows[e.RowIndex].Cells[0].Value = nuevo_nombre;
            }
        }

        private void FormHijo2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //para que cuando cierre el formulario no se genere una excepcion buscando un formulario diposed
            instanciaForm = null;
        }
    }
}
