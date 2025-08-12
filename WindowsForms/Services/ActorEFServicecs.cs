using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using WindowsForms.Models;
using WindowsForms.DataContex;
using Microsoft.EntityFrameworkCore;

namespace WindowsForms.Services
{
    public class ActorEFService
    {
        public async Task<List<Actor>?> GetAllAsync()
        {
            using (EstudioContext cine = new EstudioContext())
            {
                return await cine.Actores.Include(p => p.Pais).ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (EstudioContext cine = new EstudioContext())
            {
                var actorABorrar = await cine.Actores.FindAsync(id);
                actorABorrar.Eliminado = true; //marcamos la película como eliminada
                cine.Actores.Update(actorABorrar);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar el Actor");
                }
            }
        }
        public async Task<bool> UpdateAsync(Actor actor)
        {
            using (EstudioContext cine = new EstudioContext())
            {
                cine.Actores.Update(actor);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar el Actor");
                }
            }
        }
        public async Task<bool> AddAsync(Actor actor)
        {
            using (EstudioContext cine = new EstudioContext())
            {
                cine.Actores.Add(actor);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar el Actor");
                }
            }
        }

    }
}