using System.Text.RegularExpressions;
namespace ConsoleBankApp
{
    public class CustomerAccount : AccountClass, IAccount
    {
        private ulong UniqueId = 0;
        private string firstName = default!;
        private string lastName = default!;
        private string address = default!;
        private readonly decimal charges = 20; //Bank changes which is 20 naira per transaction
        private int age;
        private decimal balance;
        private string password = default!;

        public override string FirstName
        {
            get => firstName;
            set
            {
                string result = MatchName(value);
                firstName = result;
            }
        }
        public override int Age { get => age; set => age = value; }
        public override string LastName
        {
            get => lastName; set
            {
                string result = MatchName(value);
                lastName = result;
            }
        }
        public override string Address { get => address; set => address = value; }
        public decimal InitialBalance
        {
            set
            {
                balance = value;
            }
        }

        public override string Password { get => password; set => password = value; }
        public CustomerAccount()
        {
            UniqueId++;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        private void NewBalance()
        {
            Console.WriteLine($"You New Balance is\nBalance:{GetBalance()}");
        }
        public void PayInFunds()
        {
            Console.Write("How much do you want to pay in to the account: ");
            bool choice = decimal.TryParse(Console.ReadLine()!, out decimal amount);
            if (choice)
            {
                balance += amount;
                HelperFunctions.MessageWithColor("Successful");
                NewBalance();
            }
            else
            {
                HelperFunctions.MessageWithColor("Invalid Transaction", ConsoleColor.DarkRed);
            }
        }
        public void DisplayDetails()
        {
            string message = $"Name: {FirstName}\nAddress:{Address}\nBalance:${GetBalance()}";
            Console.WriteLine(message);

        }
        public virtual void WithdrawFunds(decimal amount)
        {

            if (balance < amount + charges)
            {
                HelperFunctions.MessageWithColor("Insufficient Funds", ConsoleColor.DarkRed);
                return;
            }
            balance -= amount;
            HelperFunctions.MessageWithColor("Successful");
            HelperFunctions.MessageWithColor($"your new balance is ${GetBalance()}, you withdrew: ${amount} + charges: ${charges}");

        }

        public ulong GetId()
        {
            return UniqueId;
        }

        public string GetName()
        {
            return FirstName;
        }
        public string MatchName(string value)
        {
            string pattern = @"[0-9]";
            MatchCollection match;
            do
            {
                match = Regex.Matches(value, pattern);
                if (match.Count == 0)
                {
                    Console.WriteLine("Success");

                }
                else
                {
                    HelperFunctions.MessageWithColor("Name cannot contain special characters like numbers e.t.c", ConsoleColor.DarkRed);
                    Console.WriteLine("Enter the name again: ");
                    value = Console.ReadLine()!;
                }

            } while (match.Count != 0);

            return value;
        }

        public void ChangeUserPassword()
        {
            Console.WriteLine("What is your Previous Password: ");
            var prevPassword = Console.ReadLine()!;
            if (prevPassword == Password)
            {
                Console.WriteLine("What is your new Password: ");
                var newPassword = Console.ReadLine()!;
                var result = MatchName(newPassword);
                Password = result;
            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }

        }
    }
}