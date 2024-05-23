using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using examenparcial1.repository.BD;

namespace examenparcial1.repository.Clientes
{
    public class clienterepositorio
    {
        IDbConnection conexiondb;

        public clienterepositorio(string connectionString)
        {
            conexiondb = new Conexionbd(connectionString).OpenConnection();

        }


        public bool AgregarCliente(Cliente cliente)
        {



            conexiondb.Execute("INSERT INTO public (nombre, apellido, documento, mail, celular, estado) " +
                                    "VALUES (@Nombre, @Apellido, @Documento, @Mail, @Celular, @Estado)", cliente);


            return true;


        }

        public bool Update(Cliente cliente)
        {

            conexiondb.Execute("UPDATE public.Cliente SET Nombre='', Apellido='', Documento=0, Direccion=0, Mail='', Celular='', Estado='' WHERE @Id)", cliente);
            return true;


        }

        public bool Delete(int id)
        {

            conexiondb.Execute($"DELETE FROM public.Cliente WHERE @Id;");

            return true;
        }

        public Cliente GetClienteById(int Id)
        {
            string sql = "SELECT * FROM Cliente WHERE Id = @Id";
            Cliente cliente = conexiondb.QuerySingleOrDefault<Cliente>(sql, new { Id });
            return cliente;
        }

        public IEnumerable<Cliente> List()
        {
            return conexiondb.Query<Cliente>("select * from cliente");
        }
    }
}



