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
        public double GetPrecio();
        public void PrecioToString();
        public void ShowIngredientes();
        public List<Ingrediente> GetIngredientes();
        public void Info();

    }
}
