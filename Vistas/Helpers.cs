namespace Vistas
{
	public static class Helpers
	{
		public static void AbrirFormularioHijo(Form formHijo, object pan)
		{
			Panel p = pan as Panel;
			formHijo.TopLevel = false;
			formHijo.FormBorderStyle = FormBorderStyle.None;
			formHijo.Dock = DockStyle.Fill;
			p.Controls.Add(formHijo);
			p.Tag = formHijo;
			formHijo.BringToFront();
			formHijo.Show();
		}
	}
}
