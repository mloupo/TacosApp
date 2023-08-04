using Model.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface ITaco
    {
        public decimal GetPrecio();
        public void PrecioToString();
        public void ShowIngredientes();
        public IEnumerable<Ingrediente> GetIngredientes();
        public void Info();

    }
}
