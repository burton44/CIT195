using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                Name = "Cpt. Rowsdower",
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

        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates() { Row = 0, Column = 0 };
        }

        public static Map GameMap()
        {
            int rows = 3;
            int columns = 4;

            Map gameMap = new Map(rows, columns);

            //
            // row 1
            //
            gameMap.MapLocations[0, 0] = new Location()
            {
                Id = 4,
                Name = "Cryo-sleep Chamber 3B",
                Description = "You awaken to find catastrophe, all of the other pods in your section appear to be" +
                "cracked and leaking. The smell from the effluence spilling out of nearby pods is almost unbearable, " +
                "the acrid stench of decay hanging in the air. The cabin is washed in a red spectrum of light, " +
                "emitted by the emergency luminescence system. You see that ahead the cabin door has malfunction but is " +
                "halfway open.",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };
            gameMap.MapLocations[0, 1] = new Location()
            {
                Id = 1,
                Name = "Hallway 1",
                Description = "It's a hallway",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };

            //
            // row 2
            //
            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 2,
                Name = "Mess Hall",
                Description = 
                "The Mess Hall.",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };
            gameMap.MapLocations[1, 2] = new Location()
            {
                Id = 2,
                Name = "Bathroom",
                Description = 
                "A Bathroom",
                Accessible = false,
                ModifiyExperiencePoints = 50,
                ModifyLives = -1,
                RequiredExperiencePoints = 40
            };

            //
            // row 3
            //
            gameMap.MapLocations[2, 0] = new Location()
            {
                Id = 3,
                Name = "The Bridge",
                Description = 
                "The Bridge",
                Accessible = false,
                ModifiyExperiencePoints = 20,
                ModifyHealth = 50,
                Message = "Traveler, our telemetry places you at the Xantoria Market. We have reports of local health potions."
            };
            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 4,
                Name = "The Barracks",
                Description = 
                "The Barracks.",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };

            return gameMap;
        }
    }
}
