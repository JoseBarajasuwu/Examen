using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
namespace apiexamen

{
    public class LibreriaApi
    {
        private static readonly string connectionString = "Data Source=DESKTOP-UU9R8QG\\SQLEXPRESS;Initial Catalog=BdiExamen;Integrated Security=True";
        private static SqlConnection conexion;

        public LibreriaApi() { }

        public static SqlConnection ObtenerConexion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(connectionString);
                conexion.Open();
            }
            else if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion = new SqlConnection(connectionString);
                conexion.Open();
            }

            return conexion;
        }
        public List<(int, string, string)> ConsultarDatos()
        {
            List<(int, string, string)> datos = new List<(int, string, string)>();

            try
            {
                using (SqlConnection conexion = LibreriaApi.ObtenerConexion())
                {
                    // Query SQL que quieres ejecutar
                    string consulta = "SELECT ExamenID, Nombre, Descripcion FROM Examen";

                    // Crear un comando SQL
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        // Ejecutar el comando y obtener un lector de datos
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            // Iterar sobre los resultados
                            while (lector.Read())
                            {
                                // Acceder a los datos de cada fila
                                int id = Convert.ToInt32(lector["ExamenID"]);
                                string nombre = Convert.ToString(lector["Nombre"]);
                                string descripcion = Convert.ToString(lector["Descripcion"]);

                                // Agregar los datos a la lista
                                datos.Add((id, nombre, descripcion));
                            }
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al consultar datos: " + ex.Message);
            }

            return datos;
        }


        public void InsertarDatos(string nombre, string descripcion)
        {
            try
            {
                using (SqlConnection conexion = LibreriaApi.ObtenerConexion())
                {
                    // Crear y ejecutar el comando SQL
                    using (SqlCommand comando = new SqlCommand("InsertarExamen", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        // Agregar parámetros a la consulta
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion);

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al insertar datos: " + ex.Message);
            }
        }
        public void ActualizarDatos(int id, string nuevoNombre, string descripcion)
        {
            try
            {

                using (SqlConnection conexion = LibreriaApi.ObtenerConexion())
                {

                    // Crear y ejecutar el comando SQL
                    using (SqlCommand comando = new SqlCommand("ActualizarExamenDescripcion", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        // Agregar parámetros a la consulta
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nuevoNombre);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion);

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al actualizar datos: " + ex.Message);
            }
        }
        public void EliminarExamenPorId(int parametro)
        {
            try
            {
                using (SqlConnection conexion = LibreriaApi.ObtenerConexion())
                {

                    using (SqlCommand comando = new SqlCommand("EliminarExamenPorId", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro al procedimiento almacenado
                        comando.Parameters.AddWithValue("@Id", parametro);

                        // Ejecutar el procedimiento almacenado
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al eliminar datos: " + ex.Message);
            }

        }
    }
}
