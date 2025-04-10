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
    private readonly string _filePath = "ventas.csv";

    public async Task ActualizarVentaAsync(Venta venta)
    {
        var ventas = await ObtenerTodasVentasAsync();
        var ventaExistente = ventas.FirstOrDefault(v => v.IdVenta == venta.IdVenta);

        if (ventaExistente == null)
        {
            throw new KeyNotFoundException($"La venta con el ID {venta.IdVenta} no existe.");
        }

        // Actualizar los valores de la venta existente
        ventaExistente.Fecha = venta.Fecha;
        ventaExistente.Cliente = venta.Cliente;
        ventaExistente.MetodoPago = venta.MetodoPago;
        ventaExistente.TotalVenta = venta.TotalVenta;

        // Sobrescribir el archivo con las ventas actualizadas
        var lines = ventas.Select(v => $"{v.IdVenta},{v.Fecha},{v.Cliente},{v.MetodoPago},{v.TotalVenta}");

        await File.WriteAllLinesAsync(_filePath, lines);
    }

    public async Task<Venta> CrearVentaAsync(Venta venta)
    {
        string fecha = venta.Fecha;
        int idVenta = venta.IdVenta; // El IdVenta será ingresado directamente

        var nuevaVenta = new Venta
        {
            IdVenta = idVenta,
            Fecha = fecha, // Guardar la fecha como texto
            Cliente = venta.Cliente,
            MetodoPago = venta.MetodoPago,
            TotalVenta = venta.TotalVenta
        };

        var line = $"{nuevaVenta.IdVenta},{nuevaVenta.Fecha},{nuevaVenta.Cliente},{nuevaVenta.MetodoPago},{nuevaVenta.TotalVenta}";

        await File.AppendAllTextAsync(_filePath, line + Environment.NewLine);

        return nuevaVenta;
    }

    public async Task<bool> EliminarVentaAsync(int idVenta)
    {
        var ventas = await ObtenerTodasVentasAsync();
        var ventaAEliminar = ventas.FirstOrDefault(v => v.IdVenta == idVenta);

        if (ventaAEliminar == null)
            return false;

        var ventasActualizadas = ventas.Where(v => v.IdVenta != idVenta).ToList();

        var lines = new List<string> { "IdVenta,Fecha,Cliente,MetodoPago,TotalVenta" };
        lines.AddRange(ventasActualizadas.Select(v =>
            $"{v.IdVenta},{v.Fecha},{v.Cliente},{v.MetodoPago},{v.TotalVenta.ToString(CultureInfo.InvariantCulture)}"));

        await File.WriteAllLinesAsync(_filePath, lines);
        return true;
    }

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
                        IdVenta = int.Parse(parts[0]), // Asegurarse de que el ID es un entero
                        Fecha = parts[1], // La fecha es ahora texto
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

    // Método privado para obtener el último IdVenta desde el archivo CSV
    private int ObtenerUltimoIdVenta()
    {
        if (!File.Exists(_filePath)) return 0;

        var lines = File.ReadAllLines(_filePath);

        if (lines.Length <= 1) return 0; // Si solo hay el encabezado, retornar 0

        var lastLine = lines.Last();
        var lastIdVenta = int.Parse(lastLine.Split(',')[0]);
        return lastIdVenta;
    }

    // Método para obtener una venta por su Id (actualmente no implementado)
    public async Task<Venta?> ObtenerVentaPorIdAsync(int idVenta)
    {
        var ventas = await ObtenerTodasVentasAsync();
        return ventas.FirstOrDefault(v => v.IdVenta == idVenta);
    }
}
