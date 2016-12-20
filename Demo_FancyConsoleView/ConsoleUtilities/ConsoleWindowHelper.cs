using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FancyConsoleView
{
    static class ConsoleWindowHelper
    {
        public static int ConsoleWindowWidth { get; set; }
        public static int ConsoleWindowHeight { get; set; }
        public static ConsoleColor ConsoleWindowForeground { get; set; }
        public static ConsoleColor ConsoleWindowBackground { get; set; }
        public static ConsoleColor HeaderForeground { get; set; }
        public static ConsoleColor HeaderBackground { get; set; }

        public static void InitializeConsoleWindow(
            int consoleWindowWidth,
            int consoleWindowHeight,
            ConsoleColor consoleWindowForeground,
            ConsoleColor consoleWindowBackground
            )
        {
            ConsoleWindowWidth = consoleWindowWidth;
            ConsoleWindowHeight = consoleWindowHeight;
            ConsoleWindowForeground = consoleWindowForeground;
            ConsoleWindowBackground = consoleWindowBackground;
        }

        public static void InitializeHeader(
            List<string> headerText,
            ConsoleColor headerForeground,
            ConsoleColor headerBackground
            )
        {
            HeaderForeground = HeaderForeground;
            HeaderBackground = headerBackground;
            DisplayHeader(headerText);
        }

        public static void DisplayHeader(List<string> headerText)
        {

        }
    }
}
