public class Utils
{
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
    public static double CheckDoubleInput(string? stringDouble, string message)
    {
        double output;
        while (!double.TryParse(stringDouble, out output) || output <= 0)
        {
            Console.Clear();
            Console.WriteLine(message);
            stringDouble = Console.ReadLine();
            Console.Clear();
        }
        return output;
    }
}