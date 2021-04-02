using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Presentaciones;

namespace COMPLETE_FLAT_UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Elijo el formulario que inicia primero
            Application.Run(new FormLogin());
        }
    }
}
