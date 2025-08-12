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
    public class EstudioEFService
    {
        public async Task<List<Estudio>?> GetAllAsync()
        {
            using (EstudioContext cine = new EstudioContext())
            {
                return await cine.Estudios.Include(p => p.Actor).ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (EstudioContext cine = new EstudioContext())
            {
                var estudioBorrar = await cine.Estudios.FindAsync(id);
                estudioBorrar.Eliminado = true; // Marcar como eliminado
                cine.Estudios.Update(estudioBorrar);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true; // Se eliminó correctamente
                }
                else
                {
                    throw new Exception("Error al eliminar el Estudio de Cine");
                }
            }
        }
        public async Task<bool> UpdateAsync(Estudio estudio)
        {
            using (EstudioContext cine = new EstudioContext())
            {
                cine.Estudios.Update(estudio);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true; // Se eliminó correctamente
                }
                else
                {
                    throw new Exception("Error al actualizar el Estudio de Cine");
                }
            }
        }
        public async Task<bool> AddAsync(Estudio estudio)
        {
            using (EstudioContext cine = new EstudioContext())
            {
                cine.Estudios.Add(estudio);
                var response = await cine.SaveChangesAsync();
                if (response > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar el Estudio de Cine");
                }
            }
        }
    }
}
