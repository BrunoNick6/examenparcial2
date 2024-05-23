using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examenparcial1.repository.Clientes;

namespace examenparcial1.service
{
    public class Clienteservicio
    {
        public clienterepositorio RepositorioCliente;

        public Clienteservicio(string connection)
        {
            RepositorioCliente = new clienterepositorio(connection);
        }

        public void insertar(Cliente cliente)
        {
            if (validacionDatos(cliente))
                RepositorioCliente.Add(cliente);
            else
                throw new Exception("Error en la validacion de su dato, por favor verifique");
        }

        private bool validacionDatos(Cliente cliente)
        {
            if (cliente == null)
                return false;
            if (string.IsNullOrEmpty(cliente.Nombre))
                return false;
            if (string.IsNullOrEmpty(cliente.Apellido))
                return false;
            if (string.IsNullOrEmpty(cliente.Documento))
                return false;
            if (string.IsNullOrEmpty(cliente.Mail))
                return false;
            if (string.IsNullOrEmpty(cliente.Celular))
                return false;
            if (string.IsNullOrEmpty(cliente.Estado))
                return false;
            if (string.IsNullOrEmpty(cliente.Estado))
                return false;

            return true;
        }
    }
}


