namespace ConsoleBankApp
{
    public class AccountLogin<T> where T : CustomerAccount
    {
        static readonly HashTable hashTable = NewAccountCreation.hashTable;
        public static void Login(T account)
        {
            var userName = InputFunctions<String>.UserInput("What is your First Name");
            var userPassword = InputFunctions<String>.UserInput("What is your password");
            var isAuthenticated = hashTable.GetAccount(userName, userPassword);
            if (isAuthenticated == false)
            {
                return;
            }
            var name = hashTable.FindAccount(userName);
            NewAccountCreation.WelcomeMessage(name!.FirstName);
            hashTable.AccountOperations(account);
        }
        public static void Login()
        {
            var userName = InputFunctions<String>.UserInput("What is your First Name");
            var userPassword = InputFunctions<String>.UserInput("What is your password");
            var isAuthenticated = hashTable.GetAccount(userName, userPassword);
            if (isAuthenticated == false)
            {
                Console.WriteLine("Password is incorrect");
                return;
            }
            var name = hashTable.FindAccount(userName);
            NewAccountCreation.WelcomeMessage(name!.FirstName);
            hashTable.AccountOperations(name);
        }
    }
}