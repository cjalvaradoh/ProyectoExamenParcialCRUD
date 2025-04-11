using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Domain.Interfaces;

namespace Application
{
    public class ActualizarProducto
    {
        private readonly IProductoRepository _repo;

        public ActualizarProducto(IProductoRepository repo)
        {
            _repo = repo;
        }

        public void Ejecutar(Producto producto)
        {
            _repo.ActualizarProducto(producto);
        }
    }
}
