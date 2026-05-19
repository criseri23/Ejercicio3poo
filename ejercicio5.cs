//producttttooo ejercicio
class Producto
{
    private string codigo;
  private string nombre;
  private double precio;
 public Producto(string codigo, string nombre, double precio)
    {
        this.codigo = codigo;    this.nombre = nombre;
        this.precio = precio;
    }
    public void AplicarDescuento(double porcentaje)
    {
        precio = precio - (precio * porcentaje / 100);
    }
    public void MostrarPrecio()
    {
        Console.WriteLine("Precio: " + precio);
    }
}