using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoParcialTucoCrud.Domain;
using ProyectoParcialTucoCrud.Domain.Entities;



namespace ProyectoParcialTucoCrud.Domain
{
    public interface IVentaRepository
    {
        Task<Entities.Venta> CrearVentaAsync(Entities.Venta venta); // Especifica el namespace
        Task<List<Entities.Venta>> ObtenerTodasVentasAsync();
        Task<Entities.Venta?> ObtenerVentaPorIdAsync(int idVenta);
        Task ActualizarVentaAsync(Entities.Venta venta);
        Task<bool> EliminarVentaAsync(int idVenta);

    }
}