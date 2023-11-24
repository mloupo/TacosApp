
using System;
using System.Windows.Forms;

namespace PruebaIdeas
{
    public partial class FormMDI : Form
    {
        private int childFormNumber = 0;
        private FormLogin frmParaCerrar = null;
        public FormMDI(FormLogin login)
        {
            frmParaCerrar =login;   
            InitializeComponent();
            btnCondicionado.Enabled = false;
            btnCondicionado2.Enabled = false;
        }
      


        private void btnDetecta_Click(object sender, EventArgs e)
        {
            int ri = 0;
            double rd = 0.0;
            double CoeficienteSeguridad= 2.5;

            if (txtDato.Text == string.Empty)
                MessageBox.Show("No hay dato");
            else if (int.TryParse(txtDato.Text, out ri))
                MessageBox.Show("Es un numero entero: " + ri);
            else if (double.TryParse(txtDato.Text, out rd))
                MessageBox.Show("Es un numero flotante: " + rd);
            else
                MessageBox.Show("Es una cadena");

            if (txtDato.Text==string.Empty ||!double.TryParse(txtDato.Text, out rd)) {
                MessageBox.Show("Por favor, Introduzca un numero");
                txtDato.Text = "0";
            }
            else {
                double resultado;
                resultado = Convert.ToDouble(txtDato.Text) * CoeficienteSeguridad;
                MessageBox.Show("Resultado: " + resultado.ToString());
            }
        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Desde Form a Consola");
            Console.WriteLine("El textBox dice: {0}", txtDato.Text);
            btnConsola.Text = "Enviado";
        }

        private void btnPide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine("Escribe un mensaje");
            string msg = Console.ReadLine();
            lblMensaje.Text = msg;
            this.Show();
        }

        private void btnAbrirFormHijo_Click(object sender, EventArgs e)
        {
            FormHijo2 frm = FormHijo2.ventanaUnica();
            //frm.Controls["btnInactive"].Enabled = false;
            frm.Show();
        }

        private void textBox_TextChanged(TextBox txtString1, TextBox txtString2, Button btn)
        {
           
            if (txtString1.Text == "" && txtString2.Text == "")
            {
                btn.Enabled = false;
            }
            else if (txtString1.Text == "" && txtString2.Text != "")
            {
                btn.Enabled = false;
            }
            else if (txtString1.Text != "" && txtString2.Text == "")
            {
                btn.Enabled = false;
            }
            else if (txtString1.Text != "" && txtString2.Text != "")
            {
                btn.Enabled = true;
            }
        }
        private void txtString_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(txtString, txtInt, btnCondicionado);
        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(txtString, txtInt, btnCondicionado);
        }

        private void txtBool_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(txtBool, txtDouble, btnCondicionado2);
        }

        private void txtDouble_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(txtBool, txtDouble, btnCondicionado2);
        }

        private void ventana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHijo frm = FormHijo.ventanaUnica();
            frm.MdiParent= this;
            frm.Show();
            frm.BringToFront();

        }

        private void ventana2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHijo2 frm2 = FormHijo2.ventanaUnica();
            frm2.MdiParent = this;
            frm2.Show();
            frm2.BringToFront();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
                tssUsuario.Text= "Martin"; 
        }

        private void ventana3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formIsOpen("FormHijo3") == false)
            { 
                FormHijo3 frm = new FormHijo3();
                frm.MdiParent = this;
                frm.Show();
            }   
        }
            

        bool formIsOpen(string nombre_form)
        {
            foreach (var form_hijo in this.MdiChildren)
            {
                if (form_hijo.Text == nombre_form)
                {
                    form_hijo.BringToFront();
                    return true;
                }
                return false;
            }
            return false;
        }

        private void FormMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmParaCerrar.Close();
        }
    }
}
