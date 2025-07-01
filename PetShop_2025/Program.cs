using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop_2025.UI_LogIn;

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

            while (true)
            {
                using (var loginForm = new UI_LogIn.FormLogIn())
                {
                    var result = loginForm.ShowDialog();

                    if (result != DialogResult.OK || loginForm.UsuarioAutenticado == null)
                        break; // Usuario cerró login o falló => salir

                    // Abro el formulario que corresponde al perfil
                    Form mainForm = loginForm.ObtenerFormularioPorPerfil();

                    if (mainForm == null)
                        break;

                    Application.Run(mainForm); // Ejecuta hasta que se cierre

                    // Al cerrar, se vuelve al login
                }
            }
        }
    }
}
