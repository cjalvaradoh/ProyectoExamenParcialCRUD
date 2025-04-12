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
        public Domain.Entities.Venta Venta { get; internal set; }
    }


    public class CrearVentaHandler
    {
        private readonly IVentaRepository _ventaRepository;

        public CrearVentaHandler(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }

        public async Task Handle(CrearVentaCommand command)
        {
            if (command.Venta == null)
                throw new ArgumentNullException(nameof(command.Venta));

            await _ventaRepository.CrearVentaAsync(command.Venta);

            // Guardar todos los registros en archivo después de crear la venta
            await GuardarVentasEnArchivo();
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
