using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;

namespace WindowsForms.Services
{
    public class ProcesadorADOService
    {
        //connectionstring a mysql user root pass root
        string connectionString = "server=127.0.0.1;user=root;password=;database=componentes";

        public async Task<List<Procesador>?> GetAllAsync()
        {
            //obtenemos con ado.net desde mi mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand("SELECT * FROM procesadores", connection);
                var reader = await command.ExecuteReaderAsync();
                List<Procesador> procesadores = new List<Procesador>();
                while (await reader.ReadAsync())
                {
                    Procesador procesador = new Procesador
                    {
                        id = Convert.ToInt32(reader["id"]),
                        marca = reader["marca"].ToString(),
                        modelo = reader["modelo"].ToString(),
                        generacion = reader["generacion"].ToString(),
                        modelo_generacion = reader["modelo_generacion"].ToString(),
                        sufijo = reader["sufijo"].ToString(),
                    };
                    procesadores.Add(procesador);
                }
                return procesadores;
            }

        }
        public async Task<bool> DeleteAsync(int? id)
        {
            //obtenemos con ado.net desde mi mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand($"DELETE FROM procesadores WHERE id={id}", connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                    return true; // Se eliminó correctamente
                else
                    return false; // No se encontró la película o no se eliminó
            }
        }
        public async Task<bool> UpdateAsync(Procesador procesadores)
        {
            //obtenemos con ado.net desde mi mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var query = $"UPDATE procesadores SET marca='{procesadores.marca}', " +
                                               $"modelo={procesadores.modelo}, " +
                                               $"generacion='{procesadores.generacion}', " +
                                               $"modelo_generacion={procesadores.modelo_generacion}" +
                                               $"sufijo='{procesadores.sufijo}'" +
                            $" WHERE id={procesadores.id}";
                var command = new MySqlCommand(query, connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                    return true; // Se eliminó correctamente
                else
                    return false; // No se encontró la película o no se eliminó
            }
        }
        public async Task<bool> AddAsync(Procesador procesador)
        {
            //obtenemos con ado.net desde mi mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var query = $"INSERT INTO procesadores (marca,modelo,generacion,modelo_generacion,sufijo) VALUES " +
                    $"('{procesador.marca}','{procesador.modelo}','{procesador.generacion}',{procesador.modelo_generacion},'{procesador.sufijo}')";
                var command = new MySqlCommand(query, connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                    return true; // Se eliminó correctamente
                else
                    return false; // No se encontró la película o no se eliminó
            }
        }
    }
}
