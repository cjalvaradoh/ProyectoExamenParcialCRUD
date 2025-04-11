using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Domain.Interfaces;
using System.Collections.Generic;

namespace Application
{
    public class ObtenerTodosLosProductos
    {
        private readonly IProductoRepository _repo;

        public ObtenerTodosLosProductos(IProductoRepository repo)
        {
            _repo = repo;
        }

        public List<Producto> Ejecutar()
        {
            return _repo.ObtenerTodosLosProductos();
        }
    }
}
