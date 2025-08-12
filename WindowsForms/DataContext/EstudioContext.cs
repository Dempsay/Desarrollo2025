using System;
using Microsoft.EntityFrameworkCore;
using WindowsForms.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace WindowsForms.DataContex
{
    public class EstudioContext : DbContext
    {
        public virtual DbSet<Estudio> Estudios { get; set; }
        public virtual DbSet<Actor> Actores { get; set; }
        public virtual DbSet<PaisActor> Paises { get; set; }

        public EstudioContext() { }

        public EstudioContext(DbContextOptions<EstudioContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string cnn = "server=127.0.0.1;database=estudiocontext;user=root;password=;sslMode=none;";
                optionsBuilder.UseMySql(cnn, ServerVersion.AutoDetect(cnn));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Semilla para países
            modelBuilder.Entity<PaisActor>().HasData(
                new Pais { Id = 1, Nombre = "Estados Unidos", Eliminado = false },
                new Pais { Id = 2, Nombre = "Reino Unido", Eliminado = false },
                new Pais { Id = 3, Nombre = "Alemania", Eliminado = false },
                new Pais { Id = 4, Nombre = "Francia", Eliminado = false },
                new Pais { Id = 5, Nombre = "Italia", Eliminado = false },
                new Pais { Id = 6, Nombre = "España", Eliminado = false },
                new Pais { Id = 7, Nombre = "Japón", Eliminado = false },
                new Pais { Id = 8, Nombre = "Canadá", Eliminado = false },
                new Pais { Id = 9, Nombre = "Australia", Eliminado = false },
                new Pais { Id = 10, Nombre = "México", Eliminado = false }
            );

            // Semilla para actores con PaisId
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Nombre = "Leonardo DiCaprio", PaisId = 1, Eliminado = false },
                new Actor { Id = 2, Nombre = "Meryl Streep", PaisId = 1, Eliminado = false },
                new Actor { Id = 3, Nombre = "Denzel Washington", PaisId = 1, Eliminado = false },
                new Actor { Id = 4, Nombre = "Tom Hanks", PaisId = 1, Eliminado = false },
                new Actor { Id = 5, Nombre = "Scarlett Johansson", PaisId = 1, Eliminado = false },
                new Actor { Id = 6, Nombre = "Brad Pitt", PaisId = 1, Eliminado = false },
                new Actor { Id = 7, Nombre = "Natalie Portman", PaisId = 2, Eliminado = false },
                new Actor { Id = 8, Nombre = "Morgan Freeman", PaisId = 1, Eliminado = false },
                new Actor { Id = 9, Nombre = "Robert De Niro", PaisId = 1, Eliminado = false },
                new Actor { Id = 10, Nombre = "Emma Stone", PaisId = 1, Eliminado = false }
            );

            // Semilla para estudios
            modelBuilder.Entity<Estudio>().HasData(
                new Estudio { id = 1, nombre = "Warner Bros.", direccion = "4000 Warner Blvd, Burbank, CA, USA", ActorId = 1, Eliminado = false },
                new Estudio { id = 2, nombre = "Paramount Pictures", direccion = "5555 Melrose Ave, Los Angeles, CA, USA", ActorId = 2, Eliminado = false },
                new Estudio { id = 3, nombre = "Universal Pictures", direccion = "100 Universal City Plaza, Universal City, CA, USA", ActorId = 3, Eliminado = false },
                new Estudio { id = 4, nombre = "Columbia Pictures", direccion = "10202 W Washington Blvd, Culver City, CA, USA", ActorId = 4, Eliminado = false },
                new Estudio { id = 5, nombre = "20th Century Studios", direccion = "10201 W Pico Blvd, Los Angeles, CA, USA", ActorId = 5, Eliminado = false },
                new Estudio { id = 6, nombre = "Pinewood Studios", direccion = "Pinewood Rd, Iver Heath, Buckinghamshire, UK", ActorId = 6, Eliminado = false },
                new Estudio { id = 7, nombre = "Studio Babelsberg", direccion = "August-Bebel-Str. 26-53, 14482 Potsdam, Alemania", ActorId = 7, Eliminado = false },
                new Estudio { id = 8, nombre = "Gaumont Film Company", direccion = "30 Avenue Charles de Gaulle, 92200 Neuilly-sur-Seine, Francia", ActorId = 8, Eliminado = false },
                new Estudio { id = 9, nombre = "Cinecittà", direccion = "Via Tuscolana, 1055, 00173 Roma RM, Italia", ActorId = 9, Eliminado = false },
                new Estudio { id = 10, nombre = "Toho Co., Ltd.", direccion = "1-2-2 Yurakucho, Chiyoda City, Tokio, Japón", ActorId = 10, Eliminado = false }
            );

            // Filtros para no mostrar eliminados
            modelBuilder.Entity<Estudio>().HasQueryFilter(e => !e.Eliminado);
            modelBuilder.Entity<Actor>().HasQueryFilter(a => !a.Eliminado);
            modelBuilder.Entity<PaisActor>().HasQueryFilter(p => !p.Eliminado);
        }
    }
}
