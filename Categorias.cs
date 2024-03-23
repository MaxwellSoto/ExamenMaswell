using System;
using System.Collections.Generic;

public class Categoria
{
    public virtual void Promocion()
    {
        Console.WriteLine("Descuentos y promociones");
    }

    public List<int> Categorias { get; set; }

    public Categoria()
    {
        // Inicializar la lista
        Categorias = new List<int>() { 1, 2, 3 };
    }

    public void ListadoCategorias()
    {
        Console.WriteLine("Listado de categorías:");
        foreach (var categoria in Categorias)
        {
            Console.WriteLine($"Categoría: {categoria}");
        }
    }

    public bool ExisteCategoria(int categoria)
    {
        return Categorias.Contains(categoria);
    }
}

public class Categoria1 : Categoria
{
    public override void Promocion()
    {
        Console.WriteLine("Descuento de 15%");
    }
}

public class Categoria2 : Categoria
{
    public override void Promocion()
    {
        Console.WriteLine("Promoción dos por uno");
    }
}

public class Categoria3 : Categoria
{
    public override void Promocion()
    {
        Console.WriteLine("Todo a mitad de precio");
    }
}