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

        public ModificarVentaHandler(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository ?? throw new ArgumentNullException(nameof(ventaRepository));
        }

        public async Task<bool> Handle(ModificarVentaCommand command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command), "El comando no puede ser nulo.");

            var ventaExistente = await _ventaRepository.ObtenerVentaPorIdAsync(command.IdVenta);

            if (ventaExistente == null)
                throw new KeyNotFoundException($"La venta con el ID {command.IdVenta} no existe.");

            ventaExistente.Fecha = command.Fecha;
            ventaExistente.IdVenta = command.IdVenta;
            ventaExistente.Cliente = command.Cliente;
            ventaExistente.MetodoPago = command.MetodoPago;
            ventaExistente.TotalVenta = command.TotalVenta;

            try
            {
                await _ventaRepository.ActualizarVentaAsync(ventaExistente);
                await GuardarVentasEnArchivo();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar la venta: {ex.Message}");
                return false;
            }
        }

        private async Task GuardarVentasEnArchivo()
        {
            var ventas = await _ventaRepository.ObtenerTodasVentasAsync();
            var rutaArchivo = "ventas.csv";

            var lineas = new List<string>
        {
            "IdVenta,Fecha,Cliente,MetodoPago,TotalVenta"
        };

            foreach (var venta in ventas)
            {
                lineas.Add($"{venta.IdVenta},{venta.Fecha},{venta.Cliente},{venta.MetodoPago},{venta.TotalVenta}");
            }

            await File.WriteAllLinesAsync(rutaArchivo, lineas);
        }
    }

}
