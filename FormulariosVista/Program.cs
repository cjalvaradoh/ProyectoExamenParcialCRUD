using System;
using ProyectoParcialTucoCrud.Application;
using ProyectoParcialTucoCrud.FormulariosVista;
using ProyectoParcialTucoCrud.Venta.Aplication;
using WinFormsApp = System.Windows.Forms.Application;

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
            var modificarHandler = new ModificarVentaHandler(ventaRepository);
            // To customize application configuration such as set high DPI settings or default font,
            ApplicationConfiguration.Initialize();
            WinFormsApp.Run(new MenuPrincipal(crearHandler, modificarHandler));
        }
<<<<<<< HEAD
    }
=======


    }

>>>>>>> dc2d6cd00dbe55aa8b1012535890b301c0799e18
}