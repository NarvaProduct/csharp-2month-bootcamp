using System;
public class Dice
{
    public static int RollD6()
    {
        Console.Clear();
        Random random = new Random();
        int diceResult = random.Next(6);

        Console.WriteLine("Rolling a 6 sided dice!");
        for (int i = 0; i <= 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine($"\nThe dice rolled a {diceResult}!");
        Console.WriteLine("Press enter to continue");
        Console.ReadKey();
        Console.Clear();

        return diceResult;
    }
    public static int RollD20()
    {
        Console.Clear();
        Random random = new Random();
        int diceResult = random.Next(20);

        Console.WriteLine("Rolling a 20 sided dice!");
        for (int i = 0; i <= 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine($"\nThe dice rolled a {diceResult}!");
        Console.WriteLine("Press enter to continue");
        Console.ReadKey();
        Console.Clear();
        
        return diceResult;
    }
    public static int RollDCustom(int amountSides)
    {
        Console.Clear();
        Random random = new Random();
        int diceResult = random.Next(amountSides);

        Console.WriteLine($"Rolling a {amountSides} sided dice!");
        for (int i = 0; i <= 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine($"\nThe dice rolled a {diceResult}!");
        Console.WriteLine("Press enter to continue");
        Console.ReadKey();
        Console.Clear();
        
        return diceResult;
    }
}