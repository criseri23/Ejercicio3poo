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