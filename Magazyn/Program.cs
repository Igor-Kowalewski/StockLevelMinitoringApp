using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // PONIŻSZA INICJALIZACJA FORM1 WYMAGANA ŻEBY PRZECHODZIĆ POMIĘDZY FORMSAMI BEZ ZAMKNIĘCIA APLIKACJI - IGOR KOWALEWSKI
            // POPRZEDNIA WERSJA:
            // Application.Run(new Dashboard());
            (new MainForm()).Show();
            Application.Run();
        }
    }
}
