
using System.Runtime.InteropServices;

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
            int age, attack, defense, speed, powerScore;
            double gold, silver, copper;

            Player.GetPlayerStats(out name, out age, out classType);
            Player.DisplayPlayerStats(name, age, classType);

            Player.GetPlayerPowerScore(out attack, out defense, out speed, out powerScore, out powerRating);
            Player.DisplayPlayerPowerScore(attack, defense, speed, powerScore, powerRating);

            AskForMoney(out gold, out silver, out copper);
            DisplayMoney(gold, silver, copper);
        }


        public static void AskForMoney(out double gold, out double silver, out double copper)
        {
            string goldString; string silverString; string copperString;

            Console.WriteLine("Enter how much gold you have");
            goldString = Console.ReadLine();
            gold = Utils.CheckDoubleInput(goldString, "Please enter a valid amount of gold");

            Console.WriteLine("Enter how much silver you have");
            silverString = Console.ReadLine();
            silver = Utils.CheckDoubleInput(silverString, "Please enter a valid amount of silver");

            Console.WriteLine("Enter how much copper you have");
            copperString = Console.ReadLine();
            copper = Utils.CheckDoubleInput(copperString, "Please enter a valid amount of copper");
        }
        public static void DisplayMoney(double gold, double silver, double copper)
        {
            double totalinCopper = (gold * 100) + (silver * 10) + copper;
            double totalinGold = gold + (silver / 10) + (copper / 100);

            Console.WriteLine("=== Currency Conversion ===");
            Console.WriteLine($"Gold: {gold}  Silver: {silver}  Copper: {copper}");
            Console.WriteLine($"Total Copper: {totalinCopper}");
            Console.WriteLine($"Total Gold Equivalent: {totalinGold}");
        }
    }
}