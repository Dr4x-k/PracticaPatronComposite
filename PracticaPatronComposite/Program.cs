using PracticaPatronComposite;

ProductoHoja producto1 = new ProductoHoja(1, "Huevo", 15, 5, "Pz");
ProductoHoja producto2 = new ProductoHoja(2, "Leche 1l", 23.5, 1, "Carton");
ProductoHoja producto3 = new ProductoHoja(3, "Jamon", 20, 360, "gr");

CarritoCompuesto venta = new CarritoCompuesto(1, "Venta 1");
venta.Agregar(producto1);
venta.Agregar(producto2);
venta.Agregar(producto3);

Console.WriteLine($"Total en el carrito: {venta.Total}");

ProductoHoja producto4 = new ProductoHoja(4, "Chocomilk", 10, 1, "Sobre");
CarritoCompuesto ventaActualizada = new CarritoCompuesto(1, "Venta Actualizada");

ventaActualizada.Agregar(producto4);
ventaActualizada.Agregar(venta);

Console.WriteLine($"Total en el carrito: {ventaActualizada.Total}");