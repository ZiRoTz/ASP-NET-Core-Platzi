namespace ASP_NET_y_GIT.Models;
    public class Docentes:ObjetoEscuelaBase
    {
        public string Correo { get; set; }
        public List<Links> Link{get; set;}
        public Alumnos Alumnos { get; set; }
        public string AlumnosID { get; set; }
    }