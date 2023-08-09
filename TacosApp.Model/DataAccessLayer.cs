using Model.Controllers;
using Model.Productos;
using System.Data.SqlClient;

namespace Model
{
	public class DataAccessLayer
	{
		private readonly SqlConnection conn = new("Integrated Security=SSPI;" +
			"							Persist Security Info=False;" +
			"Initial Catalog=TacosAppDB;Data Source=LAPTOP-07CMGR4R\\SQLEXPRESS01");

		private IngredientController? _ingredientController;

		public void InsertIngrediente(Ingrediente ingrediente, string tipoIngrediente)
		{
			try
			{
				conn.Open();
				string query = $@" INSERT INTO {tipoIngrediente} (Nombre, Precio)
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
			List<Ingrediente> ingredientes = new();
			_ingredientController = IngredientController.GetInstance();

			try
			{
				conn.Open();
				string query = $@"SELECT Id, Nombre, Precio FROM {tipoIngrediente}";
				SqlCommand cmd = new(query, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					int Id = int.Parse(reader["Id"].ToString());
					string Nombre = reader["Nombre"].ToString();
					decimal Precio = decimal.Parse(reader["Precio"].ToString());
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
				string query = $@" UPDATE {tipoIngrediente} 
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

		public void DeleteIngrediente(int id, string tipoIngredinte)
		{
			try
			{
				conn.Open();
				string query = $@"DELETE FROM {tipoIngredinte} WHERE ID = @Id";
				SqlCommand cmd = new(query, conn);
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
