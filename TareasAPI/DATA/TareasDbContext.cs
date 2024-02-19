using Microsoft.EntityFrameworkCore;
using TareasAPI.MODELS;

namespace TareasAPI.DATA
{
    public class TareasDbContext : DbContext
    {
        public TareasDbContext(DbContextOptions<TareasDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<DetalleTarea> DetalleTareas { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<DetalleProfesor> DetalleProfesores { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var estudiante1 = new Estudiante() { ID = 1, Nombre = "David Sánchez", Materia = "Backend", Activo = true };

            var tarea1 = new Tarea() { ID = 1, Materia = "Backend", Atrasado = true };

            var detalletarea1 = new DetalleTarea() { ID = 1, EstudianteID = 1, TareaID = 1 };

            var profesor1 = new Profesor() { ID = 1, Name = "Gustavo Lozada", Edad = 30, Materia = "Backend" };

            var detalleProfesor1 = new DetalleProfesor() { ID = 1, ProfesorID = 1, TareaID = 1};

            modelBuilder.Entity<Estudiante>().HasData(new Estudiante[] { estudiante1 });
            modelBuilder.Entity<Tarea>().HasData(new Tarea[] { tarea1 });
            modelBuilder.Entity<DetalleTarea>().HasData(new DetalleTarea[] { detalletarea1 });
            modelBuilder.Entity<Profesor>().HasData(new Profesor[] { profesor1 });
            modelBuilder.Entity<DetalleProfesor>().HasData(new DetalleProfesor[] { detalleProfesor1 });

            base.OnModelCreating(modelBuilder);

        }

    }
}
