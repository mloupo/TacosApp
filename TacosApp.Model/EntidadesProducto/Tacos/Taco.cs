using Model.Interfaces;

namespace TacosApp.Model.EntidadesProducto.Tacos
{
    public class Taco : ITaco
    {
        public int Id { get; private set; }
        private List<IIngrediente>? _ingredientesTaco;
        public readonly DateTime CreadoEn;

        public Taco() { }

        public Taco(int id)
        {
            CreadoEn = DateTime.Now;
            Id = id;
        }

        public Taco(int id, IEnumerable<IIngrediente> lista)
        {
            Id = id;
            CreadoEn = DateTime.Now;
            _ingredientesTaco = new List<IIngrediente>(lista);
        }
        public Taco(IEnumerable<IIngrediente> lista)
        {
            CreadoEn = DateTime.Now;
            _ingredientesTaco = new List<IIngrediente>(lista);
        }

        public float ObtenerPrecio()
        {
            float precioTaco = 0;
            foreach (Ingrediente ingred in _ingredientesTaco)
            {
                precioTaco += ingred.Precio;
            }
            return precioTaco;
        }

        public void PrecioConsola()
        {
            float precioTaco = ObtenerPrecio();
            Console.WriteLine(string.Format("\nTotal a Pagar: {0,40:C}", precioTaco));
        }

        public void MostrarIngredientes()
        {
            foreach (Ingrediente ingrediente in _ingredientesTaco)
            {
                Console.WriteLine(ingrediente.ToString());
                // agregar al panel de detalles de taco (ingredientes)
            }
        }

        public IEnumerable<IIngrediente> ObtenerIngredientes() => _ingredientesTaco;

        public void InfoConsola()
        {
            Console.WriteLine($"\nTaco Nro: {Id}");
            Console.WriteLine($"Creado: {CreadoEn,50:D}");
            MostrarIngredientes();
            PrecioConsola();
        }
    }
}
