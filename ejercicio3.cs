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