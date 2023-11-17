﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TacosApp.BD
{
	public class ConexionMySql : Conexion
	{
		private MySqlConnection conexion;
		private string cadenaConexion;


		public ConexionMySql()
		{
			cadenaConexion = "Database=" + database +
				"; DataSource=" + server +
				"; User Id= " + user +
				"; Password=" + password;
			conexion = new MySqlConnection(cadenaConexion);
		}

		public MySqlConnection ObtenerConexion()
		{
			try
			{
				if (conexion.State != System.Data.ConnectionState.Open)
				{
					conexion.Open();
				}

			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}

			return conexion;
		}

		public void CerrarConexion()
		{
			conexion.Close();
		}
	}
}
