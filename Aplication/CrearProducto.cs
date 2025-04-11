using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Domain.Interfaces;

namespace Application
{
    public class CrearProducto
    {
        private readonly IProductoRepository _repo;

        public CrearProducto(IProductoRepository repo)
        {
            _repo = repo;
        }

        public void Ejecutar(Producto producto)
        {
            _repo.AgregarProducto(producto);
        }
    }
}
