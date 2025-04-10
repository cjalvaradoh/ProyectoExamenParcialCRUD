using ProyectoParcialTucoCrud.Aplication;
using ProyectoParcialTucoCrud.FormulariosVista;
using ProyectoParcialTucoCrud.Venta.Aplication;

namespace ProyectoParcialTucoCrud.Venta.Winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var ventaRepository = new VentaCsvRepository();
            var crearHandler = new CrearVentaHandler(ventaRepository);
            var eliminarHandler = new EliminarVentaHandler(ventaRepository);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipal(crearHandler, eliminarHandler));
        }
    }
}