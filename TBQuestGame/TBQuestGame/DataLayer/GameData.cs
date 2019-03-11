using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTheAionProject.Models;

namespace WpfTheAionProject.DataLayer
{
    /// <summary>
    /// static class to store the game data set
    /// </summary>
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Captain Rowsdower",
                Age = 43,
                JobTitle = Player.JobTitleName.Explorer,
                Sex = Character.SexType.Male,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0,
                LocationId = 0
            };
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "\tYou are a pilot who has been awakened from cryo-sleep after 200 years aboard the deep space vessel Cryonaught. Upon resuscitation you realized the ship is in a mostly destroyed shamble, and you appear to be the lone survivor. ",
                "\tChoose from the available nearby rooms where you would like to go or interact with the items in your current location."
            };
        }
    }
}
