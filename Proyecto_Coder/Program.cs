using Proyecto_Coder;

Usuario usuario = new Usuario();
Venta venta = new Venta();
Producto producto = new Producto();
ProductoVendido productoVendido = new ProductoVendido();

Console.WriteLine("Bienvenido al sistema de ventas");
Console.WriteLine("Ingrese su nombre de usuario");
usuario.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su Apellido");
usuario.Apellido = Console.ReadLine();
Console.WriteLine("Ingrese su nombre");
usuario.NombreUsuario = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña");
usuario.Contrasenia = Console.ReadLine();
Console.WriteLine("Ingrese su mail");
usuario.Mail = Console.ReadLine();
// Asignar un id al usuario
usuario.Id = 1;

Console.WriteLine("Usario registrado con exito");
Console.WriteLine($"El usuario creado es: {usuario.Nombre} {usuario.Apellido} {usuario.NombreUsuario} {usuario.Contrasenia} {usuario.Mail}");
