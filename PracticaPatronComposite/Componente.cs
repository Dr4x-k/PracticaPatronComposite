using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronComposite
{
    public abstract class Componente {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }

        public Componente(int id, string nombre, double precio) {
            IdProducto = id;
            NombreProducto = nombre;
            PrecioProducto = precio;
        }
    }
}
