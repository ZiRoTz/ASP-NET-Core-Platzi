using Microsoft.EntityFrameworkCore;

namespace ASP_NET_y_GIT.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Materias> Materia { get; set; }
        public DbSet<Alumnos> Alumno { get; set; }
        public DbSet<Grupos> Grupo { get; set; }
        public DbSet<Docentes> Docente { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.añodeCreación = 1997;
            escuela.ID = Guid.NewGuid().ToString();
            escuela.Nombre = "ESIME CULHUACAN";
            escuela.Universidad = "Instituto Politécnico Nacional";

            
            //Cargar cursos de la escuela
            var grupos = CargarGrupos(escuela);
            //X cada curso cargar asignaturas
            var materias = CargarMaterias(grupos);
            //x cada curso cargar alumnos
            var alumnos = CargarAlumnos(grupos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Grupos>().HasData(grupos.ToArray());
            modelBuilder.Entity<Materias>().HasData(materias.ToArray());
            modelBuilder.Entity<Alumnos>().HasData(alumnos.ToArray());
        }

        private static List<Materias> CargarMaterias(List<Grupos> grupos)
        {
            var listaCompletaMaterias = new List<Materias>();
            foreach (var grupo in grupos)
            {

                var tmpList = new List<Materias>
                {
                   new Materias{Nombre="Modulación Digital",                        ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Teoría de Control Analógico",               ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Sistemas Operativos",                       ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Arquitectura de Computadoras",              ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Ingeniería de Software",                    ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Met. de la Inv. O Top. Selec de la Ing.I",  ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Probabilidad y Estadística",                ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Análisis de señales Analógicas",            ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Análisis de Algoritmos",                    ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Compiladores",                              ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Organización de Computadoras",              ID=Guid.NewGuid().ToString(),GruposID=grupo.ID},
                   new Materias{Nombre="Humanidades IV",                            ID=Guid.NewGuid().ToString(),GruposID=grupo.ID}
                };
                listaCompletaMaterias.AddRange(tmpList);
                /* grupo.Materia = listaCompletaMaterias; */
                listaCompletaMaterias = listaCompletaMaterias.OrderBy((Ma) => Ma.ID).Take(6).ToList();
            }
            return listaCompletaMaterias;
        }

        private static List<Grupos> CargarGrupos(Escuela escuela)
        {
            return new List<Grupos>()        //Lista genérica
            {
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CV1",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CV2",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CV3",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CV4",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CV5",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CV6",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CM1",Turno=Turnos.Mañana
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CM2",Turno=Turnos.Mañana
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CM3",Turno=Turnos.Mañana
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CM4",Turno=Turnos.Mañana
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CM5",Turno=Turnos.Mañana
                },
                new Grupos(){
                    Semestre=Semestres.Sexto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="6CM6",Turno=Turnos.Mañana
                },
                new Grupos(){
                    Semestre=Semestres.Quinto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="5CV1",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Quinto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="5CV2",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Quinto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="5CV3",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Quinto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="5CV4",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Quinto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="5CV5",Turno=Turnos.Tarde
                },
                new Grupos(){
                    Semestre=Semestres.Quinto,ID=Guid.NewGuid().ToString(), EscuelaId=escuela.ID,Nombre="5CV6",Turno=Turnos.Tarde
                }
            };
        }

        private List<Alumnos> CargarAlumnos (List<Grupos> grupos)
        {
            var listaAlumnos = new List<Alumnos>();

            Random rnd = new Random();
            foreach (var grupo in grupos)
            {
                int cantRandom = rnd.Next (5,20);
                var tmplist = GenerarAlumnos(grupo, cantRandom); 
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }
    private List<Alumnos> GenerarAlumnos(
        Grupos grupos,
        int cantidad
    )
    {
        string[] nombre1 = { "Alondra", "David", "Ricardo", "Itzel", "José", "Aranza", "Isaac", "Isaace" };
        string[] apellido1 = { "Martinez", "Rodriguez", "Gonzalez", "Aguilar", "Lopez", "Maduro", "Bautista", "Gomez" };
        string[] apellido2 = { "Ruiz", "Salas", "Corona", "Hernández", "Juarez", "Jiménez", "Ramírez", "Uribe" };

        //Producto cartesiano de los 3 arreglos. Utilizando LinQ para generar este producto
        //y no utilizar el foreach para la concatenación de los arreglos

        var listaAlumnos = from n1 in nombre1
                           from a1 in apellido1
                           from a2 in apellido2
                           select new Alumnos { GruposId = grupos.ID, Nombre = $"{n1} {a1} {a2}", ID = Guid.NewGuid().ToString() };



        return listaAlumnos.OrderBy((al) => al.ID).Take(cantidad).ToList();
    }
}
}