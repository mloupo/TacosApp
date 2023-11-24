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
    public partial class FormHijo : Form
    {
        private static FormHijo instanciaForm = null;
        public static FormHijo ventanaUnica()
        {
            if (instanciaForm == null)
            {
                instanciaForm= new FormHijo();
                return instanciaForm;
            }
            return instanciaForm;
        }

        private FormHijo()
        {
            InitializeComponent();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnInactive, true);
        }

        private void ActivarBoton(Button btn, bool estado) 
        {
            if (estado)
                btn.Enabled = true;
            else 
                btn.Enabled = false;
        }

        private void FormHijo_Load(object sender, EventArgs e)
        {
            string[] usuario = new string[] {"jose", "manuel", "pedro", "alberto", "cristian", "lucas", "federico" };
            foreach (var item in usuario)
            {
                lvOrigen.Items.Add(item);
            }
        }

        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable ciudadPeru = new DataTable();
            ciudadPeru.Columns.Add("Ciudad");
            
            DataRow row = ciudadPeru.NewRow();
            row["Ciudad"] = "Lima";
            ciudadPeru.Rows.Add(row);

            DataRow row1 = ciudadPeru.NewRow();
            row1["Ciudad"] = "Cajamarca";
            ciudadPeru.Rows.Add(row1);

            DataRow row2 = ciudadPeru.NewRow();
            row2["Ciudad"] = "Piura";
            ciudadPeru.Rows.Add(row2);

            DataRow row3 = ciudadPeru.NewRow();
            row3["Ciudad"] = "Tumbes";
            ciudadPeru.Rows.Add(row3);

            if (cmbPaises.SelectedIndex == 5)
            {
                cmbCiudades.DataSource = ciudadPeru;
                cmbCiudades.DisplayMember = "ciudad";
            }

            if (cmbPaises.SelectedIndex == 1)
            {
                cmbCiudades.DataSource = null;               
            }

        }

        private void btn1a1_Click(object sender, EventArgs e)
        {
            if (lvOrigen.Items.Count > 0 /*&& lvOrigen.SelectedItems[0].Text!=null*/)
            {                 
                    lvDestino.Items.Add(lvOrigen.SelectedItems[0].Text);
                    lvOrigen.Items.Remove(lvOrigen.SelectedItems[0]);                
            }
            
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvOrigen.Items)
            {
                lvDestino.Items.Add(item.Text);
            }
            lvOrigen.Items.Clear();
        }

        private void FormHijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaForm = null;
        }
    }
}
