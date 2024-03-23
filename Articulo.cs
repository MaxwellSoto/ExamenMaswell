public class Articulo
{
    // Atributos 
    protected int Codigo { get; set; }
    protected string Nombre { get; set; }
    protected decimal Precio { get; set; }

    // Arreglo para los artículos
    private static Articulo[] articulos = new Articulo[5];
    private static int contadorArticulos = 0;

    // Constructor 
    public Articulo() { }

    // Constructor con todos los parámetros
    public Articulo(int codigo, string nombre, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
    }

    // Método para agregar artículos al arreglo
    public void AgregarArticulo(Articulo articulo)
    {
        if (contadorArticulos < articulos.Length)
        {
            articulos[contadorArticulos] = articulo;
            contadorArticulos++;
            Console.WriteLine("Artículo agregado correctamente.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar más artículos. El límite es de 5 artículos.");
        }
    }

    // Método para consultar un artículo por código
    public Articulo ConsultarArticulo(int codigo)
    {
        foreach (var articulo in articulos)
        {
            if (articulo != null && articulo.Codigo == codigo)
            {
                return articulo;
            }
        }
        return null;
    }

    // Método para borrar un artículo por código
    public void BorrarArticulo(int codigo)
    {
        for (int i = 0; i < articulos.Length; i++)
        {
            if (articulos[i] != null && articulos[i].Codigo == codigo)
            {
                articulos[i] = null;
                Console.WriteLine("Artículo borrado correctamente.");
                return;
            }
        }
        Console.WriteLine("Artículo no encontrado.");
    }
}
