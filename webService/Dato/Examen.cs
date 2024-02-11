
using AgregarUsuarios.Modelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webService.Conexcion;
using System.Net;
namespace AgregarUsuarios.Dato
{
    public class Examen
    {
        Conexcion cn = new Conexcion();
        private static readonly string connectionString = "Data Source=DESKTOP-UU9R8QG\\SQLEXPRESS;Initial Catalog=BdiExamen;Integrated Security=True";

        public async Task<List<ExamenModel>> MostrarExamen()
        {
            // Desactivar la validación del certificado SSL
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            var lista = new List<ExamenModel>();
            try
            {
                // Usar tu conexión a la base de datos, reemplaza connectionString con tu cadena de conexión
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    await sql.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand("ConsultarTodosLosExamenes", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var examen = new ExamenModel
                                {
                                    // Aquí asigna los valores de las columnas del resultado a las propiedades de tu modelo
                                    // Por ejemplo, supongamos que tu modelo tiene propiedades Id, Nombre y Descripcion
                                    ExamenID = Convert.ToInt32(reader["ExamenID"]),
                                    Nombre = Convert.ToString(reader["Nombre"]),
                                    Descripcion = Convert.ToString(reader["Descripcion"])
                                };
                                lista.Add(examen);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al mostrar exámenes: " + ex.Message);
            }
            return lista;
        }
    }
}
