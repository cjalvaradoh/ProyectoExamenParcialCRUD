using ProyectoParcialTucoCrud.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcialTucoCrud.Venta.Aplication
{
    public class CrearVentaCommand
    {
        public int IdVenta { get; internal set; }
        public string Cliente { get; set; }   
        public string MetodoPago { get; set; } 
        public decimal TotalVenta { get; set; }
        public string Fecha { get; internal set; }
    }


    public class CrearVentaHandler
    {
        private readonly IVentaRepository _ventaRepository;

        public CrearVentaHandler(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository ?? throw new ArgumentNullException(nameof(ventaRepository));
        }

        public async Task<bool> Handle(CrearVentaCommand command)
        {
            try
            {
                if (command == null)
                    throw new ArgumentNullException(nameof(command));

                if (string.IsNullOrEmpty(command.MetodoPago))
                    throw new ArgumentException("El método de pago no puede estar vacío.");
                if (command.TotalVenta <= 0)
                    throw new ArgumentException("El TotalVenta debe ser mayor que 0.");
                if (string.IsNullOrEmpty(command.Cliente))
                    throw new ArgumentException("El Cliente no puede estar vacío.");

                var venta = new Domain.Entities.Venta
                {
                    IdVenta = command.IdVenta,  // Asignamos el IdVenta directamente desde el command
                    Cliente = command.Cliente,
                    Fecha = command.Fecha,
                    MetodoPago = command.MetodoPago,
                    TotalVenta = command.TotalVenta
                };

                var ventaCreada = await _ventaRepository.CrearVentaAsync(venta);

                return ventaCreada != null && ventaCreada.IdVenta > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear venta: {ex.Message}");
                return false;
            }
        }
    }

}
