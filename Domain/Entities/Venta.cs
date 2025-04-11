
namespace ProyectoParcialTucoCrud.Domain.Entities
{
    public class Venta
    {
        public int IdVenta { get; set; }  
        public string Fecha { get; set; }  

        public string Cliente { get; set; }  

        public string MetodoPago { get; set; }  
        public decimal TotalVenta { get; set; }

    }
}