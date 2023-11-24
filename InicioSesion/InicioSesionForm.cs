﻿using System.Configuration;

namespace InicioSesion
{
	public partial class InicioSesionForm : Form
	{
		public InicioSesionForm()
		{
			InitializeComponent();
			UserTB.Text = ConfigurationManager.ConnectionStrings["user"].ConnectionString;
			PasswordTB.Text = ConfigurationManager.ConnectionStrings["password"].ConnectionString;
			ServerTB.Text = ConfigurationManager.ConnectionStrings["server"].ConnectionString;
			RememberCB.Checked = bool.Parse(ConfigurationManager.ConnectionStrings["remember"].ConnectionString);
		}

		private void ConnectBT_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(ServerTB.Text) ||
				string.IsNullOrWhiteSpace(UserTB.Text) ||
				string.IsNullOrWhiteSpace(PasswordTB.Text))
			{
				ErrorLB.Text = "Must complete all fields";
				return;
			}

			string connString = string.Format(string.Format("Data Source={0};User ID={1};Password={2};",
					ServerTB.Text, UserTB.Text, PasswordTB.Text));

			SqlConnection conn = new SqlConnection(connString);

			try
			{
				conn.Open();

				if (RememberCB.Checked)
				{
					SaveCredentials();
				}
				else
				{
					ClearCredentials();
				}

				/*
					SelectDatabaseFRM selectDatabaseFRM = new SelectDatabaseFRM(conn);
					selectDatabaseFRM.Show();
				*/
				this.Hide();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Connection related error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				conn.Dispose();
			}
		}

		private void ClearCredentials()
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
			connectionStringSection.ConnectionStrings["user"].ConnectionString = String.Empty;
			connectionStringSection.ConnectionStrings["password"].ConnectionString = String.Empty;
			connectionStringSection.ConnectionStrings["server"].ConnectionString = String.Empty;
			connectionStringSection.ConnectionStrings["remember"].ConnectionString = false.ToString();
			config.Save();
			ConfigurationManager.RefreshSection("connectionStrings");
		}

		private void SaveCredentials()
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
			connectionStringSection.ConnectionStrings["user"].ConnectionString = UserTB.Text;
			connectionStringSection.ConnectionStrings["password"].ConnectionString = PasswordTB.Text;
			connectionStringSection.ConnectionStrings["server"].ConnectionString = ServerTB.Text;
			connectionStringSection.ConnectionStrings["remember"].ConnectionString = true.ToString();
			config.Save();
			ConfigurationManager.RefreshSection("connectionStrings");
		}

		private void LoginFRM_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}