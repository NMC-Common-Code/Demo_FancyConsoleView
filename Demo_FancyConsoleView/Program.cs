using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FancyConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeDisplay();

            ConsoleWindowHelper.HeaderTextTest();

            Console.ReadKey();
        }

        private static void InitializeDisplay()
        {
            //
            // control the console window properties
            //
            ConsoleWindowControl.DisableResize();
            ConsoleWindowControl.DisableMaximize();
            ConsoleWindowControl.DisableMinimize();
            Console.Title = "Demo of Fancy Console View Framework";

            //
            // set the default console window values
            //
            ConsoleWindowHelper.InitializeConsoleWindow();

            Console.CursorVisible = false;
        }
    }
}
