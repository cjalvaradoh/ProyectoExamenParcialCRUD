using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ProyectoParcialTucoCrud.Domain;
using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Domain.Interfaces;

public class VentaCsvRepository : IVentaRepository
{
    private readonly string _filePath = "ventas.csv"; // Ruta del archivo CSV
    //NOSE SI FUNCIONA, ME QUEDE EN SOLO AGREGAR NUEVO REGISTRO, ESTO ES PARA DESCARGAR EL REGISTRO EN UN ARCHIVO CSV.
    // Crear una nueva venta y agregarla al archivo CSV
    public async Task<Venta> CrearVentaAsync(Venta venta)
    {
        // Generar IdVenta automáticamente
        var idVenta = ObtenerUltimoIdVenta() + 1;

        // Asignar la fecha actual si no se proporciona
        var fecha = venta.Fecha == default ? DateTime.Now : venta.Fecha;

        // Crear el objeto Venta con los datos proporcionados
        var nuevaVenta = new Venta
        {
            IdVenta = idVenta,
            Fecha = fecha,
            Cliente = venta.Cliente,
            MetodoPago = venta.MetodoPago,
            TotalVenta = venta.TotalVenta
        };

        // Escribir la nueva venta al archivo CSV
        var line = $"{nuevaVenta.IdVenta},{nuevaVenta.Fecha.ToString("yyyy-MM-dd")},{nuevaVenta.Cliente},{nuevaVenta.MetodoPago},{nuevaVenta.TotalVenta}";
        await File.AppendAllTextAsync(_filePath, line + Environment.NewLine);

        return nuevaVenta;
    }

    // Obtener todas las ventas desde el archivo CSV
    public async Task<List<Venta>> ObtenerTodasVentasAsync()
    {
        var ventas = new List<Venta>();

        if (File.Exists(_filePath))
        {
            var lines = await File.ReadAllLinesAsync(_filePath);

            foreach (var line in lines.Skip(1)) // Saltar el encabezado
            {
                var parts = line.Split(',');

                if (parts.Length == 5)
                {
                    var venta = new Venta
                    {
                        IdVenta = int.Parse(parts[0]),
                        Fecha = DateTime.ParseExact(parts[1], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        Cliente = parts[2],
                        MetodoPago = parts[3],
                        TotalVenta = decimal.Parse(parts[4])
                    };

                    ventas.Add(venta);
                }
            }
        }

        return ventas;
    }

    // Obtener una venta por su Id
    public async Task<Venta?> ObtenerVentaPorIdAsync(int idVenta)
    {
        var ventas = await ObtenerTodasVentasAsync();
        return ventas.FirstOrDefault(v => v.IdVenta == idVenta);
    }

    // Actualizar una venta en el archivo CSV
    public async Task ActualizarVentaAsync(Venta venta)
    {
        var ventas = await ObtenerTodasVentasAsync();
        var ventaExistente = ventas.FirstOrDefault(v => v.IdVenta == venta.IdVenta);

        if (ventaExistente != null)
        {
            // Eliminar la venta existente
            ventas.Remove(ventaExistente);
            ventas.Add(venta); // Agregar la venta actualizada

            // Sobrescribir el archivo con las ventas actualizadas
            var lines = ventas.Select(v => $"{v.IdVenta},{v.Fecha.ToString("yyyy-MM-dd")},{v.Cliente},{v.MetodoPago},{v.TotalVenta}");
            await File.WriteAllLinesAsync(_filePath, lines);
        }
    }

    // Eliminar una venta del archivo CSV
    public async Task<bool> EliminarVentaAsync(int idVenta)
    {
        var ventas = await ObtenerTodasVentasAsync();
        var ventaExistente = ventas.FirstOrDefault(v => v.IdVenta == idVenta);

        if (ventaExistente != null)
        {
            ventas.Remove(ventaExistente); // Eliminar la venta

            // Sobrescribir el archivo con las ventas restantes
            var lines = ventas.Select(v => $"{v.IdVenta},{v.Fecha.ToString("yyyy-MM-dd")},{v.Cliente},{v.MetodoPago},{v.TotalVenta}");
            await File.WriteAllLinesAsync(_filePath, lines);

            return true;
        }

        return false;
    }

    // Método para obtener el último IdVenta del archivo CSV
    private int ObtenerUltimoIdVenta()
    {
        if (!File.Exists(_filePath)) return 0;

        var lines = File.ReadAllLines(_filePath);
        if (lines.Length == 1) return 0; // Si solo hay el encabezado, retornar 0

        var lastLine = lines.Last();
        var lastIdVenta = int.Parse(lastLine.Split(',')[0]);
        return lastIdVenta;
    }
}
