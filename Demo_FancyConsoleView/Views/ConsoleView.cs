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

        //
        // declare menus
        //
        Menu _manageTravelerMenu;


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

            InitializeMenus();
            InitializeDisplay();
        }

        #endregion

        #region METHODS

        public void DisplayGamePlayScreen()
        {
            Console.Clear();
            ConsoleWindowHelper.DisplayHeader(new List<string>() { "The TARDIS Project" });
            ConsoleWindowHelper.DisplayFooter(new List<string>() { "Laugh Leaf Productions, 2016" });

            DisplayMessageBox("Hello NMC");
            DisplayMenuBox(_manageTravelerMenu);
            DisplayInputBox("Choose an Action: ");
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

        private void DisplayMenuBox(Menu menu)
        {
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuBorderColor;

            //
            // display menu box border
            //
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MenuBoxPositionTop,
                ConsoleLayout.MenuBoxPositionLeft,
                ConsoleLayout.MenuBoxWidth,
                ConsoleLayout.MenuBoxHeight);

            //
            // display menu box header
            //
            Console.BackgroundColor = ConsoleTheme.MenuBorderColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 2, ConsoleLayout.MenuBoxPositionTop + 1);
            Console.Write(ConsoleWindowHelper.Center("Choose Action", ConsoleLayout.MenuBoxWidth - 4));

            //
            // display menu title
            //
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 1, ConsoleLayout.MenuBoxPositionTop + 3);
            Console.Write(ConsoleWindowHelper.Center(menu.MenuTitle, ConsoleLayout.MenuBoxWidth - 4));

            //
            // display menu choices
            //
            int topRow = ConsoleLayout.MenuBoxPositionTop + 5;
            char menuLetter = 'A';
            foreach (TravelerAction menuChoice in menu.MenuChoices)
            {
                string formatedMenuChoice = ConsoleWindowHelper.ToLabelFormat(menuChoice.ToString());
                Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 2, topRow++);
                Console.Write($"{menuLetter++}. {formatedMenuChoice}");
            }


        }

        private void DisplayMessageBox(string message)
        {
            Console.BackgroundColor = ConsoleTheme.MessageBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxBorderColor;

            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MessageBoxPositionTop,
                ConsoleLayout.MessageBoxPositionLeft,
                ConsoleLayout.MessageBoxWidth,
                ConsoleLayout.MessageBoxHeight);
        }

        private void DisplayInputBox(string prompt)
        {
            Console.BackgroundColor = ConsoleTheme.InputBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.InputBoxBorderColor;

            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.InputBoxPositionTop,
                ConsoleLayout.InputBoxPositionLeft,
                ConsoleLayout.InputBoxWidth,
                ConsoleLayout.InputBoxHeight);

            Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + 1);
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
            Console.Write(prompt);
            Console.CursorVisible = true;
        }

        private void InitializeMenus()
        {
            _manageTravelerMenu = new Menu()
            {
                MenuName = "ManageTraveler",
                MenuTitle = "Manage Traveler",
                MenuChoices = new List<TravelerAction>()
                    {
                        TravelerAction.MissionSetup,
                        TravelerAction.TravelerInfo
                    }
            };
        }

        #endregion
    }
}
