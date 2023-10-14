using SistemaGestionBusiness;
using SistemaGestionEntities;



static void MostrarMenu()
{
    //Limpiar la consola
    Console.WriteLine("-----------------PROYECTO CODER----------------------");
    Console.WriteLine("Seleccione una opción: ");
    Console.WriteLine("1. Operaciones de Usuario");
    Console.WriteLine("2. Operaciones de Producto");
    Console.WriteLine("3. Operaciones de Producto Vendido");
    Console.WriteLine("4. Operaciones de Venta");
    Console.WriteLine("5. Salir");
}

string opcion = String.Empty;
bool opt = true;

do
{
    MostrarMenu();
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            EjecutarOperacionesUsuario();
            break;
        case "2":
            EjecutarOperacionesProducto();
            break;
        case "3":
            EjecutarOperacionesProductoVendido();
            break;
        case "4":
            EjecutarOperacionesVenta();
            break;
        case "5":
            Console.WriteLine("Saliendo...");
            opt = false;
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
} while (opt);


static void MostrarSubMenuOperacionesUsuario()
{
    //Limpiar la consola
    Console.WriteLine("-----------------Operaciones Usuario----------------------");
    Console.WriteLine("Seleccione una opción: ");
    Console.WriteLine("1. Obtener un Usuario");
    Console.WriteLine("2. Obtener todos los Usuarios");
    Console.WriteLine("3. Crear un Usuario");
    Console.WriteLine("4. Actualizar un Usuario");
    Console.WriteLine("5. Eliminar un Usuario");
    Console.WriteLine("6. Salir");
}

static void MostrarSubMenuOperacionesProducto()
{
    //Limpiar la consola
    Console.WriteLine("-----------------Operaciones Producto----------------------");
    Console.WriteLine("Seleccione una Producto: ");
    Console.WriteLine("1. Obtener un Producto");
    Console.WriteLine("2. Obtener todos los Productos");
    Console.WriteLine("3. Crear un Producto");
    Console.WriteLine("4. Actualizar un Producto");
    Console.WriteLine("5. Eliminar un Producto");
    Console.WriteLine("6. Salir");
}

static void MostrarSubMenuOperacionesProductoVendido()
{
    Console.WriteLine("-----------------Operaciones Producto Vendido----------------------");
    Console.WriteLine("Seleccione una opción: ");
    Console.WriteLine("1. Obtener un Producto Vendido");
    Console.WriteLine("2. Obtener todos los Productos Vendidos");
    Console.WriteLine("3. Crear un Producto Vendido");
    Console.WriteLine("4. Actualizar un Producto Vendido");
    Console.WriteLine("5. Eliminar un Producto Vendido");
    Console.WriteLine("6. Salir");
}

static void MostrarSubMenuOperacionesVenta()
{
    Console.WriteLine("-----------------Operaciones Venta----------------------");
    Console.WriteLine("Seleccione una opción: ");
    Console.WriteLine("1. Obtener una Venta");
    Console.WriteLine("2. Obtener todas las Ventas");
    Console.WriteLine("3. Crear una Venta");
    Console.WriteLine("4. Actualizar una Venta");
    Console.WriteLine("5. Eliminar una Venta");
    Console.WriteLine("6. Salir");
}

static void EjecutarOperacionesUsuario()
{
    string opcionUsuario = String.Empty; // Variable para el submenú de usuario

    do
    {
        MostrarSubMenuOperacionesUsuario(); // Muestra el submenú
        opcionUsuario = Console.ReadLine();

        switch (opcionUsuario)
        {
            case "1":
                // Obtener un usuario
                ObtenerUsuario();
                break;
            case "2":
                // Obtener todos los usuarios
                ObtenerTodosLosUsuarios();
                break;
            case "3":
                // Crear un usuario
                CrearUsuario();
                break;
            case "4":
                // Actualizar un usuario
                ActualizarUsuario();
                break;
            case "5":
                // Eliminar un usuario
                EliminarUsuario();
                break;
            case "6":
                Console.WriteLine("Saliendo del submenú de usuario...");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    } while (opcionUsuario != "6");
}



static void EjecutarOperacionesProducto()
{
    string opcionUsuario = String.Empty; // Variable para el submenú de usuario

    do
    {
        MostrarSubMenuOperacionesProducto(); // Muestra el submenú
        opcionUsuario = Console.ReadLine();

        switch (opcionUsuario)
        {
            case "1":
                // Obtener un Producto
                ObtenerProducto();
                break;
            case "2":
                // Obtener todos los Productos
                ObtenerTodosLosProducto();
                break;
            case "3":
                // Crear un Producto
                CrearProducto();
                break;
            case "4":
                // Actualizar un Producto
                ActualizarProducto();
                break;
            case "5":
                // Eliminar un Producto
                EliminarProducto();
                break;
            case "6":
                Console.WriteLine("Saliendo del submenú de usuario...");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    } while (opcionUsuario != "6");
}



static void EjecutarOperacionesProductoVendido()
{
    string opcionUsuario = String.Empty;

    do
    {
        MostrarSubMenuOperacionesProductoVendido();
        opcionUsuario = Console.ReadLine();

        switch (opcionUsuario)
        {
            case "1":
                ObtenerProductoVendido();
                break;
            case "2":
                ObtenerTodosLosProductosVendidos();
                break;
            case "3":
                CrearProductoVendido();
                break;
            case "4":
                ActualizarProductoVendido();
                break;
            case "5":
                EliminarProductoVendido();
                break;
            case "6":
                Console.WriteLine("Saliendo del submenú de Producto Vendido...");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    } while (opcionUsuario != "6");
}

static void EjecutarOperacionesVenta()
{
    string opcionUsuario = String.Empty;

    do
    {
        MostrarSubMenuOperacionesVenta();
        opcionUsuario = Console.ReadLine();

        switch (opcionUsuario)
        {
            case "1":
                ObtenerVenta();
                break;
            case "2":
                ObtenerTodasLasVentas();
                break;
            case "3":
                CrearVenta();
                break;
            case "4":
                ActualizarVenta();
                break;
            case "5":
                EliminarVenta();
                break;
            case "6":
                Console.WriteLine("Saliendo del submenú de Venta...");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    } while (opcionUsuario != "6");
}



// Operaciones de Usuario
static void ObtenerUsuario()
{
    // Crear instancia de UsuarioBusiness 
    UsuarioBusiness User = new UsuarioBusiness();
    Console.WriteLine("-----------------OBTENER UN USUARIO----------------------");
    // Obtener un usuario por su id
    Console.WriteLine("Ingrese el id del usuario a obtener: ");
    int idUsuario = Convert.ToInt32(Console.ReadLine());
    Usuario usuario = User.GetUsuarioBussines(idUsuario);
    Console.WriteLine($"El usuario con id {usuario.Id} es \n ID: {usuario.Id} \n Nombre: {usuario.Nombre} \n Apellido: {usuario.Apellido} \n Nombre de usuario: {usuario.NombreUsuario} \n Contraseña: {usuario.Contrasenia} \n Mail: {usuario.Mail}");
}

static void ObtenerTodosLosUsuarios()
{
    UsuarioBusiness User = new UsuarioBusiness();
    Console.WriteLine("-----------------OBTENER TODOS LOS USUARIOS----------------------");
    // Obtener todos los usuarios
    List<Usuario> usuarios = User.GetAllUsuariosBussines();
    // Imprimir todos los usuarios
    foreach (Usuario u in usuarios)
    {
        Console.WriteLine($"El usuario con id {u.Id} es \n ID: {u.Id} \n Nombre: {u.Nombre} \n Apellido: {u.Apellido} \n Nombre de usuario: {u.NombreUsuario} \n Contraseña: {u.Contrasenia} \n Mail: {u.Mail}");
    }
}

static void CrearUsuario()
{
    UsuarioBusiness User = new UsuarioBusiness();
    Console.WriteLine("-----------------CREAR UN USUARIO----------------------");
    Usuario usuarioNuevo = new Usuario();
    Console.WriteLine("Ingrese el nombre del usuario: ");
    usuarioNuevo.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del usuario: ");
    usuarioNuevo.Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese el username del usuario: ");
    usuarioNuevo.NombreUsuario = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña del usuario: ");
    usuarioNuevo.Contrasenia = Console.ReadLine();
    Console.WriteLine("Ingrese el mail del usuario: ");
    usuarioNuevo.Mail = Console.ReadLine();

    int idUsuarioNuevo = User.AddUsuarioBussines(usuarioNuevo);
    Console.WriteLine($"El id del usuario nuevo es {idUsuarioNuevo}");
}

static void ActualizarUsuario()
{
    UsuarioBusiness User = new UsuarioBusiness();
    Console.WriteLine("-----------------ACTUALIZAR UN USUARIO----------------------");
    Usuario usuarioAActualizar = new Usuario();
    Console.WriteLine("Ingrese el id del usuario a actualizar: ");
    usuarioAActualizar.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre del usuario: ");
    usuarioAActualizar.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del usuario: ");
    usuarioAActualizar.Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese el username del usuario: ");
    usuarioAActualizar.NombreUsuario = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña del usuario: ");
    usuarioAActualizar.Contrasenia = Console.ReadLine();
    Console.WriteLine("Ingrese el mail del usuario: ");
    usuarioAActualizar.Mail = Console.ReadLine();

    Usuario usuarioActualizado = User.UpdateUsuarioBussines(usuarioAActualizar);
    Console.WriteLine($"El usuario actualizado es \n ID: {usuarioActualizado.Id} \n Nombre: {usuarioActualizado.Nombre} \n Apellido: {usuarioActualizado.Apellido} \n Nombre de usuario: {usuarioActualizado.NombreUsuario} \n Contraseña: {usuarioActualizado.Contrasenia} \n Mail: {usuarioActualizado.Mail}");
}

static void EliminarUsuario()
{
    UsuarioBusiness User = new UsuarioBusiness();
    Console.WriteLine("-----------------ELIMINAR UN USUARIO----------------------");
    Console.WriteLine("Ingrese el id del usuario a eliminar: ");
    int idUsuario = Convert.ToInt32(Console.ReadLine());
    int usuarioEliminado = User.DeleteUsuarioBussines(idUsuario);
    Console.WriteLine($"El usuario eliminado es {usuarioEliminado}");
}





// Operaciones de Producto
static void ObtenerProducto()
{
    ProductoBusiness Product = new ProductoBusiness();
    Console.WriteLine("-----------------OBTENER UN PRODUCTO----------------------");
    // Obtener un producto por su id
    Console.WriteLine("Ingrese el id del producto a obtener: ");
    int idProducto = Convert.ToInt32(Console.ReadLine());
    Producto producto = Product.GetProductoBussines(idProducto);
    Console.WriteLine($"El producto con id {producto.Id} es \n ID: {producto.Id} \n Descripcion: {producto.Descripcion} \n Costo: {producto.Costo} \n Precio de venta: {producto.PrecioVenta} \n Stock: {producto.Stock} \n Id Usuario: {producto.IdUsuario}");
}

static void ObtenerTodosLosProducto()
{
    ProductoBusiness Product = new ProductoBusiness();
    Console.WriteLine("-----------------OBTENER TODOS LOS PRODUCTOS----------------------");
    // Obtener todos los productos
    List<Producto> productos = Product.GetAllProductosBussines();
    // Imprimir todos los productos
    foreach (Producto p in productos)
    {
        Console.WriteLine($"El producto con id {p.Id} es \n ID: {p.Id} \n Descripcion: {p.Descripcion} \n Costo: {p.Costo} \n Precio de venta: {p.PrecioVenta} \n Stock: {p.Stock} \n Id Usuario: {p.IdUsuario}");
    }
}

static void CrearProducto()
{
    ProductoBusiness Product = new ProductoBusiness();
    Console.WriteLine("-----------------CREAR UN PRODUCTO----------------------");
    Producto productoNuevo = new Producto();
    Console.WriteLine("Ingrese la descripcion del producto: ");
    productoNuevo.Descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el costo del producto: ");
    productoNuevo.Costo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el precio de venta del producto: ");
    productoNuevo.PrecioVenta = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el stock del producto: ");
    productoNuevo.Stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el id del usuario: ");
    productoNuevo.IdUsuario = Convert.ToInt32(Console.ReadLine());

    int idProductoNuevo = Product.AddProductoBussines(productoNuevo);
    Console.WriteLine($"El id del producto nuevo es {idProductoNuevo}");
}

static void ActualizarProducto()
{
    ProductoBusiness Product = new ProductoBusiness();
    Console.WriteLine("-----------------ACTUALIZAR UN PRODUCTO----------------------");
    Producto productoAActualizar = new Producto();
    Console.WriteLine("Ingrese el id del producto a actualizar: ");
    productoAActualizar.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la descripcion del producto: ");
    productoAActualizar.Descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el costo del producto: ");
    productoAActualizar.Costo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el precio de venta del producto: ");
    productoAActualizar.PrecioVenta = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el stock del producto: ");
    productoAActualizar.Stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el id del usuario: ");
    productoAActualizar.IdUsuario = Convert.ToInt32(Console.ReadLine());

    Producto productoActualizado = Product.UpdateProductoBussines(productoAActualizar);
    Console.WriteLine($"El producto actualizado es \n ID: {productoActualizado.Id} \n Descripcion: {productoActualizado.Descripcion} \n Costo: {productoActualizado.Costo} \n Precio de venta: {productoActualizado.PrecioVenta} \n Stock: {productoActualizado.Stock} \n Id Usuario: {productoActualizado.IdUsuario}");
}

static void EliminarProducto()
{
    ProductoBusiness Product = new ProductoBusiness();
    Console.WriteLine("-----------------ELIMINAR UN PRODUCTO----------------------");
    Console.WriteLine("Ingrese el id del producto a eliminar: ");
    int idProducto = Convert.ToInt32(Console.ReadLine());
    int productoEliminado = Product.DeleteProductoBussines(idProducto);
    Console.WriteLine($"El producto eliminado es {productoEliminado}");
}



// Operaciones de ProductoVendido

static void ObtenerProductoVendido()
{
    ProductoVendidoBusiness ProductSell = new ProductoVendidoBusiness();
    Console.WriteLine("-----------------OBTENER UN PRODUCTO VENDIDO----------------------");
    Console.WriteLine("Ingrese el id del producto vendido a obtener: ");
    int idProductoVendido = Convert.ToInt32(Console.ReadLine());
    ProductoVendido productoVendido = ProductSell.GetProductoVendidoBussines(idProductoVendido);
    Console.WriteLine($"El producto vendido con id {productoVendido.Id} es \n ID: {productoVendido.Id} \n ID del Producto: {productoVendido.IdProducto} \n Stock: {productoVendido.Stock} \n ID de Venta: {productoVendido.IdVenta}");
}

static void ObtenerTodosLosProductosVendidos()
{
    ProductoVendidoBusiness ProductSell = new ProductoVendidoBusiness();
    Console.WriteLine("-----------------OBTENER TODOS LOS PRODUCTOS VENDIDOS----------------------");
    List<ProductoVendido> productosVendidos = ProductSell.GetAllProductosVendidosBussines();
    foreach (ProductoVendido pv in productosVendidos)
    {
        Console.WriteLine($"El producto vendido con id {pv.Id} es \n ID: {pv.Id} \n ID del Producto: {pv.IdProducto} \n Stock: {pv.Stock} \n ID de Venta: {pv.IdVenta}");
    }
}

static void CrearProductoVendido()
{
    ProductoVendidoBusiness ProductSell = new ProductoVendidoBusiness();
    Console.WriteLine("-----------------CREAR UN PRODUCTO VENDIDO----------------------");
    ProductoVendido productoVendidoNuevo = new ProductoVendido();
    Console.WriteLine("Ingrese el ID del producto vendido: ");
    productoVendidoNuevo.IdProducto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el stock del producto vendido: ");
    productoVendidoNuevo.Stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el ID de la Venta a la que pertenece: ");
    productoVendidoNuevo.IdVenta = Convert.ToInt32(Console.ReadLine());

    int idProductoVendidoNuevo = ProductSell.AddProductoVendidoBussines(productoVendidoNuevo);
    Console.WriteLine($"El id del producto vendido nuevo es {idProductoVendidoNuevo}");
}

static void ActualizarProductoVendido()
{
    ProductoVendidoBusiness ProductSell = new ProductoVendidoBusiness();
    Console.WriteLine("-----------------ACTUALIZAR UN PRODUCTO VENDIDO----------------------");
    ProductoVendido productoVendidoAActualizar = new ProductoVendido();
    Console.WriteLine("Ingrese el id del producto vendido a actualizar: ");
    productoVendidoAActualizar.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el ID del producto: ");
    productoVendidoAActualizar.IdProducto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el stock del producto vendido: ");
    productoVendidoAActualizar.Stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el ID de la Venta a la que pertenece: ");
    productoVendidoAActualizar.IdVenta = Convert.ToInt32(Console.ReadLine());

    ProductoVendido productoVendidoActualizado = ProductSell.UpdateProductoVendidoBussines(productoVendidoAActualizar);
    Console.WriteLine($"El producto vendido actualizado es \n ID: {productoVendidoActualizado.Id} \n ID del Producto: {productoVendidoActualizado.IdProducto} \n Stock: {productoVendidoActualizado.Stock} \n ID de Venta: {productoVendidoActualizado.IdVenta}");
}

static void EliminarProductoVendido()
{
    ProductoVendidoBusiness ProductSell = new ProductoVendidoBusiness();
    Console.WriteLine("-----------------ELIMINAR UN PRODUCTO VENDIDO----------------------");
    Console.WriteLine("Ingrese el id del producto vendido a eliminar: ");
    int idProductoVendido = Convert.ToInt32(Console.ReadLine());
    int productoVendidoEliminado = ProductSell.DeleteProductoVendidoBussines(idProductoVendido);
    Console.WriteLine($"El producto vendido eliminado es {productoVendidoEliminado}");
}


// Operaciones de Venta
static void ObtenerVenta()
{
    VentaBusiness Venta = new VentaBusiness();
    Console.WriteLine("-----------------OBTENER UNA VENTA----------------------");
    Console.WriteLine("Ingrese el id de la venta a obtener: ");
    int idVenta = Convert.ToInt32(Console.ReadLine());
    Venta venta = Venta.GetVentaBussines(idVenta);
    Console.WriteLine($"La venta con id {venta.Id} es \n ID: {venta.Id} \n Comentarios: {venta.Comentarios} \n IdUsuario: {venta.IdUsuario}");
}

static void ObtenerTodasLasVentas()
{
    VentaBusiness Venta = new VentaBusiness();
    Console.WriteLine("-----------------OBTENER TODAS LAS VENTAS----------------------");
    List<Venta> ventas = Venta.GetAllVentasBussines();
    foreach (Venta v in ventas)
    {
        Console.WriteLine($"La venta con id {v.Id} es \n ID: {v.Id} \n Comentarios: {v.Comentarios} \n IdUsuario: {v.IdUsuario}");
    }
}

static void CrearVenta()
{
    VentaBusiness Venta = new VentaBusiness();
    Console.WriteLine("-----------------CREAR UNA VENTA----------------------");
    Venta ventaNueva = new Venta();
    Console.WriteLine("Ingrese los comentarios de la venta: ");
    ventaNueva.Comentarios = Console.ReadLine();
    Console.WriteLine("Ingrese el id del usuario: ");
    ventaNueva.IdUsuario = Convert.ToInt32(Console.ReadLine());

    int idVentaNueva = Venta.AddVentaBussines(ventaNueva);
    Console.WriteLine($"El id de la venta nueva es {idVentaNueva}");
}

static void ActualizarVenta()
{
    VentaBusiness Venta = new VentaBusiness();
    Console.WriteLine("-----------------ACTUALIZAR UNA VENTA----------------------");
    Venta ventaAActualizar = new Venta();
    Console.WriteLine("Ingrese el id de la venta a actualizar: ");
    ventaAActualizar.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese los comentarios de la venta: ");
    ventaAActualizar.Comentarios = Console.ReadLine();
    Console.WriteLine("Ingrese el id del usuario: ");
    ventaAActualizar.IdUsuario = Convert.ToInt32(Console.ReadLine());

    Venta ventaActualizada = Venta.UpdateVentaBussines(ventaAActualizar);
    Console.WriteLine($"La venta actualizada es \n ID: {ventaActualizada.Id} \n Comentarios: {ventaActualizada.Comentarios} \n IdUsuario: {ventaActualizada.IdUsuario}");
}

static void EliminarVenta()
{
    VentaBusiness Venta = new VentaBusiness();
    Console.WriteLine("-----------------ELIMINAR UNA VENTA----------------------");
    Console.WriteLine("Ingrese el id de la venta a eliminar: ");
    int idVenta = Convert.ToInt32(Console.ReadLine());
    int ventaEliminada = Venta.DeleteVentaBussines(idVenta);
    Console.WriteLine($"La venta eliminada es {ventaEliminada}");
}