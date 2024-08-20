namespace JJOO.Models;

public class Deporte
{
   
    public string Nombre { get; set; }

    public int AñoInicio{ get; set; }
    public string Sinopsis { get; set; }
    public string ImagenSerie { get; set; }

    
}
public class Deportista
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateOnly FechaNacimiento { get; set; }

}

public class Pais
{
    public string Nombre { get; set; }
    public string bandera { get; set; }
}