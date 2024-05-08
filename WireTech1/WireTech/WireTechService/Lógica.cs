using System.Net;

namespace WireTechService
{
    public class Logica
    {

        public int Tipo { get; set; }
        public int MyProperty { get; set; }
        public List<Pago> listapagos { get; set; }
        public List<Proveedor> listaproveedores { get; set; }


        public void CargarPago(int NumPag, DateTime FechaCobro, int DNI, int CodServ, int Imp)
        {
            Pago pagos = new Pago();
            if (listapagos.Count == 0) NumPag = 1;
            else NumPag = listapagos.Max(x => x.NumPag) + 1;
            pagos.NumPag = NumPag;
            pagos.FechaCobro = FechaCobro;
            pagos.DNI = DNI;
            pagos.CodServ = CodServ;
            pagos.Imp = Imp;

            listapagos.Add(pagos);
        }

        public void CargarCobro(int Pais, int CodProv, string Sitio, int Monto)
        {
            Proveedor proveedores = new Proveedor();
            if (listaproveedores.Count == 0) CodProv = 1;
            else CodProv = listaproveedores.Max(x => x.CodProv) + 1;
            proveedores.CodProv = CodProv;
            proveedores.Pais = Pais;
            proveedores.Sitio= Sitio;
            proveedores.Monto = Monto;

            listaproveedores.Add(proveedores);

        }

        //public void CargarEntidades()
        //public void Retiro();
        //public void Reporte();
    }
}
