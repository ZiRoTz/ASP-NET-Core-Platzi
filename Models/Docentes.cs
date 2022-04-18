namespace ASP_NET_y_GIT.Models;
    public class Docentes:ObjetoEscuelaBase
    {
        public string Correo { get; set; }
        public List<Links> Link{get; set;}
    }