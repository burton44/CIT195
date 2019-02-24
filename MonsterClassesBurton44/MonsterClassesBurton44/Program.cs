using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesBurton44
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }
        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 34,
                Name = "Suzy",
                Age = 473,
                HasGills = true,
                HomeSea = "Baltic Sea"
            };
        }
        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 56,
                Name = "Sid",
                Age = 18,
                Galaxy = "Andromeda"
            };
        }
        static void DisplayMenu()
        {
            bool exitMenu = false;
            int menuSelection;
            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;

            mySeaMonster = InitializeSeaMonster();
            mySpaceMonster = InitializeSpaceMonster();


            do
            {
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Edit Sea Monsters");
                Console.WriteLine("3) Exit");
                Console.WriteLine();
                Console.WriteLine("Enter Selection:");
                menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster);
                        break;
                    case 3:
                        exitMenu = true;
                        break;
                    case 2:
                        DisplayEditSeaMonster(mySeaMonster);
                        break;
                    default:
                        Console.WriteLine("Please enter a proper selection.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!exitMenu);
        }
        private static void DisplayEditSeaMonster(SeaMonster mySeaMonster)
        {
            Console.Write("Enter name of new seamonster:");
            mySeaMonster.Name = Console.ReadLine();
            Console.Write("Enter home sea of new seamonster:");
            mySeaMonster.HomeSea = Console.ReadLine();
            Console.Write("Enter Age:");
            int.TryParse(Console.ReadLine(), out int age);
            mySeaMonster.Age = age;
            Console.Write("Do they have gills?");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                mySeaMonster.HasGills = true;
            }
            else
            {
                mySeaMonster.HasGills = false;
            }


            DisplayContinuePrompt();
        }
        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster)
        {
            DisplayHeader("Monster Info");
            Console.WriteLine("Sea Monster");
            DisplaySeaMonsterInfo(seaMonster);

            Console.WriteLine();
            Console.WriteLine("Space Monster");
            DisplaySpaceMonsterInfo(spaceMonster);

            DisplayContinuePrompt();
        }
        static void DisplaySpaceMonsterInfo(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Is Happy: {(spaceMonster.IsHappy() ? "yes" : "no") }");
            Console.WriteLine();
            Console.WriteLine($"You attacked {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");
        }
        static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.Id}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Home Sea: {seaMonster.HomeSea}");
            Console.WriteLine($"Has Gills: {seaMonster.HasGills}");
            Console.WriteLine($"Is Happy: {seaMonster.IsHappy()}");
        }
        static void DisplayHeader(string headText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headText);
            Console.WriteLine();
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tWelcome to my App");
            DisplayContinuePrompt();
        }
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank you for using my App" );
            DisplayContinuePrompt();
        }
    }
}
