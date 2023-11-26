
namespace ConsoleBankApp
{
    public class NewAccountCreation
    {
        // Declare a static HashTable to store accounts.
        public static readonly HashTable hashTable = new();

        // Method to create a new account.
        public static void CreateNewAccount()
        {
            // Display a welcome message.
            HelperFunctions.WelcomeMessage();

            // Prompt the user for their age.
            Console.Write("How old are you: ");
            uint age = uint.Parse(Console.ReadLine()!);

            // Check if the user is 18 or older.
            if (age >= 18)
            {
                // Create a new CustomerAccount object.
                CustomerAccount customerAccount = new()
                {
                    Address = InputFunctions<String>.UserInput("What is your address"),
                    FirstName = InputFunctions<String>.UserInput("What is your first name"),
                    LastName = InputFunctions<String>.UserInput("What is your last name"),
                    Age = (int)age,
                    InitialBalance = InputFunctions<decimal>.UserInput("What is your initial Balance"),
                    Password = InputFunctions<String>.UserInput("What is your Password")
                };

                // Store the new account in the HashTable.
                hashTable.StoreAccount(customerAccount);

                // Display a success message.
                HelperFunctions.MessageWithColor("Congratulation's You have created a new Account");

                // the user in.
                Console.WriteLine("Try Logging in");

                // Attempt to log in with the new account.
                AccountLogin<CustomerAccount>.Login(customerAccount);
            }
            else
            {
                // Create a new BabyAccount object.
                BabyAccount babyAccount = new()
                {
                    Address = InputFunctions<String>.UserInput("What is your address"),
                    FirstName = InputFunctions<String>.UserInput("What is your first name"),
                    LastName = InputFunctions<String>.UserInput("What is your last name"),
                    Age = (int)age,
                    InitialBalance = InputFunctions<decimal>.UserInput("What is your initial Balance"),
                    Password = InputFunctions<String>.UserInput("What is your Password")

                };

                // Store the new account in the HashTable.
                hashTable.StoreAccount(babyAccount);

                // Display a success message.
                HelperFunctions.MessageWithColor("Congratulation's You have created a new Account");

                // Prompt the user to try logging in.
                Console.WriteLine("Try Logging in");

                // Attempt to log in with the new account.
                AccountLogin<BabyAccount>.Login(babyAccount);
            }
        }

        // Method to display a welcome message with the user's name.
        public static void WelcomeMessage(string userName)
        {
            HelperFunctions.MessageWithColor($"Welcome Back {userName}");
        }
    }
}
//
//This code creates a new account for a user based on their age. It stores the account in a HashTable for future use. The code also includes a method to display a welcome message with the user's name..</s>