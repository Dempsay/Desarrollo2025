using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.DataContex;
using WindowsForms.Models;

namespace WindowsForms.Services
{
    public class PeliculaEFService
    {
        public async Task<List<Pelicula>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Peliculas.Include(p=>p.Pais).ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var peliculaBorrar = await cine.Peliculas.FindAsync(id);
                peliculaBorrar.Eliminado = true; // Marcar como eliminado
                cine.Peliculas.Update(peliculaBorrar);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true; // Se eliminó correctamente
                }
                else
                {
                    throw new Exception("Error al eliminar la pelicula");
                }
            }
        }
        public async Task<bool> UpdateAsync(Pelicula pelicula)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Peliculas.Update(pelicula);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true; // Se eliminó correctamente
                }
                else
                {
                    throw new Exception("Error al actualizar la pelicula");
                }
            }
        }
        public async Task<bool> AddAsync(Pelicula pelicula)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Peliculas.Add(pelicula);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar la pelicula");
                }
            }
        }
    }
}
