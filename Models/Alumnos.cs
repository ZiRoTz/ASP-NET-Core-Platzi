namespace ASP_NET_y_GIT.Models;
    public class Alumnos: ObjetoEscuelaBase
    {
        public Grupos Grupos { get; set; }
        public string GruposId { get; set; }
    }