using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronComposite {
    public class CarritoCompuesto : Componente {
        private List<Componente> productos = new List<Componente>();
        
        public double Total { 
            get {
                double total = 0;
                foreach (var producto in productos) {

                    if (producto.GetType().Name == "CarritoCompuesto")
                        total += ((CarritoCompuesto) producto).Total;
                    else
                        total += producto.PrecioProducto;
                }

                return total;
            }
                
        }

        public void Agregar(Componente oElemento) {
            productos.Add(oElemento);
        }

        public void Eliminar(Componente oElemento) {
            productos.Remove(oElemento);
        }

        public CarritoCompuesto(int id, string nombre, double precio = 0) : base(id, nombre, precio) { 
            
        }
    }
}
