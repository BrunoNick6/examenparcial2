using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examenparcial1.repository.Sucursal;
using Dapper;
using static examenparcial1.repository.Sucursal.Sucursalrepositorio;

namespace examenparcial1.service
{

    public class SucursalServicio
    {
        private readonly Sucursalrepositorio _repositorio;

        public SucursalServicio(Sucursalrepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public bool CrearSucursal(Sucursal sucursal)
        {
            // Aquí puedes añadir lógica adicional, como validaciones
            return _repositorio.AgregarSucursal(sucursal);
        }

        public bool ActualizarSucursal(Sucursal sucursal)
        {
            // Aquí puedes añadir lógica adicional, como validaciones
            return _repositorio.Update(sucursal);
        }

        public bool EliminarSucursal(int id)
        {
            // Aquí puedes añadir lógica adicional, como comprobaciones antes de eliminar
            return _repositorio.Delete(id);
        }

        public Sucursal ObtenerSucursalPorId(int id)
        {
            return _repositorio.GetSucursalById(id);
        }

        public IEnumerable<Sucursal> ListarSucursales()
        {
            return _repositorio.List();
        }
    }



