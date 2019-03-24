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
                Description = "You awaken to find catastrophe, all of the other pods in your section appear to be " +
                "cracked and leaking. The smell from the effluence spilling out of nearby pods is almost unbearable, " +
                "the acrid stench of decay hanging in the air. The cabin is washed in a red spectrum of light, " +
                "emitted by the emergency luminescence system. As you get your bearings you look around at the other " +
                "pods to see that they are filled with the mangled and half-eaten corpses of your fellow pilots. "+
                "One of the pods appears to have been broken from the inside out and no signs of a body remain. " +
                "You see that ahead the cabin door has malfunction but is half way open. ",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };
            gameMap.MapLocations[0, 1] = new Location()
            {
                Id = 1,
                Name = "Cryo-chamber Hallway",
                Description = "The hallway is dimly lit, you see a sign above the South door that says 'Mess Hall' " +
                "and a sign above the West door saying 'Cryo-sleep Chamber 3B', you look to see if any of the " +
                "other chambers are still active but they have all been locked and welded shut. Above the other doors " +
                "are signs that read 'Quarantined'.",
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
                "Today the Mess Hall is well named because it is indeed a mess. A mess of scattered tables, chairs " +
                "and shredded carcasses. You make your wake carefully through the rubble, electric wires hang down," +
                "sending sparks crackling at random. The smell of ozone and loosed bowels fills your nostrils. To the " +
                "North are the cryo chambers and to the South you can see the Barracks. To the East is a small bathroom," +
                " a terrible smell eminates from within.",
                Accessible = true,
                ModifiyExperiencePoints = 10,
                Message = "You have arrived at the mess hall. The heart of the Cryonaught deep space shuttle."
            };
            gameMap.MapLocations[1, 2] = new Location()
            {
                Id = 2,
                Name = "Bathroom",
                Description = 
                "You are eaten by slime.",
                Accessible = true,
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
            };
            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 4,
                Name = "The Barracks",
                Description = 
                "The bunk house.",
                Accessible = true,
                ModifiyExperiencePoints = 10
            };

            return gameMap;
        }
    }
}
