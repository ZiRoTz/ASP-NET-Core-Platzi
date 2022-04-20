namespace ASP_NET_y_GIT.Models;
    public class Materias: ObjetoEscuelaBase
    {
        public List<Docentes> Docente { get; set; }
        /* public Grupos Grupos { get; set; } */
        public string GruposID { get; set; }
    }