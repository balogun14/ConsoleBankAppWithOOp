using System.Collections;

namespace ConsoleBankApp
{
    public class HashTable : IBank
    {
        readonly Hashtable bankHashTable = new();
        public CustomerAccount? FindAccount(ulong id)
        {
            return bankHashTable[id] as CustomerAccount;
        }
        public CustomerAccount? FindAccount(string name)
        {
            return bankHashTable[name] as CustomerAccount;
        }

        public bool GetAccount(string name, string pass)
        {
            var findAccount = FindAccount(name);
            if (findAccount == null)
            {
                Console.WriteLine("Account Does Not Exist");
                return false;

            }
            if (findAccount.Password == pass)
            {
                return true;
            }
            return false;
        }

        public bool StoreAccount(CustomerAccount account)
        {
            bankHashTable.Add(account.GetName(), account);
            return true;
        }
        public void AccountOperations(CustomerAccount account)
        {
            bool condition = true;

            while (condition)
            {
                HelperFunctions.DashBoard();
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
                    case 4:
                        NewAccountCreation.CreateNewAccount();
                        break;
                    case 5:
                        account.ChangeUserPassword();
                        break;
                    case 6:
                        condition = false;
                        break;
                    case 7:
                    HelperFunctions.MessageWithColor("You exited Succesfully");
                    condition = false;
                        break;
                    default:
                        HelperFunctions.MessageWithColor("Option Not Available", ConsoleColor.DarkRed);
                        break;
                }
            }
        }

    }



}
