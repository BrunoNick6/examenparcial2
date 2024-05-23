using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenparcial1.repository.Factura
{
    public class Factura
    {
        public int Idfact { get; set; }
        public int Idcliente { get; set; }
        public string Nrofactu { get; set; }
        public string Fechahora { get; set; }
        public string Total { get; set; }
        public string Total5 { get; set; }
        public string Total10 { get; set; }
        public string Totaliva { get; set; }
        public string Totaldeletras { get; set; }
        public string Sucursal { get; set; }

        public Factura(string numeroFactura, string fechahora, string total, string totalIva5, string totalIva10, string totaliva, string totalLetras, string sucursal)
        {
            Nrofactu = numeroFactura;
            Fechahora = fechahora;
            Total = total;
            Total5 = totalIva5;
            Total10 = totalIva10;
            Totaliva = totaliva;
            Totaldeletras = totalLetras;
            Sucursal = sucursal;
        }
    }


}


