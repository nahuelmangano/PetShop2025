using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_2025
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializo el formulario de login
            //Application.Run(new UI_LogIn.FormLogIn());

            // Abrir el formulario que se necesite
            Application.Run(new UI_Veterinario.MenuPrincipal());
        }
    }
}
