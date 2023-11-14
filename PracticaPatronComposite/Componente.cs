using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronComposite
{
    public abstract class Componente {
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }

        public Componente(string nombre, double precio) {
            NombreProducto = nombre;
            PrecioProducto = precio;
        }

        public string obtenerNombre() {
            return NombreProducto;
        }

        public void establecerNombre(string nombre) {
            this.NombreProducto = nombre;
        }

        public double obtenerPrecio() {
            return PrecioProducto;
        }

        public void establecerPrecio(double precio) {
            this.PrecioProducto = precio;
        }
    }
}
