namespace ASP_NET_y_GIT.Models;
public class Escuela : ObjetoEscuelaBase
{
    public int añodeCreación { get; set; }
    public string Universidad { get; set; }
    public string Direccion { get; set; }
    public List<Grupos> Grupo { get; set; }
    public Escuela()
    {

    }
    public override string ToString()
    {
        return $"Nombre: {Nombre} {System.Environment.NewLine} Universidad: {Universidad} {System.Environment.NewLine}";
    }
}