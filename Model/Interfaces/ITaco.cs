using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface ITaco
    {
        public int MyId();
        public double GetPrecio();
        public void PrecioToString();
        public void ShowIngredientes();
        public List<IIngrediente> GetIngredientes();
        public void Info();

    }
}
