using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenparcial1.repository.Clientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Idbanco { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Celular { get; set; }
        public string Estado { get; set; }

        public Cliente(int id, int idbanco, string nombre, string apellido, string documento, string direccion, string mail, string celular, string estado)
        {
            Id = id;
            Idbanco = idbanco;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Direccion = direccion;
            Mail = mail;
            Celular = celular;
            Estado = estado;
        }
        public bool ValidarDatosCliente()
        {
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido) || string.IsNullOrEmpty(Documento))
            {
                Console.WriteLine("El nombre el apellido y la Cedula son campos obligatorios.");
                return false;
            }

            if (Nombre.Length < 3 || Apellido.Length < 3 || Documento.Length < 3)
            {
                Console.WriteLine("El nombre el Apellido y la Cedula deben tener por lo menos 3 caracteres.");
                return false;
            }

            if (Mail.ToString().Length != 10)
            {
                Console.WriteLine("El celular debe tener 10 dígitos.");
                return false;
            }

            return true;
        }
    }
}




