using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FancyConsoleView
{
    public class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsoleView;
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
            _playingGame = true;
            //_gameUniverse = new Universe();
            //_gameTraveler = new Traveler();
            _gameConsoleView = new ConsoleView();

        }

        /// <summary>
        /// method to manage the application setup and control loop
        /// </summary>
        private void ManageGameLoop()
        {
            TravelerAction travelerActionChoice;

            //_gameConsoleView.DisplayWelcomeScreen();

            //InitializeMission();

            Console.Clear();

            //
            // game loop
            //
            while (_playingGame)
            {
                //int itemID;
                //int treasureID;

                //
                // get a menu choice from the ConsoleView object
                //
                _gameConsoleView.DisplayGamePlayScreen();

                Console.ReadKey();

                //
                // choose an action based on the user's menu choice
                //
            //    switch (travelerActionChoice)
            //    {
            //        case TravelerAction.None:
            //            break;
            //        case TravelerAction.LookAround:
            //            _gameConsoleView.DisplayLookAround();
            //            break;
            //        case TravelerAction.LookAt:
            //            _gameConsoleView.DisplayLookAt();
            //            break;
            //        case TravelerAction.PickUpItem:
            //            itemID = _gameConsoleView.DisplayPickUpItem();

            //            Item itemToPickup = _gameUniverse.GetItemtByID(itemID);

            //            itemToPickup.SpaceTimeLocationID = 0;
            //            _gameTraveler.TravelersItems.Add(itemToPickup);
            //            break;
            //        case TravelerAction.PickUpTreasure:
            //            treasureID = _gameConsoleView.DisplayPickUpTreasure();

            //            Treasure treasureToPickup = _gameUniverse.GetTreasureByID(treasureID);

            //            treasureToPickup.SpaceTimeLocationID = 0;
            //            _gameTraveler.TravelersTreasures.Add(treasureToPickup);
            //            break;
            //        case TravelerAction.PutDownItem:
            //            itemID = _gameConsoleView.DisplayPutDownItem();

            //            Item itemToPutDown = _gameUniverse.GetItemtByID(itemID);

            //            itemToPutDown.SpaceTimeLocationID = _gameTraveler.SpaceTimeLocationID;
            //            _gameTraveler.TravelersItems.Remove(itemToPutDown);
            //            break;
            //        case TravelerAction.PutDownTreasure:

            //            break;
            //        case TravelerAction.Travel:
            //            _gameTraveler.SpaceTimeLocationID = _gameConsoleView.DisplayGetTravelersNewDestination().SpaceTimeLocationID;
            //            break;
            //        case TravelerAction.TravelerInfo:
            //            _gameConsoleView.DisplayTravelerInfo();
            //            break;
            //        case TravelerAction.TravelerInventory:
            //            _gameConsoleView.DisplayTravelerItems();
            //            break;
            //        case TravelerAction.TravelerTreasure:
            //            _gameConsoleView.DisplayTravelerTreasure();
            //            break;
            //        case TravelerAction.ListTARDISDestinations:
            //            _gameConsoleView.DisplayListAllTARDISDestinations();
            //            break;
            //        case TravelerAction.ListItems:
            //            _gameConsoleView.DisplayListAllGameItems();
            //            break;
            //        case TravelerAction.ListTreasures:
            //            _gameConsoleView.DisplayListAllGameTreasures();
            //            break;
            //        case TravelerAction.Exit:
            //            _usingGame = false;
            //            break;
            //        default:
            //            break;
            //    }
            }

            //_gameConsoleView.DisplayExitPrompt();

            //
            // close the application
            //
            Environment.Exit(1);
        }

        #endregion
    }
}
