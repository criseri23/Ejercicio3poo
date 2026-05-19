
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

