using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using TacosApp.BD;
using TacosApp.Modelo;

namespace TacosApp.Objects
{
	internal class ProductoConsultas
	{
		private ConexionMySql mConexion;
		private List<Producto> mProductos;

		public ProductoConsultas()
		{
			mConexion = new ConexionMySql();
			mProductos = new List<Producto>();
		}

		public bool agregarProducto(Producto mProducto)
		{
			string INSERT = "INSERT INTO producto (nombre, precio, cantidad, imagen)" + " values (@nombre, @precio, @cantidad, @imagen);";

			MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.ObtenerConexion());
			mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nombre));
			mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
			mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.cantidad));
			mCommand.Parameters.Add(new MySqlParameter("@imagen", mProducto.imagen));

			return mCommand.ExecuteNonQuery() > 0;
		}

		public bool modificarProducto(Producto mProducto)
		{
			string UPDATE = " UPDATE producto " +
				"SET nombre = @nombre, " +
				"precio = @precio, " +
				"cantidad = @cantidad, " +
				"imagen = @imagen " +
				"WHERE id = @id";

			MySqlCommand mCommand = new MySqlCommand(UPDATE, mConexion.ObtenerConexion());
			mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nombre));
			mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
			mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.cantidad));
			mCommand.Parameters.Add(new MySqlParameter("@imagen", mProducto.imagen));
			mCommand.Parameters.Add(new MySqlParameter("@id", mProducto.id));

			return mCommand.ExecuteNonQuery() > 0;
		}

		public bool eliminarProducto(Producto mProducto)
		{
			string DELETE = " DELETE FROM producto WHERE id=@id";
			MySqlCommand mCommand = new MySqlCommand(DELETE, mConexion.ObtenerConexion());
			mCommand.Parameters.Add(new MySqlParameter("@id", mProducto.id));
			return mCommand.ExecuteNonQuery() > 0;
		}

		public List<Producto> consultarProductos(string filtro)
		{
			string CONSULTA = "SELECT * FROM producto";

			MySqlDataReader mReader = null;
			Producto mProducto;
			try
			{
				if (filtro != "")
				{
					CONSULTA += " WHERE " +
						"id LIKE '%" + filtro + "%' OR " +
						"nombre LIKE '%" + filtro + "%' OR " +
						"precio LIKE '%" + filtro + "%' OR " +
						"cantidad LIKE '%" + filtro + "%';";
				}

				MySqlCommand mCommand = new MySqlCommand(CONSULTA);
				mCommand.Connection = mConexion.ObtenerConexion();
				mReader = mCommand.ExecuteReader();

				while (mReader.Read())
				{
					mProducto = new Producto();
					mProducto.id = mReader.GetInt16("id");
					mProducto.nombre = mReader.GetString("nombre");
					mProducto.precio = mReader.GetInt16("precio");
					mProducto.cantidad = mReader.GetInt16("cantidad");
					mProducto.imagen = (byte[])mReader.GetValue(4);
					mProductos.Add(mProducto);
				}
				mReader.Close();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				mConexion.CerrarConexion();
			}

			return mProductos;
		}
	}
}
