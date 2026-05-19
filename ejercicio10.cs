
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