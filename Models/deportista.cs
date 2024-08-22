public class Deportista
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateOnly FechaNacimiento { get; set; }

public Deportista(){}
public Deportista(string nombre, string apellido, DateOnly fechanacimiento)
{
    Nombre = nombre;
    Apellido = apellido;
    FechaNacimiento = fechanacimiento;
}
}