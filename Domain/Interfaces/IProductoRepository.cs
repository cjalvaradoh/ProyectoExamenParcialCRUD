using System.Collections.Generic;
using ProyectoParcialTucoCrud.Domain.Entities;

namespace ProyectoParcialTucoCrud.Domain.Interfaces
{
    public interface IProductoRepository
    {
        void AgregarProducto(Producto producto);
        List<Producto> ObtenerTodosLosProductos();
        Producto? ObtenerProductoPorId(int idProducto);
        void ActualizarProducto(Producto producto);
        bool EliminarProducto(int idProducto);
    }
}
