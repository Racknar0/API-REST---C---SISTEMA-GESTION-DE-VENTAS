using Proyecto_Coder.Models;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Coder.DataAccess
{
    public class ProductoDAO
    {
        public Producto GetProducto(int Id)
        {
            string query = "SELECT * FROM productos WHERE id = @Id";
            Producto productoObtenido = new Producto();

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
                                    // Recuperar datos del producto
                                    productoObtenido.Id = Convert.ToInt32(dataReader["Id"]);
                                    productoObtenido.Descripcion = Convert.ToString(dataReader["Descripcion"]);
                                    productoObtenido.Costo = Convert.ToDouble(dataReader["Costo"]);
                                    productoObtenido.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                    productoObtenido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    productoObtenido.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                                }
                            }

                        }
                    }
                    
                }   

                return productoObtenido;

            } 
            catch (Exception)
            {

                throw new Exception("Error al obtener el producto");
            }

        }

        public List<Producto> GetAllProductos()
        {
            string query = "SELECT * FROM productos";
            List<Producto> productos = new List<Producto>();

            // Código para obtener productos de la base de datos y llenar la lista.
            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        //comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });

                        using (SqlDataReader dataReader = comando.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    Producto productoObtenido = new Producto();

                                    // Recuperar datos del producto
                                    productoObtenido.Id = Convert.ToInt32(dataReader["Id"]);
                                    productoObtenido.Descripcion = Convert.ToString(dataReader["Descripcion"]);
                                    productoObtenido.Costo = Convert.ToDouble(dataReader["Costo"]);
                                    productoObtenido.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                    productoObtenido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    productoObtenido.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                    productos.Add(productoObtenido);
                                }
                            }

                        }
                    }

                }

                return productos;
            } 
            catch (Exception)
            {

                throw new Exception("Error al obtener los productos");
            }
        }

        public int AddProducto(Producto producto)
        {
            string query = "INSERT INTO productos (Descripcion, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario); SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.NVarChar) { Value = producto.Descripcion });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

                        // Ejecutar la inserción y obtener el ID generado automáticamente
                        int idProducto = Convert.ToInt32(comando.ExecuteScalar());

                        return idProducto;
                    }
                }
            } catch (Exception)
            {
                throw new Exception("Error al agregar el producto");
            }
        }

        public Producto UpdateProducto(Producto producto)
        {
            string updateQuery = "UPDATE productos SET Descripcion = @Descripcion, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand updateComando = new SqlCommand(updateQuery, conexion))
                    {
                        updateComando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                        updateComando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.NVarChar) { Value = producto.Descripcion });
                        updateComando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        updateComando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        updateComando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        updateComando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

                        updateComando.ExecuteNonQuery();
                    }

                    // Llamar a GetProducto para obtener el producto actualizado
                    return GetProducto(producto.Id);
                }
            } catch (Exception)
            {
                throw new Exception("Error al actualizar el producto");
            }
        }

        public int DeleteProducto(int Id)
        {
            string deleteQuery = "DELETE FROM productos WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand deleteComando = new SqlCommand(deleteQuery, conexion))
                    {
                        deleteComando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });

                        deleteComando.ExecuteNonQuery();
                    }

                    return Id;
                }
            } catch (Exception)
            {
                throw new Exception("Error al eliminar el producto");
            }
        }      
    }
}
