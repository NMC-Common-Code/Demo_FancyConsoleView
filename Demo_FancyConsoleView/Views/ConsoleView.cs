using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FancyConsoleView
{
    public class ConsoleView
    {
        #region FIELDS

        //
        // declare a Universe and Traveler object for the ConsoleView object to use
        //
        //Universe _gameUniverse;
        //Traveler _gameTraveler;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// default constructor to create the console view objects
        /// </summary>
        public ConsoleView()
        {
            //_gameTraveler = gameTraveler;
            //_gameUniverse = gameUniverse;

            InitializeDisplay();
        }

        #endregion

        #region METHODS

        public void DisplayGamePlayScreen()
        {
            Console.Clear();
            ConsoleWindowHelper.DisplayHeader(new List<string>() { "The TARDIS Project" });

            DisplayMenuBox();
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

        private void DisplayMenuBox()
        {
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuBorderColor;

            ConsoleWindowHelper.DisplayBoxOutline(3, 130, 29, 20);

            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;

            Console.SetCursorPosition(132, 4);
            Console.Write(ConsoleWindowHelper.Center("Action List", ConsoleLayout.MenuBoxWidth - 2));


            int topRow = 5;
            char menuLetter = 'A';

            List<string> menuItems = new List<string>();

            menuItems = Enum.GetNames(typeof(TravelerAction)).ToList();
            menuItems.Remove("None");
            menuItems.Remove("MissionSetup");

            foreach (string menuChoice in menuItems)
            {
                Console.SetCursorPosition(132, topRow++);
                Console.Write($"{menuLetter++}. {menuChoice}");
            }
        }

        #endregion
    }
}
