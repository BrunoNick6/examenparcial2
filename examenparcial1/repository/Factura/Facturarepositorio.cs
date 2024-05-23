using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using examenparcial1.repository.Clientes;
using examenparcial1.repository.BD;


namespace examenparcial1.repository.Factura
{
    public class Facturarepositorio
    {
        IDbConnection conexiondb;

        public Facturarepositorio(string connectionString)
        {
            conexiondb = new Conexionbd(connectionString).OpenConnection();

        }


        public bool AgregarFactura(Factura factura)
        {



            conexiondb.Execute("INSERT INTO public (Idfact, Idcliente, Nrofactu, Fechahora, Total, Total5, Total10, Totaliva, Totaldeletras, )",factura);


            return true;


        }

        public bool Update(Factura factura)
        {

            conexiondb.Execute("UPDATE public.Factura SET Idfactu=0, Nrofactu='', Fechahora='', Total='', Total5='', Total10='', Totaliva='', Totaldeletras='', Sucursal='' WHERE @Idfact)", factura);
            return true;


        }

        public bool Delete(int id)
        {

            conexiondb.Execute($"DELETE FROM public.Factura WHERE @Idfact;");

            return true;
        }

        public Factura GetClienteById(int Id)
        {
            string sql = "SELECT * FROM factura WHERE Idfact = @Idfact";
            Factura factura = conexiondb.QuerySingleOrDefault<Factura>(sql, new { Id });
            return factura;
        }

        public IEnumerable<Factura> List()
        {
            return conexiondb.Query<Factura>("select * from Factura");
        }
    }
}