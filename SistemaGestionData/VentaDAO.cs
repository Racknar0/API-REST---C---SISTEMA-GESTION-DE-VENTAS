using System.Data;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class VentaDAO
    {
        public static Venta GetVenta(int Id)
        {
            string query = "SELECT * FROM Ventas WHERE Id = @Id";
            Venta ventaObtenida = new Venta();

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });

                        using (SqlDataReader dataReader = comando.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    // Recuperar datos de la venta
                                    ventaObtenida.Id = Convert.ToInt32(dataReader["Id"]);
                                    ventaObtenida.Comentarios = Convert.ToString(dataReader["Comentarios"]);
                                    ventaObtenida.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                                }
                            }
                        }
                    }
                }

                return ventaObtenida;
            } catch (Exception)
            {
                throw new Exception("Error al obtener la venta");
            }
        }

        public static List<Venta> GetAllVentas()
        {
            string query = "SELECT * FROM Ventas";
            List<Venta> ventas = new List<Venta>();

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dataReader = comando.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    // Recuperar datos de la venta
                                    Venta ventaObtenida = new Venta();
                                    ventaObtenida.Id = Convert.ToInt32(dataReader["Id"]);
                                    ventaObtenida.Comentarios = Convert.ToString(dataReader["Comentarios"]);
                                    ventaObtenida.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                    ventas.Add(ventaObtenida);
                                }
                            }
                        }
                    }
                }

                return ventas;
            } catch (Exception)
            {
                throw new Exception("Error al obtener las ventas");
            }
        }

        public static int AddVenta(Venta venta)
        {
            string query = "INSERT INTO Ventas (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario); SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });

                        // Ejecutar la inserción y obtener el ID generado automáticamente
                        int idVentaNueva = Convert.ToInt32(comando.ExecuteScalar());

                        return idVentaNueva;
                    }
                }
            } catch (Exception)
            {
                throw new Exception("Error al agregar la venta");
            }
        }

        public static Venta UpdateVenta(Venta venta)
        {
            string updateQuery = "UPDATE Ventas SET Comentarios = @Comentarios, IdUsuario = @IdUsuario WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand updateComando = new SqlCommand(updateQuery, conexion))
                    {
                        updateComando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                        updateComando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        updateComando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });

                        updateComando.ExecuteNonQuery();
                    }

                    // Llamar a GetVenta para obtener la venta actualizada
                    return GetVenta(venta.Id);
                }
            } catch (Exception)
            {
                throw new Exception("Error al actualizar la venta");
            }
        }

        public static int DeleteVenta(int id)
        {
            string deleteQuery = "DELETE FROM Ventas WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand deleteComando = new SqlCommand(deleteQuery, conexion))
                    {
                        deleteComando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });

                        deleteComando.ExecuteNonQuery();
                    }

                    return id;
                }
            } catch (Exception)
            {
                throw new Exception("Error al eliminar la venta");
            }
        }
    }
}
