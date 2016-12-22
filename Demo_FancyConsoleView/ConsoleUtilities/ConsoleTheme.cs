using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FancyConsoleView
{
    public static class ConsoleTheme
    {
        //
        // main console window colors
        //
        public static ConsoleColor WindowBackgroundColor = ConsoleColor.Black;
        public static ConsoleColor WindowForegroundColor = ConsoleColor.White;

        //
        // console window header colors
        //
        public static ConsoleColor HeaderBackgroundColor = ConsoleColor.White;
        public static ConsoleColor HeaderForegroundColor = ConsoleColor.Gray;

        //
        // message box colors
        //
        public static ConsoleColor MessageBoxBackgroundColor = ConsoleColor.Gray;
        public static ConsoleColor MessageBoxForegroundColor = ConsoleColor.DarkBlue;
        public static ConsoleColor MessageBoxHeaderBackgroundColor = ConsoleColor.White;
        public static ConsoleColor MessageBoxHeaderForegroundColor = ConsoleColor.Gray;

        //
        // menu colors
        //
        public static ConsoleColor MenuBackgroundColor = ConsoleColor.Black;
        public static ConsoleColor MenuForegroundColor = ConsoleColor.DarkRed;
    }
}
