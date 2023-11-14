using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronComposite {
    public class CarritoCompuesto : Componente {
        private List<Componente> productos = new List<Componente>();
        
        public double obtenerTotal { 
            get {
                double total = 0;
                foreach (Componente producto in productos) {

                    if (producto.GetType().Name == "CarritoCompuesto")
                        total += ((CarritoCompuesto) producto).obtenerTotal;
                    else
                        total += producto.obtenerPrecio();
                }

                return total;
            }
                
        }


        public void establecerPrecio(double precio) {
            throw new InvalidOperationException();
        }

        public void Agregar(Componente oElemento) {
            productos.Add(oElemento);
        }

        public void Eliminar(Componente oElemento) {
            productos.Remove(oElemento);
        }

        public CarritoCompuesto(string nombre, double precio = 0) : base(nombre, precio) { 
            
        }
    }
}
