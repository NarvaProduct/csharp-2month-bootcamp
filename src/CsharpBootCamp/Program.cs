using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string? name;
            string? classType;
            string powerRating;
            int age;
            int attack;
            int defense;
            int speed;
            int powerScore;

            GetPlayerStats(out name, out age, out classType);
            DisplayPlayerStats(name, age, classType);

            GetPlayerPowerScore(out attack, out defense, out speed, out powerScore, out powerRating);
            DisplayPlayerPowerScore(attack, defense, speed, powerScore, powerRating);
        }
        public static void GetPlayerStats(out string name, out int age, out string classType)
        {
            // Set Player Name
            Console.WriteLine("What is your player's name?");
            name = Console.ReadLine();
            Console.Clear();

            // Set Player Age
            Console.WriteLine("What is your player's age?");
            string stringAge = Console.ReadLine();
            string errorMsg = "Please enter a valid age";
            age = CheckIntInput(stringAge, errorMsg);
            Console.Clear();

            // Set Player Class
            Console.WriteLine("What is your player's class?");
            classType = Console.ReadLine();
            Console.Clear();
        }
        public static void GetPlayerPowerScore(out int attack, out int defense, out int speed, out int powerScore, out string powerRating)
        {
            string? stringAttack; string? stringDefense; string? stringSpeed; string errorMsg;

            // Set Player Attack
            Console.WriteLine("What is your player's attack value?");
            stringAttack = Console.ReadLine();
            errorMsg = "Please enter a valid attack value";
            attack = CheckIntInput(stringAttack, errorMsg);
            Console.Clear();

            // Set Player Defense
            Console.WriteLine("What is your player's defense value?");
            stringDefense = Console.ReadLine();
            errorMsg = "Please enter a valid defense value";
            defense = CheckIntInput(stringAttack, errorMsg);
            Console.Clear();

            // Set Player Speed
            Console.WriteLine("What is your player's attack value?");
            stringSpeed = Console.ReadLine();
            errorMsg = "Please enter a valid speed value";
            speed = CheckIntInput(stringAttack, errorMsg);
            Console.Clear();

            // Set Player Power Score and Rating
            powerScore = (attack * 2 + speed) / defense;
            if (powerScore < 1)
            {
                powerRating = "Dough Boy";
            }
            else if (powerScore > 1 && powerScore < 3)
            {
                powerRating = "Street Grunt";
            }
            else
            {
                powerRating = "Elite Fighter";
            }
        }
        public static void DisplayPlayerStats(string name, int age, string classType)
        {
            Console.Clear();
            Console.WriteLine("=== Player Profile ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Class: {classType}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplayPlayerPowerScore(int attack, int defense, int speed, int powerScore, string powerRating)
        {
            Console.Clear();
            Console.WriteLine("=== Combat Power ===");
            Console.WriteLine($"Attack: {attack}\tDefense: {defense}\tSpeed: {speed}");
            Console.WriteLine($"Power Score: {powerScore}");
            Console.WriteLine($"Rating: {powerRating}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        public static int CheckIntInput(string? stringInput, string message)
        {
            int output;
            while (!int.TryParse(stringInput, out output) || output <= 0)
            {
                Console.Clear();
                Console.WriteLine(message);
                stringInput = Console.ReadLine();
                Console.Clear();
            }
            return output;
        }
    }
}