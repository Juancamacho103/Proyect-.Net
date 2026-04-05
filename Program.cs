// SISTEMA DE INVENTARIO - Módulo 2 Completo
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

int cantidadProductos = 0;
decimal valorTotalInventario = 0.00m;
bool sistemaActivo = true;

MostrarBanner();
bool continuar = true;

void MostrarMenu()
{
    Console.WriteLine("Comandos disponibles: listar, agregar, buscar, salir");
    Console.WriteLine();
}

while (continuar)
{
    MostrarMenu();
    Console.Write("Ingrese un comando: ");
    string Funcion = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(Funcion))
    {
        Funcion = "salir"; // Comando por defecto
    }
    string comando = LeerEntrada(Funcion);
    continuar = ProcesarComando(comando);
}

string LeerEntrada(string prompt)
{
    string entrada = prompt.Trim().ToLower();
    Console.WriteLine($"El comando ingresado fue: {entrada}");
    return entrada;
}

void MostrarBanner()
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.WriteLine();
    Console.WriteLine($"Versión: {version}");
    Console.WriteLine($".NET: {Environment.Version}");
    Console.WriteLine($"Sistema: {Environment.OSVersion.Platform}");
    Console.WriteLine();
}

void MostrarAyuda()
{
    Console.WriteLine("USO: dotnet run [opciones]");
    Console.WriteLine();
    Console.WriteLine("OPCIONES:");
    Console.WriteLine("  --help, -h       Muestra esta ayuda");
    Console.WriteLine("  --version, -v    Muestra la versión");
    Console.WriteLine();
    Console.WriteLine("COMANDOS INTERACTIVOS:");
    Console.WriteLine("  listar           Lista productos del inventario");
    Console.WriteLine("  agregar          Agrega un nuevo producto");
    Console.WriteLine("  buscar           Busca productos");
    Console.WriteLine("  salir            Sale del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine("  dotnet run");
    Console.WriteLine("  dotnet run --version");
}

bool ProcesarComando(string comando)
{
    switch (comando)
    {
        case "listar":
            ListarProductos();
            return true;
        case "agregar":
            AgregarProducto();
            return true;
        case "buscar":
            BuscarProducto();
            return true;
        case "help":
            case "--help":
            MostrarAyuda();
            return true;
        case "salir":
            case "exit":
            Console.WriteLine("Saliendo del programa...");
            Environment.Exit(0);
            return false;
        default:
            return false;
    }
}

void ListarProductos()
{
    Console.WriteLine($"📦 Productos en inventario: {cantidadProductos}");
    Console.WriteLine($"💰 Valor total: ${valorTotalInventario:N2}");
}

void AgregarProducto()
{
    Console.WriteLine("📝 Función agregar (se implementará en Módulo 3)");
}

void BuscarProducto()
{
    Console.WriteLine("🔍 Función buscar (se implementará en Módulo 4)");
}