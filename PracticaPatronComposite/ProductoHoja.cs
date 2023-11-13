using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronComposite {
    public class ProductoHoja : Componente {
        public int CantidadProducto {  get; set; }
        public string UnidadProducto {  set; get; }
        
        public ProductoHoja(int id, string nombre, double precio, int cantidad, string unidad) : base(id, nombre, precio)  {
            CantidadProducto = cantidad;
            UnidadProducto = unidad;
        }
    }
}
