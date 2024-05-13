// See https://aka.ms/new-console-template for more information
using WireTechService;

Logica logica = new Logica();

Console.WriteLine("¿Qué desea hacer? Cerrar el programa (1), cargar un pago de servicio (2), Soy proveedor (3),  Agregar Servicio(4), (5)");
int tipo = int.Parse(Console.ReadLine());

while (tipo != 1)
{


    switch (tipo)
    {
        case 2:


            Console.WriteLine("Ingrese su código de pago: ");
            int numpag = int.Parse(Console.ReadLine());
            DateTime fechapago = DateTime.Now;
            Console.WriteLine("Ingrese su DNI: ");
            int DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su código de servicio: ");
            int codserv = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su importe: ");
            int imp = int.Parse(Console.ReadLine());

            logica.CargarPago(numpag, fechapago, DNI, codserv, imp);
            return;

            case 3:
            Console.WriteLine("¿Desea cobrar(1) o retirar dinero (2)?");
            int pregunta = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el país desde donde opera [Brasil(1), Argentina (2), México(3)]: ");
            int pais = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su código de proveedor: ");
            int codprov = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sitio donde opera: ");
            string sitio = Console.ReadLine();
            Console.WriteLine("Ingrese el monto que desea retirar: ");
            int monto = int.Parse(Console.ReadLine());

            logica.CargarCobro(pregunta, pais, codprov, sitio, monto);
            return;

        case 4:
            Console.WriteLine("Ingrese el nombre del servicio");
            string nomserv = Console.ReadLine();

            Console.WriteLine("Ingrese la descripción del servicio");
            string descserv = Console.ReadLine();
            Console.WriteLine("Ingrese su código de proveedor: ");
            int codprovserv = int.Parse(Console.ReadLine());
            

            logica.AgregarServicio(nomserv, descserv, codprovserv);
            return;

            return;
    }
    Console.WriteLine("¿Qué desea hacer? Cerrar el programa (1), Cargar un pago (2)");
    tipo = int.Parse(Console.ReadLine());
}