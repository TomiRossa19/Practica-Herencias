using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireTechService
{
    public class Pago
    {
        public int NumPag { get; set; }
        public DateTime FechaCobro { get; set; }
        public int DNI { get; set; }

        public int CodServ { get; set; }
        public void CargarPago(int NumPag, DateTime FechaCobro, int DNI, int CodServ)
        {
            Pago pagos = new Pago();
            pagos.NumPag = NumPag;
            pagos.FechaCobro = FechaCobro;
            pagos.DNI = DNI;
            pagos.CodServ = CodServ;

        }
    }
}
