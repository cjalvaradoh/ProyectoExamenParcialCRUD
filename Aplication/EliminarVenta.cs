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
        public int idVenta { get; set; }  
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
            return await _ventaRepository.EliminarVentaAsync(command.idVenta);
        }
    }
}
