using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using examenparcial1.repository.BD;


namespace examenparcial1.repository.Sucursal
{
    internal class Sucursalrepositorio
    {
        public class sucursalrepositorio
        {
            IDbConnection conexiondb;

            public sucursalrepositorio(string connectionString)
            {
                conexiondb = new Conexionbd(connectionString).OpenConnection();

            }

            public bool AgregarSucursal(Sucursal sucursal)
            {

                conexiondb.Execute("INSERT INTO public.Sucursal(idsucursal, Descripcion, Direccion, Telefono, Whatsapp, Mail, Estado)" +
                    $"VALUES(@Descripcion, @Direccion @Telefono @Whatsapp @Mail @Estado)", sucursal);

                return true;



            }

            public bool Update(Sucursal sucursal)
            {

                conexiondb.Execute("UPDATE public.Sucursal SET Descripcion='', Direccion='', Telefono=0, Whatsapp=0, Mail='', Estado=0 WHERE @idsucursal)", sucursal);
                return true;


            }

            public bool Delete(int id)
            {

                conexiondb.Execute($"DELETE FROM public.Sucursal WHERE @idsucursal;");

                return true;
            }

            public Sucursal GetSucursalById(int idsucursal)
            {
                string sql = "SELECT * FROM Sucursal WHERE idsucursal = @idsucursal";
                Sucursal sucursal = conexiondb.QuerySingleOrDefault<Sucursal>(sql, new { Id = idsucursal });
                return sucursal;
            }


            public IEnumerable<Sucursal> List()
            {
                return conexiondb.Query<Sucursal>("select * from sucursal");
            }


        }
    }
}
