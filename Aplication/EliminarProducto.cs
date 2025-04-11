using ProyectoParcialTucoCrud.Domain.Interfaces;

namespace Application
{
    public class EliminarProducto
    {
        private readonly IProductoRepository _repo;

        public EliminarProducto(IProductoRepository repo)
        {
            _repo = repo;
        }

        public bool Ejecutar(int idProducto)
        {
            return _repo.EliminarProducto(idProducto);
        }
    }
}
