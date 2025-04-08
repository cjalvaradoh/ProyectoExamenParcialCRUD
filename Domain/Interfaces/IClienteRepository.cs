using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ProyectoParcialTucoCrud.Domain.Entities;

namespace ProyectoParcialTucoCrud.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void AgregarCliente(Cliente cliente);
        List<Cliente> ObtenerTodosClientes();
        Cliente? ObtenerClientePorId(int idCliente);
        void ActualizarCliente(Cliente cliente);
        void EliminarCliente(int idCliente);
    }
}