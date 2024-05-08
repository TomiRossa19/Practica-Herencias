namespace WireTechService
{
    public class Logica
    {

        public int Tipo { get; set; }
        public int MyProperty { get; set; }
        public List<Pago> listapagos { get; set; }

        public Pago pagos = new Pago();

        public void CargarEntidades(int Tipo)
        {
            while (Tipo != 1) {
                
               
            switch (Tipo)
                {
                    case 2:

                        

                        int codpago = codpago + 1;
                        DateTime fechapago = DateTime.Now;
                        Console.WriteLine("Ingrese su DNI: ");
                        int DNI = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su código de servicio: ");
                        int codserv = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su importe: ");
                        int imp = int.Parse(Console.ReadLine());

                        pagos.CargarPago(codpago, fechapago, DNI, codserv, imp);
                        return;
                        

                }
            }
        }

        //public void Retiro();
        //public void Reporte();
    }
}
