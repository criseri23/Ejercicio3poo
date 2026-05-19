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
