using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoParcialTucoCrud.Domain;
using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Aplication;

namespace ProyectoParcialTucoCrud.Aplication
{
    public class EliminarVentaCommand
    {
        public int IdVenta { get; set; }

    }

    public class EliminarVentaHandler
    {
        private readonly IVentaRepository _ventaRepository;

        public EliminarVentaHandler(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }

        public async Task<bool> Handle(EliminarVentaCommand command)
        {
            // Validación básica del ID
            if (command.IdVenta <= 0)
            {
                throw new ArgumentException("El ID de venta debe ser mayor que cero");
            }

            // Verificar si la venta existe
            var ventaExistente = await _ventaRepository.ObtenerVentaPorIdAsync(command.IdVenta);
            if (ventaExistente == null)
            {
                throw new KeyNotFoundException($"No se encontró una venta con el ID {command.IdVenta}");
            }

            // Eliminar la venta
            return await _ventaRepository.EliminarVentaAsync(command.IdVenta);
        }
    }
}
