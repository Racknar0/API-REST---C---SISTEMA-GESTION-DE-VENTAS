using System.Data.SqlClient;
using System.Data;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoVendidoDAO
    {
        public static ProductoVendido GetProductoVendido(int Id)
        {
            string query = "SELECT * FROM ProductosVendidos WHERE Id = @Id";
            ProductoVendido productoVendidoObtenido = new ProductoVendido();

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
                                    // Recuperar datos del producto vendido
                                    productoVendidoObtenido.Id = Convert.ToInt32(dataReader["Id"]);
                                    productoVendidoObtenido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                    productoVendidoObtenido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    productoVendidoObtenido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);
                                }
                            }
                        }
                    }
                }

                return productoVendidoObtenido;
            } catch (Exception)
            {
                throw new Exception("Error al obtener el producto vendido");
            }
        }

        public static List<ProductoVendido> GetAllProductosVendidos()
        {
            string query = "SELECT * FROM ProductosVendidos";
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();

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
                                    // Recuperar datos del producto vendido
                                    ProductoVendido productoVendidoObtenido = new ProductoVendido();
                                    productoVendidoObtenido.Id = Convert.ToInt32(dataReader["Id"]);
                                    productoVendidoObtenido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                    productoVendidoObtenido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    productoVendidoObtenido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);

                                    productosVendidos.Add(productoVendidoObtenido);
                                }
                            }
                        }
                    }
                }

                return productosVendidos;
            } catch (Exception)
            {
                throw new Exception("Error al obtener los productos vendidos");
            }
        }

        public static int AddProductoVendido(ProductoVendido productoVendido)
        {
            string query = "INSERT INTO ProductosVendidos (IdProducto, Stock, IdVenta) VALUES (@IdProducto, @Stock, @IdVenta); SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });

                        // Ejecutar la inserción y obtener el ID generado automáticamente
                        int idProductoVendidoNuevo = Convert.ToInt32(comando.ExecuteScalar());

                        return idProductoVendidoNuevo;
                    }
                }
            } catch (Exception)
            {
                throw new Exception("Error al agregar el producto vendido");
            }
        }

        public static ProductoVendido UpdateProductoVendido(ProductoVendido productoVendido)
        {
            string updateQuery = "UPDATE ProductosVendidos SET IdProducto = @IdProducto, Stock = @Stock, IdVenta = @IdVenta WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand updateComando = new SqlCommand(updateQuery, conexion))
                    {
                        updateComando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                        updateComando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                        updateComando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                        updateComando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });

                        updateComando.ExecuteNonQuery();
                    }

                    // Llamar a GetProductoVendido para obtener el producto vendido actualizado
                    return GetProductoVendido(productoVendido.Id);
                }
            } catch (Exception)
            {
                throw new Exception("Error al actualizar el producto vendido");
            }
        }

        public static int DeleteProductoVendido(int id)
        {
            string deleteQuery = "DELETE FROM ProductosVendidos WHERE Id = @Id";

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
                throw new Exception("Error al eliminar el producto vendido");
            }
        }
    }
}
