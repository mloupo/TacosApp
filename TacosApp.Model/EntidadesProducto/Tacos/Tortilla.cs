namespace TacosApp.Model.EntidadesProducto.Tacos
{
    public class Tortilla : Ingrediente
    {
        private int cantidadMaxima = 2;
        public Tortilla() { }

        public Tortilla(string nombre, float precio)
        {
            CantidadMaxima = cantidadMaxima;
            Nombre = nombre;
            Precio = precio;
        }

        public Tortilla(string nombre, float precio, int id)
        {
            CantidadMaxima = cantidadMaxima;
            Nombre = nombre;
            Precio = precio;
            Id = id;
        }
    }
}
