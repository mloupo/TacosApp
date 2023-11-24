using System;
using System.Windows.Forms;

namespace PruebaIdeas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (chkbRecordar.Checked)
            {
                Properties.Settings.Default.Usuario = txbUsuario.Text;
                Properties.Settings.Default.Contraseña = txbContraseña.Text;
                Properties.Settings.Default.Recordar = chkbRecordar.Checked;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                MessageBox.Show("Datos guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Properties.Settings.Default.Usuario = "";
                Properties.Settings.Default.Contraseña = "";
                Properties.Settings.Default.Recordar = false;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                MessageBox.Show("Datos NO guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FormMDI frm = new FormMDI(this);
            this.Hide();
            frm.Show();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Recordar == true)
            {
                txbUsuario.Text = Properties.Settings.Default.Usuario;
                txbContraseña.Text = Properties.Settings.Default.Contraseña;
                chkbRecordar.Checked = Properties.Settings.Default.Recordar;
            }
            else
            {
                txbUsuario.Text = "";
                txbContraseña.Text = "";
                chkbRecordar.Checked = false;
            }
        }
    }
}
