

namespace ASP_NET_y_GIT.Models;
    public class Grupos:ObjetoEscuelaBase
    {
        /* public List<Materias> Materia{ get; set; } */
        /* public  List<Alumnos> Alumno{ get; set; } */
        /* public List<Docentes> Docente { get; set; } */
        /* public List<Links> Link{get; set;} */
        public Turnos Turno { get; set; }
        public Semestres Semestre { get; set; }
        public Carreras Carrera { get; set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }

        public override string ToString()
        {
            return $"Grupo: {Nombre} ";
        }
    }

