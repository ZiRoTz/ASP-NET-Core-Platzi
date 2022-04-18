

namespace ASP_NET_y_GIT.Models;
    public class Grupos:ObjetoEscuelaBase
    {
        public List<Materias> Materia{ get; set; }
        public  List<Alumnos> Alumno{ get; set; }
        public List<Docentes> Docente { get; set; }
        public List<Links> Link{get; set;}
        public string Grupo { get; set; }
        public Turnos Turno { get; set; }
        public Semestres Semestre { get; set; }
        public Carreras Carrera { get; set; }
        public string Direccion { get; set; }

        public Grupos (string nombre, Turnos turno, Semestres semestre, Carreras carrera)
        {
            Turno=turno;
            Nombre=nombre;
            
            Semestre=semestre;
            Carrera=carrera;
        }
        public override string ToString()
        {
            return $"Grupo: {Nombre} ";
        }
    }

