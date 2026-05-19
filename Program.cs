// PRIMERRRRR EJERVICIO
class Termometro
{
    private double celsius;

 public Termometro(double celsius)
 {
        Celsius = celsius;  }
  public double Celsius
    {
      get { return celsius; }
     set
        {
     if (value >= -273.15)
            {
                celsius = value;
            }     else
            {
                Console.WriteLine("Temperatura inválida");
            }
        }
    }

    public double Fahrenheit()
    {     return (celsius * 9 / 5) + 32;
    }

  public double Kelvin()
    {
        return celsius + 273.15;
  }
}

//EJERCICIO RELOJ
class Reloj
{
 private int hora;
 private int minutos;
    private int segundos;
    public Reloj(int hora, int minutos, int segundos)
    {
     if (hora >= 0 && hora <= 23)
        {      this.hora = hora;
     }

        if (minutos >= 0 && minutos <= 59)
     {
            this.minutos = minutos;
     }

     if (segundos >= 0 && segundos <= 59)
        {
            this.segundos = segundos;
        }
    }

    public void MostrarHora()
    {
        Console.WriteLine(hora + ":" + minutos + ":" + segundos);
    }
}
//ejercicio cuenta
class Cuenta
{
  private string titular;
   private double saldo;

    public Cuenta(string titular, double saldo)
    {
     this.titular = titular;
     this.saldo = saldo;
    }

    public string Titular
    {
     get { return titular; }
      set { titular = value; }
    }

    public double Saldo
    {
        get { return saldo; }
    }

   public void Depositar(double cantidad)
    {
        saldo = saldo + cantidad;
    }

    public void Retirar(double cantidad)
    {
        if (cantidad <= saldo)
        {
            saldo = saldo - cantidad;
        }
        else
        {
            Console.WriteLine("No hay suficiente saldo");
        }
    }
}
//librooo ejercicio

class Libro
{
 private string titulo;
  private string autor;
 private string isbn;
 private int numeroPaginas;

  public Libro(string titulo, string autor, string isbn, int numeroPaginas)
    {
     this.titulo = titulo;
        this.autor = autor;
        this.isbn = isbn;
        this.numeroPaginas = numeroPaginas;
    }

    public bool EsLargo()
    {
        return numeroPaginas > 300;
    }
}
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
class CalculadoraPasos
{
   private string nombreUsuario;
  private int metaDiaria;
 private int pasosTotales;

    public CalculadoraPasos(string nombreUsuario, int metaDiaria)
    {
        this.nombreUsuario = nombreUsuario;
      this.metaDiaria = metaDiaria;
     pasosTotales = 0;
    }

    public void RegistrarPasos(int pasos)
    {
        pasosTotales = pasosTotales + pasos;
    }

    public bool ObjetivoCumplido()
    {
    return pasosTotales >= metaDiaria;
    }
}

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

class Usuario
{
   private string nombreDeUsuario;
    private string password;
    private string email;

    public Usuario(string nombreDeUsuario, string password, string email)
    {
        this.nombreDeUsuario = nombreDeUsuario;
        this.password = password;
        this.email = email;
    }

    public void CambiarPassword(string antigua, string nueva)
    {
        if (antigua == password)
        {
            password = nueva;
            Console.WriteLine("Contraseña cambiada");
  
        
        
        
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta");
        }
    }
}

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

class Estudiante
{
    private string nombre;
    private double[] notas = new double[3];

    public Estudiante(string nombre, double n1, double n2, double n3)
    {
        this.nombre = nombre;
     notas[0] = n1;
        notas[1] = n2;
        notas[2] = n3;
    }

    public double CalcularPromedio()
    {
        return (notas[0] + notas[1] + notas[2]) / 3;
    }

    public string EstadoFinal()
    {
        if (CalcularPromedio() >= 6)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }
}

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