using PracticaPatronComposite;

ProductoHoja producto1 = new ProductoHoja("Huevo", 15, "Pz");
ProductoHoja producto2 = new ProductoHoja("Leche 1l", 23.5, "Carton");
ProductoHoja producto3 = new ProductoHoja("Jamon", 20, "gr");

CarritoCompuesto venta = new CarritoCompuesto("Venta");
venta.Agregar(producto1);
venta.Agregar(producto2);
venta.Agregar(producto3);

Console.WriteLine($"Total en el carrito: {venta.Total}");

ProductoHoja producto4 = new ProductoHoja("Chocomilk", 10, "Sobre");
CarritoCompuesto ventaActualizada = new CarritoCompuesto("Venta Actualizada");

ventaActualizada.Agregar(producto4);
ventaActualizada.Agregar(venta);

Console.WriteLine("Se agregó un articulo.");
Console.WriteLine($"Total en el carrito: {ventaActualizada.Total}");