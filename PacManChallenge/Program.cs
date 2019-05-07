using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PacManChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeObjectRepository _mazeRepo = new MazeObjectRepository();
            Dictionary<string, int> MazeObject = _mazeRepo.GetDictionary();

            var mazeObjects = SeedMazeDictionary();
            _mazeRepo.AddMazeObjectsToDictionary(mazeObjects);

            double pacPoints = 5000;
            double ghostCount = 0;
            int lives = 3;

            Console.WriteLine("You have 3 lives and 5000 points. Would you like to play? y/n");

            string text = System.IO.File.ReadAllText(@"../../pacman-sequence.txt");
            string[] words = text.Split(',');

            while (lives > 0)
            {
                foreach (var word in words)
                {
                    double points = MazeObject[word];
                    if (word == "VulnerableGhost")
                    {
                        pacPoints += (points * (Math.Pow(2, ghostCount)));
                        ghostCount += 1;
                    }
                    else if (word != "InvincibleGhost")
                    {
                        pacPoints += points;
                    }
                    else lives -= 1;
                    Console.WriteLine($"{pacPoints} and {lives}");
                    Thread.Sleep(50);
                }
            }
            lives = Convert.ToInt32(pacPoints / 10000) + lives;
            if (lives == 0)
                Console.WriteLine("You are dead.");
            Console.WriteLine($"Total Points:{pacPoints}, Total Lives: {lives}");
            Console.ReadLine();
        }

        private static List<MazeObject> SeedMazeDictionary()
        {
            MazeObject dot = new MazeObject("Dot", 10);
            MazeObject ghostVul = new MazeObject("VulnerableGhost", 200);
            MazeObject cherry = new MazeObject("Cherry", 100);
            MazeObject strawberry = new MazeObject("Strawberry", 300);
            MazeObject orange = new MazeObject("Orange", 500);
            MazeObject apple = new MazeObject("Apple", 700);
            MazeObject melon = new MazeObject("Melon", 1000);
            MazeObject galaxian = new MazeObject("Galaxian", 2000);
            MazeObject bell = new MazeObject("Bell", 3000);
            MazeObject key = new MazeObject("Key", 5000);
            MazeObject death = new MazeObject("InvincibleGhost", 0);

            var mazeObjects = new List<MazeObject>() { dot, ghostVul, cherry, strawberry, orange, apple, melon, galaxian, bell, key, death };
            return mazeObjects;
        }
    }
}
