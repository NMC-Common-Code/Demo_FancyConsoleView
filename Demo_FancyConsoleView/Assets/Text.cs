using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public static class Text
    {
        public enum Id
        {
            IntroMessage,
            InitializeMissionIntro,
            InitializeMissionTravelerName,
            InitializeMissionTravelerAge,
            InitializeMissionTravelerRace
        }

        public static List<string> HeaderText = new List<string>() { "The Aion Project" };
        public static List<string> FooterText = new List<string>() { "Laughing Leaf Productions, 2016" };

        public static Dictionary<Id, string> General = new Dictionary<Id, string>()
        {
            {
                Id.IntroMessage,
                "You have been hired by the Norlon Corporation to participate " +
                "in its latest endeavor, the Aion Project. Your mission is to " +
                "test the limits of the new Aion Engine and report back to " +
                "the Norlon Corporation.\n" +
                " \n" +
                "Press the Esc key to exit the game at any point.\n" +
                " \n" +
                "Your mission begins now.\n" +
                " \n" +
                "\tYour first task will be to set up the initial parameters of your mission.\n" +
                " \n" +
                "\tPress any key to begin the Mission Initialization Process.\n"
            }
        };

        //public static Dictionary<Id, string> MissionInit = new Dictionary<Id, string>()
        //{

        //    {
        //        Id.InitializeMissionIntro,
        //        "Before you begin your mission we much gather your base data.\n" +
        //        " \n" +
        //        "You will be prompted for the required information. Please enter the information below.\n" +
        //        " \n" +
        //        "\tPress any key to begin."
        //    },

        //    {
        //        Id.InitializeMissionTravelerName,
        //        "Enter your name traveler.\n" +
        //        " \n" +
        //        "Please use the name you wish to be referred during your mission."
        //    },

        //    {
        //        Id.InitializeMissionTravelerAge,
        //        "Enter your age.\n" +
        //        " \n" +
        //        "Please use the standard Earth year as your reference."
        //    }
        //};

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Before you begin your mission we much gather your base data.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeMissionTravelerName()
        {
            string messageBoxText =
                "Enter your name traveler.\n" +
                " \n" +
                "Please use the name you wish to be referred during your mission.";

            return messageBoxText;
        }

        public static string InitializeMissionTravelerAge(string travelerName)
        {
            string messageBoxText =
                $"Very good then, we will call you {travelerName} on this mission.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n" +
                "Please use the standard Earth year as your reference.";

            return messageBoxText;
        }

        public static string InitializeMissionTravelerRace(string travelerName)
        {
            string messageBoxText =
                $"{travelerName}, it will be important for us to know your race on this mission.\n" +
                " \n" +
                "Enter your race below.\n" +
                " \n" +
                "Please use the universal race classifications below." +
                " \n";

            string raceList = null;

            foreach (Character.RaceType race in Enum.GetValues(typeof(Character.RaceType)))
            {
                if (race != Character.RaceType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }
    }
}
