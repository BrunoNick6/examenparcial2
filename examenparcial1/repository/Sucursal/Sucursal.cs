using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenparcial1.repository.Sucursal
{
    internal class Sucursal
    {
        public int idsucursal { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Whatsapp { get; set; }
        public string Mail { get; set; }
        public string Estado { get; set; }

        public Sucursal(int idsucur, string descripcion, string direccion, int telefono, int whatsapp, string mail, string estado)
        {
            idsucursal = idsucur;
            Descripcion = descripcion;
            Direccion = direccion;
            Telefono = telefono;
            Whatsapp = whatsapp;
            Mail = mail;
            Estado = estado;



        }
    }
}

