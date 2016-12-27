using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsoleView;
        private Traveler _gameTraveler;
        private bool _playingGame;

        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            //
            // setup all of the objects in the game
            //
            InitializeGame();

            //
            // begins running the application UI
            //
            ManageGameLoop();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initialize the major game objects
        /// </summary>
        private void InitializeGame()
        {
            _gameConsoleView = new ConsoleView();
            _gameTraveler = new Traveler();
            Console.CursorVisible = false;
            _playingGame = true;
        }

        /// <summary>
        /// method to manage the application setup and control loop
        /// </summary>
        private void ManageGameLoop()
        {
            TravelerAction travelerActionChoice = TravelerAction.None;

            //
            // display splash screen
            //
            _playingGame = _gameConsoleView.DisplaySpashScreen();

            if (!_playingGame)
            {
                Environment.Exit(1);
            }

            //
            // display introductory message
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Intro", Text.General[Text.Id.IntroMessage], ActionMenu.MissionIntro, "");
            _gameConsoleView.GetContinueKey();


            //
            // initialize the mission traveler
            // 
            InitializeMission();

            //
            // game loop
            //
            while (_playingGame)
            { 
                //
                // choose an action based on the user's menu choice
                //
                switch (travelerActionChoice)
                {
                    case TravelerAction.None:
                        break;

                    case TravelerAction.TravelerInfo:
                        //_gameConsoleView.DisplayTravelerInfo();
                        break;

                    case TravelerAction.Exit:
                        _playingGame = false;
                        break;

                    default:
                        break;
                }
            }

            //
            // close the application
            //
            Environment.Exit(1);
        }

        private void InitializeMission()
        {
            //
            // intro
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization", Text.InitializeMissionIntro(), ActionMenu.MissionIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // get traveler's name
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization", Text.InitializeMissionTravelerName(), ActionMenu.MissionIntro, "");
            _gameConsoleView.DisplayInputBoxPrompt("Enter your name: ");
            _gameTraveler.Name = _gameConsoleView.GetString();

            //
            // get traveler's age
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization", Text.InitializeMissionTravelerAge(_gameTraveler.Name), ActionMenu.MissionIntro, "");
            _gameConsoleView.DisplayInputBoxPrompt($"Enter your age {_gameTraveler.Name}: ");
            _gameTraveler.Age = _gameConsoleView.GetInteger();

            //
            // get traveler's race
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization", Text.InitializeMissionTravelerRace(_gameTraveler.Name), ActionMenu.MissionIntro, "");
            _gameConsoleView.DisplayInputBoxPrompt($"Enter your race {_gameTraveler.Name}: ");
            _gameTraveler.Race = _gameConsoleView.GetRace();
        }

        #endregion
    }
}
