using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "The Aion Project" };
        public static List<string> FooterText = new List<string>() { "Laughing Leaf Productions, 2016" };

        public static Dictionary<string, string> General = new Dictionary<string, string>()
        {
            {
                "IntroMessage",
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
    }
}
