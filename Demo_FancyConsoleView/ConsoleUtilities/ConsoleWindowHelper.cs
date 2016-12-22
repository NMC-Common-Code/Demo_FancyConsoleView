using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FancyConsoleView
{
    /// <summary>
    /// The ConsoleWindowHelper class provides extensions to the Console class to help 
    /// develop console-based applications
    /// </summary>
    static class ConsoleWindowHelper
    {
        public static int ConsoleWindowWidth { get; set; }
        public static int ConsoleWindowHeight { get; set; }
        public static ConsoleColor ConsoleWindowForeground { get; set; }
        public static ConsoleColor ConsoleWindowBackground { get; set; }
        public static ConsoleColor HeaderForeground { get; set; }
        public static ConsoleColor HeaderBackground { get; set; }

        public static void SetWidth(int width)
        {
            Console.WindowWidth = width;
        }

        public static void SetHeight(int height)
        {
            Console.WindowWidth = height;
        }
        
        /// <summary>
        /// initialize the console window to the default values
        /// </summary>
        /// <param name="consoleWindowWidth">console window width</param>
        /// <param name="consoleWindowHeight">console window height</param>
        /// <param name="consoleWindowForeground">console window text color</param>
        /// <param name="consoleWindowBackground">console window background color </param>
        public static void InitializeConsoleWindow()
        {
            //
            // set default values for console window from layout class
            //
            ConsoleWindowWidth = ConsoleLayout.WindowWidth;
            ConsoleWindowHeight = ConsoleLayout.WindowHeight;

            //
            // set default values for console window from theme class
            //
            ConsoleWindowForeground = ConsoleTheme.WindowForegroundColor;
            ConsoleWindowBackground = ConsoleTheme.WindowBackgroundColor;
            HeaderBackground = ConsoleTheme.HeaderBackgroundColor;
            HeaderForeground = ConsoleTheme.HeaderForegroundColor;

            //
            // set initial position of console window
            //
            Console.SetWindowPosition(ConsoleLayout.WindowPositionLeft, ConsoleLayout.WindowPositionTop);

            //
            // set console window to default values
            //
            ResetConsoleWindow();

        }

        public static void ResetConsoleWindow()
        {
            Console.WindowWidth = ConsoleWindowWidth;
            Console.WindowHeight = ConsoleWindowHeight;
            Console.ForegroundColor = ConsoleWindowForeground;
            Console.BackgroundColor = ConsoleWindowBackground;
            Console.Clear();
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

        /// <summary>
        /// place an box around an area in the console window
        /// </summary>
        /// <param name="topLeftRow">top left row position</param>
        /// <param name="topLeftColumn">top left column position</param>
        /// <param name="width">box width</param>
        /// <param name="height">box height</param>
        public static void DisplayBoxOutline(int topLeftRow, int topLeftColumn, int width, int height)
        {
            string topLeftCorner = "\u2554";
            string topRightCorner = "\u2557";
            string bottomLeftCorner = "\u255A";
            string bottomRightCorner = "\u255D";
            string horizontal = "\u2550";
            string vertical = "\u2551";

            Console.SetCursorPosition(topLeftColumn, topLeftRow);

            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.SetCursorPosition(topLeftColumn + column, topLeftRow + row);

                    // displaying top row
                    if (row == 0)
                    {
                        if (column == 0)
                        {
                            Console.Write(topLeftCorner);
                        }
                        else if (column == width - 1)
                        {
                            Console.Write(topRightCorner);
                        }
                        else
                        {
                            Console.WriteLine(horizontal);
                        }
                    }
                    // displaying bottom row
                    else if (row == height - 1)
                    {
                        if (column == 0)
                        {
                            Console.Write(bottomLeftCorner);
                        }
                        else if (column == width - 1)
                        {
                            Console.Write(bottomRightCorner);
                        }
                        else
                        {
                            Console.WriteLine(horizontal);
                        }
                    }
                    // displaying middle row
                    else
                    {
                        if (column == 0 || column == width - 1)
                        {
                            Console.Write(vertical);
                        }
                    }
                }
            }
        }


        public static void DisplayHeader(List<string> headerText)
        {
            List<string> formatedHeaderText = new List<string>();

            formatedHeaderText.Add(new String(' ', ConsoleWindowWidth));
            foreach (string lineOfText in headerText)
            {
                formatedHeaderText.Add(Center(lineOfText, ConsoleLayout.WindowWidth));
            }
            formatedHeaderText.Add(new String(' ', ConsoleWindowWidth));

            Console.BackgroundColor = HeaderBackground;
            Console.ForegroundColor = HeaderForeground;
            foreach (string lineOfText in formatedHeaderText)
            {
                Console.Write(lineOfText);
            }
        }

        //public static void HeaderTextTest()
        //{
        //    List<string> headerText = new List<string>();
        //    headerText.Add("My Quest Game");
        //    headerText.Add("Laughing Leaf Productions");

        //    DisplayHeader(headerText);
        //    Console.ReadKey();
        //}

        public static string Center(string text, int stringLength)
        {
            int leftPadding = (stringLength - text.Length) / 2 + text.Length;
            return text.PadLeft(leftPadding).PadRight(stringLength);
        }
    }
}
