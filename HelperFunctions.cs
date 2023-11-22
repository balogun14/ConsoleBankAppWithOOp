namespace ConsoleBankApp
{
    public class HelperFunctions
    {
        public static void MessageWithColor(string message, ConsoleColor consoleColor = ConsoleColor.Green)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}