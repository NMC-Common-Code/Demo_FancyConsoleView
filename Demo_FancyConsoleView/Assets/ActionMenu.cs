using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public static class ActionMenu
    {
        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new List<TravelerAction>()
                    {
                        TravelerAction.None
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new List<TravelerAction>()
                    {
                        TravelerAction.Exit
                    }
        };

        public static Menu ManageTraveler = new Menu()
        {
            MenuName = "ManageTraveler",
            MenuTitle = "Manage Traveler",
            MenuChoices = new List<TravelerAction>()
                    {
                        TravelerAction.MissionSetup,
                        TravelerAction.TravelerInfo,
                        TravelerAction.Exit
                    }
        };
    }
}
