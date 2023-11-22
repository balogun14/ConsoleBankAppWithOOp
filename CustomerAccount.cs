namespace ConsoleBankApp
{
    public class CustomerAccount : AccountClass, IAccount
    {
        private string firstName = default!;
        private string lastName = default!;
        private string address = default!;
        private readonly decimal charges = 20; //Bank changes which is 20 naira per transaction
        private int age;
        private decimal balance;

        public override string FirstName { get => firstName; set => firstName = value; }
        public override int Age { get => age; set => age = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override string Address { get => address; set => address = value; }

        public decimal GetBalance()
        {
            return balance;
        }

        public void PayInFunds()
        {
            Console.Write("How much do you want to pay in to the account: ");
            bool choice = decimal.TryParse(Console.ReadLine()!, out decimal amount);
            if (choice)
            {
                balance += amount;
                HelperFunctions.MessageWithColor("Successful");
            }
            else
            {
                HelperFunctions.MessageWithColor("Invalid Transaction", ConsoleColor.DarkRed);
            }
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
            HelperFunctions.MessageWithColor($"your new balance is {GetBalance()}, you withdrew {amount} + charges{charges}");

        }
    }
}