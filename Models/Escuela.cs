namespace ASP_NET_y_GIT.Models;
public class Escuela : ObjetoEscuelaBase
{
    public int añodeCreación { get; set; }
    public string Universidad { get; set; }
    public string Direccion { get; set; }
    public List<Grupos> Grupo { get; set; }
    public Escuela(string nombre, int año, string uni = "")
    {
        (Nombre, añodeCreación) = (nombre, año);
        Universidad = uni;
    }  //Constructor. Los parametros "vacios" son parámetros opcionales La primera es por tuplas y la que sigue es una simple asignación por parametros
    public Escuela()
    {

    }
    public override string ToString()
    {
        return $"Nombre: {Nombre} {System.Environment.NewLine} Universidad: {Universidad} {System.Environment.NewLine}";
    }
}