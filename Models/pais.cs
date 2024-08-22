public class Pais
{
    public string Nombre { get; set; }
    public string Bandera { get; set; }
    public DateOnly FechaFundacion { get; set; }

public Pais(){}
public Pais(string nombre, string bandera, DateOnly fechafundacion)
{
    Nombre = nombre;
    Bandera = bandera;
    FechaFundacion = fechafundacion;
}
}