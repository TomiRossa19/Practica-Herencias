using System.Net;

namespace WireTechService
{
    public class Logica
    {

        public int Tipo { get; set; }
        public int MyProperty { get; set; }
        public List<Pago> listapagos { get; set; }
        public List<Proveedor> listaproveedores { get; set; }
        public List<Servicio> listaservicios { get; set; }


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

        public void CargarCobro(int Pregunta,int Pais, int CodProv, string Sitio, int Monto)
        {
            Proveedor proveedores = new Proveedor();
            if (listaproveedores.Count == 0) CodProv = 1;
            else CodProv = listaproveedores.Max(x => x.CodProv) + 1;
            proveedores.CodProv = CodProv;
            proveedores.Pais = Pais;
            proveedores.Sitio= Sitio;
            proveedores.Monto = Monto;

            if (Pregunta==1)
            {
                proveedores.Saldo = proveedores.Saldo + Monto;

            }else
            {
                proveedores.Saldo = proveedores.Saldo - Monto;
            }

            listaproveedores.Add(proveedores);

        }
        public void AgregarServicio(string NomServ, string DescServ, int CodProvServ)
        {
            int CodServ;
            Servicio servicios = new Servicio();
            if (listaservicios.Count==0) 
                CodServ= 1;
            else CodServ=listaservicios.Max(x => x.CodServ) + 1;
            servicios.CodServ= CodServ;
            servicios.NomServ = NomServ;
            servicios.DescServ= DescServ;
            servicios.CodProvServ= CodProvServ;

        }

        //public void CargarEntidades()
        //public void Retiro();
        //public void Reporte();
    }
}
