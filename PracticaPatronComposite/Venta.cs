using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatronComposite {
    public class Venta {
        private int IdVenta = 0;
        
        private List<Componente> productos = new List<Componente>();

        public Venta(int idVenta) : base() {
            this.IdVenta = idVenta;
        }

        public int obtenerIdVenta() {
            return this.IdVenta;
        }

        public void establecerIdVenta() {
            this.IdVenta++;
        }

        public List<Componente> obtenerProductos() {
            return productos;
        }

        public void establecerProductos(List<Componente> productos) {
            this.productos = productos;
        }

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

        public void Agregar(Componente oElemento) {
            productos.Add(oElemento);
        }

        public void Eliminar(Componente oElemento) {
            productos.Remove(oElemento);
        }

        public void imprimirVenta() {
            Console.WriteLine($"No. Venta {IdVenta}\n");
            foreach(Componente producto in productos) {
                Console.WriteLine(producto.obtenerNombre + " $" + producto.obtenerPrecio);
            }
            Console.WriteLine($"Total: ${obtenerTotal}");
        }
    }
}
