using Proyecto_Coder.DataAccess;
using Proyecto_Coder.Models;

// Operaciones de Producto
static void EjecutarOperacionesProducto()
{
    // Crear instancia del DAO de Producto
    ProductoDAO productoDAO = new ProductoDAO();

    Console.WriteLine("-----------------OBTENER UN PRODUCTO----------------------");
    // Obtener un producto por su id
    Producto producto = productoDAO.GetProducto(1);
    Console.WriteLine($"El producto con id {producto.Id} es \n ID: {producto.Id} \n Descripcion: {producto.Descripcion} \n Costo: {producto.Costo} \n Precio de venta: {producto.PrecioVenta} \n Stock: {producto.Stock} \n Id Usuario: {producto.IdUsuario}");

    Console.WriteLine("-----------------OBTENER TODOS LOS PRODUCTOS----------------------");
    // Obtener todos los productos
    List<Producto> productos = productoDAO.GetAllProductos();
    // Imprimir todos los productos
    foreach (Producto p in productos)
    {
        Console.WriteLine($"El producto con id {p.Id} es \n ID: {p.Id} \n Descripcion: {p.Descripcion} \n Costo: {p.Costo} \n Precio de venta: {p.PrecioVenta} \n Stock: {p.Stock} \n Id Usuario: {p.IdUsuario}");
    }

    Console.WriteLine("-----------------CREAR UN PRODUCTO----------------------");
    Producto productoNuevo = new Producto(0, "Producto de prueba", 100, 200, 10, 1);
    int idProductoNuevo = productoDAO.AddProducto(productoNuevo);
    Console.WriteLine($"El id del producto nuevo es {idProductoNuevo}");

    Console.WriteLine("-----------------ACTUALIZAR UN PRODUCTO----------------------");
    Producto productoAActualizar = new Producto(1, "Producto de prueba actualizado", 100, 200, 10, 1);
    Producto productoActualizado = productoDAO.UpdateProducto(productoAActualizar);
    Console.WriteLine($"El producto actualizado es \n ID: {productoActualizado.Id} \n Descripcion: {productoActualizado.Descripcion} \n Costo: {productoActualizado.Costo} \n Precio de venta: {productoActualizado.PrecioVenta} \n Stock: {productoActualizado.Stock} \n Id Usuario: {productoActualizado.IdUsuario}");

    Console.WriteLine("-----------------ELIMINAR UN PRODUCTO----------------------");
    int productoEliminado = productoDAO.DeleteProducto(5);
    Console.WriteLine($"El producto eliminado es {productoEliminado}");

}
//EjecutarOperacionesProducto();




// Operaciones de Usuario
static void EjecutarOperacionesUsuario()
{
    // Crear instancia del DAO de Usuario
    UsuarioDAO usuarioDAO = new UsuarioDAO();

    Console.WriteLine("-----------------OBTENER UN USUARIO----------------------");
    // Obtener un usuario por su id
    Usuario usuario = usuarioDAO.GetUsuario(1); 
    Console.WriteLine($"El usuario con id {usuario.Id} es \n ID: {usuario.Id} \n Nombre: {usuario.Nombre} \n Apellido: {usuario.Apellido} \n Nombre de usuario: {usuario.NombreUsuario} \n Contraseña: {usuario.Contrasenia} \n Mail: {usuario.Mail}");

    Console.WriteLine("-----------------OBTENER TODOS LOS USUARIOS----------------------");
    // Obtener todos los usuarios
    List<Usuario> usuarios = usuarioDAO.GetAllUsuarios();
    // Imprimir todos los usuarios
    foreach (Usuario u in usuarios)
    {
        Console.WriteLine($"El usuario con id {u.Id} es \n ID: {u.Id} \n Nombre: {u.Nombre} \n Apellido: {u.Apellido} \n Nombre de usuario: {u.NombreUsuario} \n Contraseña: {u.Contrasenia} \n Mail: {u.Mail}");
    }

    Console.WriteLine("-----------------CREAR UN USUARIO----------------------");
    Usuario usuarioNuevo = new Usuario(0, "Usuario", "Nuevo", "usuarioNuevo", "123456", "correo@correo.com");
    int idUsuarioNuevo = usuarioDAO.AddUsuario(usuarioNuevo);
    Console.WriteLine($"El id del usuario nuevo es {idUsuarioNuevo}");

    Console.WriteLine("-----------------ACTUALIZAR UN USUARIO----------------------");
    Usuario usuarioAActualizar = new Usuario(1, "Usuario", "Actualizado", "usuarioActualizado", "123456", "correox@pepe.com");
    Usuario usuarioActualizado = usuarioDAO.UpdateUsuario(usuarioAActualizar);
    Console.WriteLine($"El usuario actualizado es \n ID: {usuarioActualizado.Id} \n Nombre: {usuarioActualizado.Nombre} \n Apellido: {usuarioActualizado.Apellido} \n Nombre de usuario: {usuarioActualizado.NombreUsuario} \n Contraseña: {usuarioActualizado.Contrasenia} \n Mail: {usuarioActualizado.Mail}");

    Console.WriteLine("-----------------ELIMINAR UN USUARIO----------------------");
    int usuarioEliminado = usuarioDAO.DeleteUsuario(5);
    Console.WriteLine($"El usuario eliminado es {usuarioEliminado}");

}
//EjecutarOperacionesUsuario();





// Operaciones de ProductoVendido
static void EjecutarOperacionesProductoVendido()
{
    // Crear instancia del DAO de ProductoVendido
    ProductoVendidoDAO productoVendidoDAO = new ProductoVendidoDAO();

    Console.WriteLine("-----------------OBTENER UN PRODUCTO VENDIDO----------------------");
    // Obtener un producto vendido por su id
    ProductoVendido productoVendido = productoVendidoDAO.GetProductoVendido(1);
    Console.WriteLine($"El producto vendido con id {productoVendido.Id} es \n ID: {productoVendido.Id} \n ID del Producto: {productoVendido.IdProducto} \n Stock: {productoVendido.Stock} \n ID de Venta: {productoVendido.IdVenta}");

    Console.WriteLine("-----------------OBTENER TODOS LOS PRODUCTOS VENDIDOS----------------------");
    // Obtener todos los productos vendidos
    List<ProductoVendido> productosVendidos = productoVendidoDAO.GetAllProductosVendidos();
    // Imprimir todos los productos vendidos
    foreach (ProductoVendido pv in productosVendidos)
    {
        Console.WriteLine($"El producto vendido con id {pv.Id} es \n ID: {pv.Id} \n ID del Producto: {pv.IdProducto} \n Stock: {pv.Stock} \n ID de Venta: {pv.IdVenta}");
    }

    Console.WriteLine("-----------------CREAR UN PRODUCTO VENDIDO----------------------");
    ProductoVendido productoVendidoNuevo = new ProductoVendido(0, 1, 5, 1); // Reemplaza los valores con los datos deseados
    int idProductoVendidoNuevo = productoVendidoDAO.AddProductoVendido(productoVendidoNuevo);
    Console.WriteLine($"El id del producto vendido nuevo es {idProductoVendidoNuevo}");

    Console.WriteLine("-----------------ACTUALIZAR UN PRODUCTO VENDIDO----------------------");
    ProductoVendido productoVendidoAActualizar = new ProductoVendido(1, 2, 10, 1); // Reemplaza los valores con los datos deseados
    ProductoVendido productoVendidoActualizado = productoVendidoDAO.UpdateProductoVendido(productoVendidoAActualizar);
    Console.WriteLine($"El producto vendido actualizado es \n ID: {productoVendidoActualizado.Id} \n ID del Producto: {productoVendidoActualizado.IdProducto} \n Stock: {productoVendidoActualizado.Stock} \n ID de Venta: {productoVendidoActualizado.IdVenta}");

    Console.WriteLine("-----------------ELIMINAR UN PRODUCTO VENDIDO----------------------");
    int productoVendidoEliminado = productoVendidoDAO.DeleteProductoVendido(5); // Reemplaza con el ID del producto vendido a eliminar
    Console.WriteLine($"El producto vendido eliminado es {productoVendidoEliminado}");
}
// EjecutarOperacionesProductoVendido();




// Operaciones de Venta
static void EjecutarOperacionesVenta()
{
    // Crear instancia del DAO de Venta
    VentaDAO ventaDAO = new VentaDAO();

    Console.WriteLine("-----------------OBTENER UNA VENTA----------------------");
    // Obtener una venta por su id
    Venta venta = ventaDAO.GetVenta(1);
    Console.WriteLine($"La venta con id {venta.Id} es \n ID: {venta.Id} \n Comentarios: {venta.Comentarios} \n IdUsuario: {venta.IdUsuario}");

    Console.WriteLine("-----------------OBTENER TODAS LAS VENTAS----------------------");
    // Obtener todas las ventas
    List<Venta> ventas = ventaDAO.GetAllVentas();
    // Imprimir todas las ventas
    foreach (Venta v in ventas)
    {
        Console.WriteLine($"La venta con id {v.Id} es \n ID: {v.Id} \n Comentarios: {v.Comentarios} \n IdUsuario: {v.IdUsuario}");
    }

    Console.WriteLine("-----------------CREAR UNA VENTA----------------------");
    Venta ventaNueva = new Venta(0, "Venta de prueba", 1);
    int idVentaNueva = ventaDAO.AddVenta(ventaNueva);
    Console.WriteLine($"El id de la venta nueva es {idVentaNueva}");

    Console.WriteLine("-----------------ACTUALIZAR UNA VENTA----------------------");
    Venta ventaAActualizar = new Venta(1, "Venta de prueba actualizada", 2);
    Venta ventaActualizada = ventaDAO.UpdateVenta(ventaAActualizar);
    Console.WriteLine($"La venta actualizada es \n ID: {ventaActualizada.Id} \n Comentarios: {ventaActualizada.Comentarios} \n IdUsuario: {ventaActualizada.IdUsuario}");

    Console.WriteLine("-----------------ELIMINAR UNA VENTA----------------------");
    int ventaEliminada = ventaDAO.DeleteVenta(5);
    Console.WriteLine($"La venta eliminada es {ventaEliminada}");
}
EjecutarOperacionesVenta();
