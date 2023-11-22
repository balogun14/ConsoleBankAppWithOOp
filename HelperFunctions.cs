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
        public static void WelcomeMessage()
        {
            string[] rules = {
            "You have to be 18 years or older to open an adult account otherwise you open a children account ",
            "You must be a law abiding citizen of nigeria",
            "All Customers must provide a valid address"
        };
            MessageWithColor("Welcome to our Bank");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-+-+-+-+-+ Rules -+-+-+-+-+-+ ");
            foreach (var item in rules)
            {
                Console.WriteLine(item + '.');

            }
        }
        public static void DashBoard()
        {
            string operationYoucanPerform = @"
            1. Deposit Funds.
            2. Withdrawl Funds.
            3. Check Balance
            ";
            Console.WriteLine(operationYoucanPerform);
        }
        public static void AdultAccountOperations(CustomerAccount account)
        {
            bool condition = true;

            while (condition)
            {
                DashBoard();
                int choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 1:
                        account.PayInFunds();
                        break;
                    case 2:
                        Console.Write("How muh are you withdrawing: ");
                        decimal amount = decimal.Parse(Console.ReadLine()!);
                        account.WithdrawFunds(amount);
                        break;
                    case 3:
                        account.DisplayDetails();
                        break;
                    default:
                        MessageWithColor("Option Not Available", ConsoleColor.DarkRed);
                        break;
                }
            }
        }
        public static void BabyAccountOperations(BabyAccount account)
        {
            bool condition = true;

            while (condition)
            {
                DashBoard();
                int choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 1:
                        account.PayInFunds();
                        break;
                    case 2:
                        Console.Write("How much are you withdrawing: ");
                        decimal amount = decimal.Parse(Console.ReadLine()!);
                        account.WithdrawFunds(amount);
                        break;
                    case 3:
                        account.DisplayDetails();
                        break;
                    default:
                        MessageWithColor("Option Not Available", ConsoleColor.DarkRed);
                        break;
                }
            }
        }

    }
    class InputFunctions<T>
    {
        public static T UserInput(string message)
        {
            Console.Write(message + ": ");
            string value = Console.ReadLine()!;
            T output = (T)Convert.ChangeType(value, typeof(T));
            return output;

        }
    }
}