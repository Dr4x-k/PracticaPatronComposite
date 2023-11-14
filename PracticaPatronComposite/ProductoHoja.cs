using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronComposite {
    public class ProductoHoja : Componente {
        public string UnidadProducto {  set; get; }
        
        public ProductoHoja(string nombre, double precio, string unidad) : base(nombre, precio)  {
            UnidadProducto = unidad;
        }

        public string obtenerUnidad() {
            return UnidadProducto;
        }

        public void establecerCantidad(int unidad) {
            this.UnidadProducto += unidad;
        }
    }
}
