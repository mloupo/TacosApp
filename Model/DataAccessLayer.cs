using Microsoft.SqlServer.Server;
using Model.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Model
{
	public class DataAccessLayer
	{
		private SqlConnection conn = new ("Integrated Security=SSPI;" +
			"							Persist Security Info=False;" +
			"Initial Catalog=TacosAppDB;Data Source=LAPTOP-07CMGR4R\\SQLEXPRESS01");

		private IngredientController _ingredientController;

		public void InsertIngrediente(Ingrediente ingrediente, string tipoIngrediente)
		{
			try
			{
				conn.Open();
				string query = $@" INSERT INTO {tipoIngrediente}s (Nombre, Precio)
								  VALUES (@Nombre, @Precio)";
				SqlParameter Nombre = new()
				{
					ParameterName = "@Nombre",
					Value = ingrediente.Nombre,
					DbType = System.Data.DbType.String
				};

				SqlParameter Precio = new("@Precio", ingrediente.Precio);
				SqlCommand cmd = new(query, conn);
				cmd.Parameters.Add(Nombre);
				cmd.Parameters.Add(Precio);

				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally { conn.Close(); }	
		}

		public List<Ingrediente> GetIngredientes(string tipoIngrediente)
		{
			List<Ingrediente> ingredientes = new ();
			_ingredientController = IngredientController.GetInstance();

			try
			{
				conn.Open();
				string query = $@"SELECT Id, Nombre, Precio FROM {tipoIngrediente}s";
				SqlCommand cmd = new(query, conn);
				SqlDataReader reader = cmd.ExecuteReader();				

				while (reader.Read())
				{
					int Id = int.Parse(reader["Id"].ToString());
					string Nombre = reader["Nombre"].ToString();
					double Precio = double.Parse(reader["Precio"].ToString());
					Ingrediente ingred = (Ingrediente)_ingredientController.Create(tipoIngrediente, Nombre, Precio, Id);
					ingredientes.Add(ingred);
				}
			}

			catch (Exception)
			{
				throw;
			}

			finally { conn.Close(); }

			return ingredientes;
		}

		public void UpdateIngrediente(Ingrediente ingrediente, string tipoIngrediente)
		{
			try
			{
				conn.Open();
				string query = $@" UPDATE {tipoIngrediente}s 
								SET Nombre = @Nombre,
									Precio = @Precio
								WHERE Id = @Id";

				SqlParameter Id = new("@Id", ingrediente.Id);
				SqlParameter Nombre = new("@Nombre", ingrediente.Nombre);
				SqlParameter Precio = new("@Precio", ingrediente.Precio);

				SqlCommand cmd = new(query, conn);

				cmd.Parameters.Add(Id);
				cmd.Parameters.Add(Nombre);
				cmd.Parameters.Add(Precio);

				cmd.ExecuteNonQuery();

			}
			catch (Exception)
			{
				throw;
			}

			finally { conn.Close(); }
		}

		internal void DeleteIngrediente(int id, string tipoIngredinte)
		{
			try
			{
				conn.Open();
				string query = $@"DELETE FROM {tipoIngredinte}s WHERE ID = @Id";
				SqlCommand cmd = new (query, conn);
				cmd.Parameters.Add(new SqlParameter("@Id", id));
				cmd.ExecuteNonQuery();	
			}
			catch (Exception)
			{
				throw;
			}

			finally { conn.Close(); }
		}
	}
}
