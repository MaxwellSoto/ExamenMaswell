using System;

public static class Menu
{
    public static void MostrarMenu()
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("a-Artículos");
        Console.WriteLine("b-Facturación");
        Console.WriteLine("c-Reporte");
        Console.WriteLine("d-Salir");
    }

    public static void MostrarSubMenuArticulos()
    {
        Console.WriteLine("Seleccione una opción de Artículos:");
        Console.WriteLine("a-Agregar");
        Console.WriteLine("b-Borrar");
        Console.WriteLine("c-Consultar");
    }

    public static void MostrarSubMenuFacturacion()
    {
        Console.WriteLine("Ingrese el código del artículo:");
        // Validar que el código exista y traer los datos del artículo
        Console.WriteLine("Ingrese la categoría asignada:");
        // Validar la categoría con la lista de categorías existentes
        Console.WriteLine("Ingrese el código del vendedor:");
        // Validar que el vendedor exista en la clase de vendedores
        Console.WriteLine("Calculando la venta...");
        // Utilizar la clase Mat para cálculos de la venta
        Console.WriteLine("Venta realizada correctamente.");
    }

    public static void MostrarReporte(Dictionary<int, string> vendedores, List<int> categorias, Articulo[] articulos)
    {
        Console.WriteLine("Reporte de vendedores:");
        foreach (var vendedor in vendedores)
        {
            Console.WriteLine($"Código: {vendedor.Key}, Nombre: {vendedor.Value}");
        }

        Console.WriteLine("Lista de categorías:");
        foreach (var categoria in categorias)
        {
            Console.WriteLine($"Categoría: {categoria}");
        }

        Console.WriteLine("Artículos ingresados:");
        foreach (var articulo in articulos)
        {
            Console.WriteLine($"Código: {articulo.Codigo}, Nombre: {articulo.Nombre}, Precio: {articulo.Precio}");
        }
    }
}