using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
// $G$ RUL-003 (-10) Diagram document should be attached to the solution.
// $G$ THE-001 (-18) your grade on diagrams document - 82. please see comments inside the document. 40% of your grade).

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
