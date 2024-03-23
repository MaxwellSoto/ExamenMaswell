using System;
using System.Collections.Generic;

public class Vendedor
{
    private Dictionary<int, string> vendedores = new Dictionary<int, string>();

    // Constructor
    public Vendedor() { }

    // Método para agregar vendedores al diccionario
    public void AgregarVendedor(int codigo, string nombre)
    {
        if (!vendedores.ContainsKey(codigo))
        {
            vendedores.Add(codigo, nombre);
            Console.WriteLine("Vendedor agregado correctamente.");
        }
        else
        {
            Console.WriteLine("El código de vendedor ya existe.");
        }
    }

    // Método para listar vendedores
    public Dictionary<int, string> ListadoVendedores()
    {
        return vendedores;
    }

    // Método para buscar un vendedor por código
    public string BuscarVendedor(int codigo)
    {
        if (vendedores.ContainsKey(codigo))
        {
            return vendedores[codigo];
        }
        else
        {
            return "Vendedor no encontrado";
        }
    }
}

public class Vendedor1 : Ivendedor1
{
    public string NombreVendedor { get; }

    // Constructor con el nombre del vendedor ya asignado
    public Vendedor1(string nombre)
    {
        NombreVendedor = nombre;
    }

    public void VentasContado()
    {
        Console.WriteLine("Ventas al contado");
    }
}

public class Vendedor2 : Ivendedor2
{
    public string NombreVendedor { get; }

    // Constructor con el nombre del vendedor ya asignado
    public Vendedor2(string nombre)
    {
        NombreVendedor = nombre;
    }

    public string VentasCredito()
    {
        return "Ventas a crédito";
    }
}

public interface Ivendedor1
{
    void VentasContado();
}

public interface Ivendedor2
{
    string VentasCredito();
}