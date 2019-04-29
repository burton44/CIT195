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
                LocationId = 0,
                Inventory = new ObservableCollection<GameItemQuantity>()
                {

                }
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
        private static GameItem GameItemById(int id)
        {
            return StandardGameItems().FirstOrDefault(i => i.Id == id);
        }
        private static Npc NpcById(int id)
        {
            return Npcs().FirstOrDefault(i => i.Id == id);
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
                Message = "\tYou are a pilot who has been awakened from cryo-sleep after 200 years aboard the deep space vessel Cryonaught. Upon resuscitation you realized the ship is in a mostly destroyed shamble, and you appear to be the lone survivor. " +
                "Choose from the available nearby rooms where you would like to go or interact with the items in your current location."
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
                Message = "Your pulse quickens as you realize there may be an inhuman murderer aboard!",
  
            };

            //
            // row 2
            //
            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 1,
                Name = "Mess Hall",
                Description = 
                "Today the Mess Hall is well named because it is indeed a mess. A mess of scattered tables, chairs " +
                "and shredded carcasses. You make your wake carefully through the rubble, electric wires hang down," +
                "sending sparks crackling at random. The smell of ozone and loosed bowels fills your nostrils. To the " +
                "North are the cryo chambers and to the South you can see the Barracks. To the West is the ship trash compactor," +
                " a terrible smell eminates from within.",
                Accessible = true,
                Message = "You have arrived at the mess hall. The heart of the Cryonaught deep space shuttle."
            };
            gameMap.MapLocations[1, 0] = new Location()
            {
                Id = 2,
                Name = "Trash compactor - Danger Do Not Enter",
                Description =
                "You get your hand caught in the trash compactor and are able to wrench it free only after suffering severe lacerations, you lose 50 health.",
                Accessible = true,
                ModifyHealth = -50,
                Message = "Ouch, that hurt!"
            };
            gameMap.MapLocations[1, 2] = new Location()
            {
                Id = 2,
                Name = "Hidden Door",
                Description = 
                "You are in a hidden hallway that connects to the escape pod ahead, you notice that the door to the pods is accesible only with a yellow key card.",
                Accessible = false,
                ModifiyExperiencePoints = 50,
                RequiredExperiencePoints = 50,
                Message = "You are close to salvation."
            };
            gameMap.MapLocations[1, 3] = new Location()
            {
                Id = 5,
                Name = "Escape Pods",
                Description =
                "Congratulations you have escaped with your life, for now...",
                Accessible = true,
                RequiredExperiencePoints = 500,
                Message = "Way to go! You are a real space ace."
            };

            //
            // row 3
            //
            gameMap.MapLocations[2, 0] = new Location()
            {
                Id = 3,
                Name = "The Bridge",
                Description = 
                "The main command center for the Cryonaught trans-galactic cruiser, the ship is in emergency power mode and none of the controls are working, but you notice a key card on the table, it is covered in crusted blood and alien effluence.",
                Accessible = false,
                Message = "Remember cadet, pick up any items you may see, they could come in handy later!",
                GameItems = new ObservableCollection<GameItemQuantity>()
                {
                    new GameItemQuantity(GameItemById(1001), 1)
                }
            };
            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 4,
                Name = "The Barracks",
                Description = 
                "The ship bunk house is in utter disarray but under some rubble you notice a figure, it appears as though he may still be alive.",
                Accessible = true,
                ModifiyExperiencePoints = 50,
                Npcs = new ObservableCollection<Npc>()
                {
                    NpcById(2001)
                }
            };

            return gameMap;
        }
        public static List<GameItem> StandardGameItems()
        {
            return new List<GameItem>()
            {
                new Items(1001, "Yellow Key Card", 75, "This will open the yellow door.", 10, "You used the yellow key card!", Items.UseActionType.OPENLOCATION),
            };
        }
        public static List<Npc> Npcs()
        {
            return new List<Npc>()
            {
                new Person()
                {
                    Id = 2001,
                    Name = "Corporeal Ohwattanassiam",
                    Description = "An old buddy from your days in cadet school.",
                    Messages = new List<string>()
                    {
                        "Listen to me Rowsdower, I'm not gonna make it, you have to get to the escape pod, it's in a hidden door in Mess Hall, hurry!"
                    },
                
                }
            };
        }
    }
}
