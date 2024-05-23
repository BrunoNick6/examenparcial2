using examenparcial1.repository.Clientes;
using examenparcial1.repository.Factura;
using examenparcial1.repository.Sucursal;


class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Host=localhost;port=5432;Database=parcial1;Username=postgres;Password=bruno2003;";

        
        clienterepositorio clienterepositorio = new clienterepositorio(connectionString);
        Facturarepositorio facturarepositorio = new Facturarepositorio(connectionString);

        
        Sucursal nuevoCliente = new Sucursal(1, 1, "Julio", "Benitez", "123123123", "Dirección", "email@gmail.com", "123123123", "activo");
        clienterepositorio.Add(nuevoCliente);

        
        Console.WriteLine("Listado de facturas:");
        foreach (var factura in facturarepositorio.ObtenerTodasFacturas())
        {
            Console.WriteLine($"ID: {factura.Idfact}, Numero: {factura.Nrofactu}, Total: {factura.Total}");
        }



        Console.WriteLine("Operacion completada.");
    }
}

    
    

       
