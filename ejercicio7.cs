
class Rectangulo
{
  private double ancho;
    private double alto;

    public Rectangulo(double ancho, double alto)
    {
        if (ancho > 0 && alto > 0)
        {
     this.ancho = ancho;
     this.alto = alto;
        }
        else
        {
    Console.WriteLine("Valores inválidos");
        }
    }
    public double Area()
    {
        return ancho * alto;
    }
    
    public double Perimetro()
    {
        return (ancho * 2) + (alto * 2);
    }
}