
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