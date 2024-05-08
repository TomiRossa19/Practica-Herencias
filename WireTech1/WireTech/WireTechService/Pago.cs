using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireTechService
{
    public class Pago : Logica
    {
        public int NumPag { get; set; }
        public DateTime FechaCobro { get; set; }
        public int DNI { get; set; }

        public int CodServ { get; set; }

        public int Imp { get; set; }
       
    }
}
