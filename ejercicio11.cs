class Program
{
    static void Main(string[] args)
    {
        Termometro t1 = new Termometro(25);
        Termometro t2 = new Termometro(10);

        Console.WriteLine(t1.Fahrenheit());
        Console.WriteLine(t1.Kelvin());

        Reloj r1 = new Reloj(10, 30, 20);
        Reloj r2 = new Reloj(22, 15, 50);

        r1.MostrarHora();
        r2.MostrarHora();

        Cuenta c1 = new Cuenta("Ana", 1000);
        Cuenta c2 = new Cuenta("Luis", 500);

        c1.Depositar(200);
        c1.Retirar(100);

        Console.WriteLine(c1.Saldo);

        Libro l1 = new Libro("Harry Potyter", "Rowling", "123", 400);
        Libro l2 = new Libro("El Principito", "Saint Exupery", "456", 100);

        Console.WriteLine(l1.EsLargo());

     Producto p1 = new Producto("1", "Myyouse", 2000);
        Producto p2 = new Producto("2", "Teclado", 5000);

        p1.AplicarDescuento(10);
        p1.MostrarPrecio();

        CalculadoraPasos cal1 = new CalculadoraPasos("Juan", 10000);
        CalculadoraPasos cal2 = new CalculadoraPasos("Maria", 8000);

        cal1.RegistrarPasos(12000);

        Console.WriteLine(cal1.ObjetivoCumplido());

        Rectangulo rec1 = new Rectangulo(5, 3);
        Rectangulo rec2 = new Rectangulo(10, 2);

        Console.WriteLine(rec1.Area());
        Console.WriteLine(rec1.Perimetro());

        Usuario u1 = new Usuario("juan123", "abc", "juan@gmail.com");
        Usuario u2 = new Usuario("maria22", "123", "maria@gmail.com");

        u1.CambiarPassword("abc", "nueva123");

        Cafetera caf1 = new Cafetera(1000, 500);
        Cafetera caf2 = new Cafetera(2000, 1500);

        caf1.LlenarCafetera();
        caf1.ServirTaza(200);
        caf1.MostrarCafe();

   Estudiante e1 = new Estudiante("Pedro", 7, 8, 6);
        Estudiante e2 = new Estudiante("Lucia", 4, 5, 3);
        Console.WriteLine(e1.CalcularPromedio());
        Console.WriteLine(e1.EstadoFinal());
    }
}