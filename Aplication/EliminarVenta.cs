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
            var ventaExistente = await _ventaRepository.ObtenerVentaPorIdAsync(command.IdVenta);
            if (ventaExistente == null)
                return false;

            var resultado = await _ventaRepository.EliminarVentaAsync(command.IdVenta);

            if (resultado)
                await GuardarVentasEnArchivo();

            return resultado;
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
