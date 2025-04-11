using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ProyectoParcialTucoCrud.Domain;
using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Domain.Interfaces;

public class VentaCsvRepository : IVentaRepository
{
    private readonly BindingList<Venta> _ventas = new();

    public VentaCsvRepository()
    {
        _ventas = new BindingList<Venta>();
    }

    public async Task<Venta> CrearVentaAsync(Venta venta)
    {
        if (venta == null)
            throw new ArgumentNullException(nameof(venta));

        if (venta.IdVenta <= 0)
            throw new ArgumentException("ID de venta inválido");

        if (_ventas.Any(v => v.IdVenta == venta.IdVenta))
            throw new InvalidOperationException($"Ya existe una venta con ID {venta.IdVenta}");

        _ventas.Add(venta);
        return await Task.FromResult(venta);
    }

    public async Task<BindingList<Venta>> ObtenerTodasVentasAsync()
    {
        return await Task.FromResult(_ventas);
    }

    public async Task<bool> EliminarVentaAsync(int idVenta)
    {
        var venta = _ventas.FirstOrDefault(v => v.IdVenta == idVenta);
        if (venta != null)
        {
            _ventas.Remove(venta);
            return await Task.FromResult(true);
        }
        return await Task.FromResult(false);
    }

    public async Task GuardarVentasAsync(string filePath, List<Venta> ventas)
    {
        try
        {
            using (var writer = new StreamWriter(filePath, false))
            {
                await writer.WriteLineAsync("IdVenta,Fecha,Cliente,MetodoPago,TotalVenta");

                foreach (var venta in ventas)
                {
                    string linea = $"{venta.IdVenta},{venta.Fecha}," +
                                   $"\"{venta.Cliente.Replace("\"", "\"\"")}\"," +
                                   $"{venta.MetodoPago}," +
                                   $"{venta.TotalVenta.ToString(CultureInfo.InvariantCulture)}";
                    await writer.WriteLineAsync(linea);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al guardar archivo: {ex.Message}");
        }
    }

    public async Task<Venta?> ActualizarVentaAsync(Venta venta)
    {
        var ventaExistente = _ventas.FirstOrDefault(v => v.IdVenta == venta.IdVenta);
        if (ventaExistente == null) return null;

        ventaExistente.Fecha = venta.Fecha;
        ventaExistente.Cliente = venta.Cliente;
        ventaExistente.MetodoPago = venta.MetodoPago;
        ventaExistente.TotalVenta = venta.TotalVenta;

        return await Task.FromResult(ventaExistente);
    }

    public async Task<Venta?> ObtenerVentaPorIdAsync(int idVenta)
    {
        return await Task.FromResult(_ventas.FirstOrDefault(v => v.IdVenta == idVenta));
    }

    Task<List<Venta>> IVentaRepository.ObtenerTodasVentasAsync()
    {
        throw new NotImplementedException();
    }

    Task IVentaRepository.ActualizarVentaAsync(Venta venta)
    {
        throw new NotImplementedException();
    }
}
