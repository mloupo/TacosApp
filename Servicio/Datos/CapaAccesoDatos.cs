﻿using Modelo.Controladores;
using Modelo.EntidadesProducto.Bebidas;
using Modelo.EntidadesProducto.Tacos;
using Modelo.EntidadesUsuario;
using System.Data.SqlClient;

namespace Servicio.Datos
{
	public class CapaAccesoDatos
	{
		private readonly SqlConnection conn = new("Integrated Security=SSPI;" +
			"							Persist Security Info=False;" +
			"Initial Catalog=TacosAppDB;Data Source=LAPTOP-07CMGR4R\\SQLEXPRESS01");

		private ControladorIngrediente? _ingredientController;
		private ControladorBebida? _bebidaController;
		private Bebida _bebida;

		public void InsertarIngrediente(Ingrediente ingrediente, string tipoIngrediente)
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
		public void InsertarBebida(Bebida bebida, string tipoBebida)
		{
			try
			{
				conn.Open();
				string query = $@" INSERT INTO {tipoBebida} (Nombre, Precio)
								  VALUES (@Nombre, @Precio)";
				SqlParameter Nombre = new()
				{
					ParameterName = "@Nombre",
					Value = bebida.Nombre,
					DbType = System.Data.DbType.String
				};

				SqlParameter Precio = new("@Precio", bebida.Precio);
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
		public void InsertarContacto(Contacto contacto)
		{
			try
			{
				conn.Open();
				string query = @"INSERT INTO Contactos (Nombre, Apellido, NroContacto, CorreoElectronico, DireccionEnvio, Contraseña)
								 VALUES (@Nombre, @Apellido, @NroContacto, @CorreoElectronico, @DireccionEnvio, @Contraseña)";

				SqlParameter Nombre = new("@Nombre", contacto.Nombre);
				SqlParameter Apellido = new("@Apellido", contacto.Apellido);
				SqlParameter NroContacto = new("@NroContacto", contacto.NroContacto);
				SqlParameter CorreoElectronico = new("@CorreoElectronico", contacto.CorreoElectronico);
				SqlParameter DireccionEnvio = new("@DireccionEnvio", contacto.DireccionEnvio);
				SqlParameter Contraseña = new("@Contraseña", contacto.Contraseña);

				SqlCommand cmd = new(query, conn);
				cmd.Parameters.Add(Nombre);
				cmd.Parameters.Add(Apellido);
				cmd.Parameters.Add(NroContacto);
				cmd.Parameters.Add(CorreoElectronico);
				cmd.Parameters.Add(Contraseña);
				cmd.Parameters.Add(DireccionEnvio);

				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally { conn.Close(); }
		}


		public List<Ingrediente> ObtenerIngredientes(string tipoIngrediente)
		{
			List<Ingrediente> ingredientes = new();
			_ingredientController = ControladorIngrediente.ObtenerInstancia();

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
					float Precio = float.Parse(reader["Precio"].ToString());
					Ingrediente ingred = _ingredientController.Crear(tipoIngrediente, Nombre, Precio, Id);
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
		public List<Bebida> ObtenerBebidas(string tipoBebida)
		{
			_bebidaController = ControladorBebida.ObtenerInstancia();
			List<Bebida> bebidas = new();
			try
			{
				conn.Open();
				string query = $@"SELECT Id, Nombre, Precio FROM {tipoBebida}";
				SqlCommand cmd = new(query, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					int Id = int.Parse(reader["Id"].ToString());
					string Nombre = reader["Nombre"].ToString();
					float Precio = float.Parse(reader["Precio"].ToString());
					_bebida = _bebidaController.Crear(tipoBebida, Nombre, Precio, Id);
					bebidas.Add(_bebida);
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally { conn.Close(); }
			return bebidas;
		}
		public List<Contacto> ObtenerContactos(string textoObjetivo = null)
		{
			List<Contacto> contactos = new();
			try
			{
				conn.Open();
				string query = @"SELECT Id, Nombre, Apellido, NroContacto, CorreoElectronico, DireccionEnvio, Contraseña 
									FROM Contactos";
				SqlCommand cmd = new();

				if (!string.IsNullOrEmpty(textoObjetivo))
				{
					query += @" WHERE Nombre LIKE @TextoObjetivo 
								OR Apellido LIKE @TextoObjetivo 
								OR NroContacto LIKE @TextoObjetivo 
								OR CorreoElectronico LIKE @TextoObjetivo
								OR DireccionEnvio LIKE @TextoObjetivo";

					cmd = new(query, conn);
					cmd.Parameters.Add(new SqlParameter("@TextoObjetivo", $"%{textoObjetivo}%"));
				}

				cmd.CommandText = query;
				cmd.Connection = conn;


				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					contactos.Add(new Contacto
					{
						Id = int.Parse(reader["Id"].ToString()),
						Nombre = reader["Nombre"].ToString(),
						Apellido = reader["Apellido"].ToString(),
						NroContacto = reader["NroContacto"].ToString(),
						CorreoElectronico = reader["CorreoElectronico"].ToString(),
						DireccionEnvio = reader["DireccionEnvio"].ToString(),
						Contraseña = reader["Contraseña"].ToString()

					});
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally { conn.Close(); }
			return contactos;
		}


		public void ActualizarIngrediente(Ingrediente ingrediente, string tipoIngrediente)
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
		public void ActualizarBebida(Bebida bebida, string tipoBebida)
		{
			try
			{
				conn.Open();
				string query = $@" UPDATE {tipoBebida} 
								SET Nombre = @Nombre,
									Precio = @Precio
								WHERE Id = @Id
				";

				SqlParameter Id = new("@Id", bebida.Id);
				SqlParameter Nombre = new("@Nombre", bebida.Nombre);
				SqlParameter Precio = new("@Precio", bebida.Precio);

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
		public void ActualizarContacto(Contacto contacto)
		{
			try
			{
				conn.Open();
				string query = @"UPDATE Contactos 
									SET Nombre = @Nombre,
										Apellido = @Apellido,
										NroContacto = @NroContacto,
										CorreoElectronico = @CorreoElectronico,
										DireccionEnvio = @DireccionEnvio,
										Contraseña = @Contraseña
									WHERE Id = @Id";

				SqlParameter Id = new("@Id", contacto.Id);
				SqlParameter Nombre = new("@Nombre", contacto.Nombre);
				SqlParameter Apellido = new("@Apellido", contacto.Apellido);
				SqlParameter NroContacto = new("@NroContacto", contacto.NroContacto);
				SqlParameter CorreoElectronico = new("@CorreoElectronico", contacto.CorreoElectronico);
				SqlParameter DireccionEnvio = new("@DireccionEnvio", contacto.DireccionEnvio);
				SqlParameter Contraseña = new("@Contraseña", contacto.Contraseña);

				SqlCommand cmd = new(query, conn);
				cmd.Parameters.Add(Id);
				cmd.Parameters.Add(Nombre);
				cmd.Parameters.Add(Apellido);
				cmd.Parameters.Add(NroContacto);
				cmd.Parameters.Add(CorreoElectronico);
				cmd.Parameters.Add(DireccionEnvio);
				cmd.Parameters.Add(Contraseña);

				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{

				throw;
			}
			finally { conn.Close(); }
		}


		public void EliminarIngrediente(int id, string tipoIngrediente)
		{
			try
			{
				conn.Open();
				string query = $@"DELETE FROM {tipoIngrediente} WHERE ID = @Id";
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
		public void EliminarBebida(int id, string tipoBebida)
		{
			try
			{
				conn.Open();
				string query = $@"DELETE FROM {tipoBebida} WHERE ID = @Id";
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
		public void EliminarContacto(int idContacto)
		{
			try
			{
				conn.Open();
				string query = @"DELETE FROM Contactos WHERE Id = @Id";
				SqlCommand cmd = new(query, conn);
				cmd.Parameters.Add(new SqlParameter("@Id", idContacto));
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
