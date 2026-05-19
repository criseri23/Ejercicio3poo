class Cafetera
{
    private int capacidadMaxima;
    private int cantidadActual;

    public Cafetera(int capacidadMaxima, int cantidadActual)
    {
        this.capacidadMaxima = capacidadMaxima;
        this.cantidadActual = cantidadActual;
    }

    public void LlenarCafetera()
    {
        cantidadActual = capacidadMaxima;
    }

    public void ServirTaza(int cantidad)
    {
        if (cantidad <= cantidadActual)
        {
            cantidadActual = cantidadActual - cantidad;
        }
        else
        {
            Console.WriteLine("No ihay suficiente café");
        }
    }
    public void VaciarCafetera()
    {
  cantidadActual = 0;
    }

 public void MostrarCafe()
    {
     Console.WriteLine("Cantidad actual: " + cantidadActual);
    }
}