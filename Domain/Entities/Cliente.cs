using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcialTucoCrud.Domain.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; } // Usa mayúscula en "Id" por convención
        public string Nombre { get; set; } // No necesita inicialización si es requerido
        public string Apellido { get; set; } = string.Empty; // Si es opcional, usa string?
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; // "Email" es más estándar que "Gmail"

    }
}
