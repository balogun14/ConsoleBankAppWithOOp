namespace ConsoleBankApp
{
    public class NewAccountCreation
    {
        public static readonly HashTable hashTable = new();
        public static void CreateNewAccount()
        {
            HelperFunctions.WelcomeMessage();
            Console.Write("How old are you: ");
            uint age = uint.Parse(Console.ReadLine()!);
            if (age >= 18)
            {
                CustomerAccount customerAccount = new()
                {
                    Address = InputFunctions<String>.UserInput("What is your address"),
                    FirstName = InputFunctions<String>.UserInput("What is your first name"),
                    LastName = InputFunctions<String>.UserInput("What is your last name"),
                    Age = (int)age,
                    InitialBalance = InputFunctions<decimal>.UserInput("What is your initial Balance"),
                    Password = InputFunctions<String>.UserInput("What is your Password")
                };
                hashTable.StoreAccount(customerAccount);
                HelperFunctions.MessageWithColor("Congratulation's You have created a new Account");
                Console.WriteLine("Try Logging in");
                AccountLogin<CustomerAccount>.Login(customerAccount);
            }
            else
            {
                BabyAccount babyAccount = new()
                {
                    Address = InputFunctions<String>.UserInput("What is your address"),
                    FirstName = InputFunctions<String>.UserInput("What is your first name"),
                    LastName = InputFunctions<String>.UserInput("What is your last name"),
                    Age = (int)age,
                    InitialBalance = InputFunctions<decimal>.UserInput("What is your initial Balance"),
                    Password = InputFunctions<String>.UserInput("What is your Password")

                };
                hashTable.StoreAccount(babyAccount);
                HelperFunctions.MessageWithColor("Congratulation's You have created a new Account");
                Console.WriteLine("Try Logging in");
                AccountLogin<BabyAccount>.Login(babyAccount);
            }


        }


        public static void WelcomeMessage(string userName)
        {
            HelperFunctions.MessageWithColor($"Welcome Back {userName}");

        }
    }
}