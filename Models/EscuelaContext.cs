using Microsoft.EntityFrameworkCore;

namespace ASP_NET_y_GIT.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet <Escuela> Escuelas{ get; set; }
        public DbSet <Materias> Materia{ get; set; }
        public DbSet <Alumnos> Alumno{ get; set; }
        public DbSet <Grupos> Grupo{ get; set; }
        public DbSet <Docentes> Docente{ get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext>options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela= new Escuela();
            escuela.añodeCreación = 1997;
            escuela.ID=Guid.NewGuid().ToString();
            escuela.Nombre="ESIME CULHUACAN";
            escuela.Universidad="Instituto Politécnico Nacional";
            escuela.Direccion="Culhuacan";

            modelBuilder.Entity<Escuela>().HasData(escuela); 

            modelBuilder.Entity<Materias>().HasData(

                   new Materias{Nombre="Modulación Digital",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Teoría de Control Analógico",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Sistemas Operativos",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Arquitectura de Computadoras",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Ingeniería de Software",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Met. de la Inv. O Top. Selec de la Ing.I",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Probabilidad y Estadística",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Análisis de señales Analógicas",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Análisis de Algoritmos",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Compiladores",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Organización de Computadoras",
                                ID=Guid.NewGuid().ToString()},
                   new Materias{Nombre="Humanidades IV",
                                ID=Guid.NewGuid().ToString()}
                                );
            modelBuilder.Entity<Alumnos>().HasData(GenerarAlumnos().ToArray());
        }
        private List<Alumnos> GenerarAlumnos()
        {
            string[] nombre1 = { "Alondra", "David", "Ricardo", "Itzel", "José", "Aranza", "Isaac", "Isaace" };
            string[] apellido1 = { "Martinez", "Rodriguez", "Gonzalez", "Aguilar", "Lopez", "Maduro", "Bautista", "Gomez" };
            string[] apellido2 = { "Ruiz", "Salas", "Corona", "Hernández", "Juarez", "Jiménez", "Ramírez", "Uribe" };

            //Producto cartesiano de los 3 arreglos. Utilizando LinQ para generar este producto
            //y no utilizar el foreach para la concatenación de los arreglos

            var listaAlumnos = from n1 in nombre1
                               from a1 in apellido1
                               from a2 in apellido2
                               select new Alumnos { Nombre = $"{n1} {a1} {a2}", ID=Guid.NewGuid().ToString()};
                                                    

            return listaAlumnos.OrderBy((al) => al.ID).Take(30).ToList();
        }
    }
}