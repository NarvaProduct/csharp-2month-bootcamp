using System.ComponentModel.DataAnnotations;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            string name; int age; string classType; 
            GetPlayerStats(out name, out age, out classType);
            DisplayPlayerStats(name, age, classType);
        }
        public static void GetPlayerStats(out string name, out int age, out string classType)
        {
            Console.WriteLine("What is your nigger's name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your nigger's age?");
            string stringAge = Console.ReadLine();
            while (!int.TryParse(stringAge, out age))
            {
                Console.WriteLine("Please enter an integer for the player's age.");
                stringAge = Console.ReadLine();
            }
            
            Console.WriteLine("What is your niggers's class?");
            classType = Console.ReadLine();
        }
        public static void DisplayPlayerStats(string name, int age, string classType)
        {
            Console.Clear();
            Console.WriteLine("=== Player Profile ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Class: {classType}");
        }
    }
}