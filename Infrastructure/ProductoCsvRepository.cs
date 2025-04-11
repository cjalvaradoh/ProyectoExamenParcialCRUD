using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProyectoParcialTucoCrud.Domain.Entities;
using ProyectoParcialTucoCrud.Domain.Interfaces;

namespace Infrastructure
{
    public class ProductoCsvRepository : IProductoRepository
    {
        private readonly string _rutaArchivo = "productos.csv";

        public void AgregarProducto(Producto producto)
        {
            var linea = $"{producto.IdProducto},{producto.Codigo},{producto.Nombre},{producto.Descripcion},{producto.Categoria},{producto.Stock},{producto.UnidadMedida},{producto.PrecioUnitario}";
            File.AppendAllText(_rutaArchivo, linea + Environment.NewLine);
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            var productos = new List<Producto>();

            if (!File.Exists(_rutaArchivo))
                return productos;

            var lineas = File.ReadAllLines(_rutaArchivo);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split(',');

                if (partes.Length < 8) continue; // se asegura de tener todas las columnas

                try
                {
                    productos.Add(new Producto
                    {
                        IdProducto = int.Parse(partes[0]),
                        Codigo = partes[1],
                        Nombre = partes[2],
                        Descripcion = partes[3],
                        Categoria = partes[4],
                        Stock = int.Parse(partes[5]),
                        UnidadMedida = partes[6],
                        PrecioUnitario = decimal.Parse(partes[7])
                    });
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine("Error al leer línea: " + ex.Message);
                }
            }

            return productos;
        }


        public Producto? ObtenerProductoPorId(int idProducto)
        {
            return ObtenerTodosLosProductos()
                .FirstOrDefault(p => p.IdProducto == idProducto);
        }

        public void ActualizarProducto(Producto producto)
        {
            var productos = ObtenerTodosLosProductos();
            var index = productos.FindIndex(p => p.IdProducto == producto.IdProducto);

            if (index != -1)
            {
                productos[index] = producto;
                GuardarTodo(productos);
            }
        }

        public bool EliminarProducto(int idProducto)
        {
            var productos = ObtenerTodosLosProductos();
            var nuevos = productos.Where(p => p.IdProducto != idProducto).ToList();

            if (productos.Count == nuevos.Count)
                return false; // No se eliminó nada

            GuardarTodo(nuevos);
            return true;
        }

        private void GuardarTodo(List<Producto> productos)
        {
            var lineas = productos.Select(p =>
                $"{p.IdProducto},{p.Codigo},{p.Nombre},{p.Descripcion},{p.Categoria},{p.Stock},{p.UnidadMedida},{p.PrecioUnitario}"
            );

            File.WriteAllLines(_rutaArchivo, lineas);
        }
    }
}
