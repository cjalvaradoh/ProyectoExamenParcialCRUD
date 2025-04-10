using ProyectoParcialTucoCrud.Domain;
using ProyectoParcialTucoCrud.Venta.Aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcialTucoCrud.Application
{
    public class ModificarVentaCommand
    {
        public int IdVenta { get; set; }
        public string Fecha { get; set; }  
        public string Cliente { get; set; }
        public string MetodoPago { get; set; }
        public decimal TotalVenta { get; set; }
    }

    public class ModificarVentaHandler
    {
        private readonly IVentaRepository _ventaRepository;

        // Constructor con inyección de dependencias
        public ModificarVentaHandler(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository ?? throw new ArgumentNullException(nameof(ventaRepository));
        }

        // Método Handle que recibe el comando y procesa la modificación
        public async Task<bool> Handle(ModificarVentaCommand command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command), "El comando no puede ser nulo.");

            // Obtener la venta por su ID
            var ventaExistente = await _ventaRepository.ObtenerVentaPorIdAsync(command.IdVenta);

            if (ventaExistente == null)
                throw new KeyNotFoundException($"La venta con el ID {command.IdVenta} no existe.");

            // Actualizar los valores de la venta existente con los nuevos valores del comando
            ventaExistente.Fecha = command.Fecha;
            ventaExistente.IdVenta = command.IdVenta;
            ventaExistente.Cliente = command.Cliente;
            ventaExistente.MetodoPago = command.MetodoPago;
            ventaExistente.TotalVenta = command.TotalVenta;

            // Llamar al repositorio para actualizar la venta en el almacenamiento (archivo CSV, base de datos, etc.)
            try
            {
                await _ventaRepository.ActualizarVentaAsync(ventaExistente);
                return true; // Si la actualización fue exitosa
            }
            catch (Exception ex)
            {
                // Manejo de excepciones si algo sale mal al actualizar la venta
                Console.WriteLine($"Error al modificar la venta: {ex.Message}");
                return false;
            }
        }
    }
}
