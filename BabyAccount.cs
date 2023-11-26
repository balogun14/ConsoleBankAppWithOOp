
namespace ConsoleBankApp
{
    public class BabyAccount : CustomerAccount
    {
        // Override the WithdrawFunds method from the CustomerAccount class
        public override void WithdrawFunds(decimal amount)
        {
            // Check if the withdrawal amount exceeds the limit 2000
            if (amount > 2000)
            {
                // Display a message with color to indicate the limit has been exceeded
                HelperFunctions.MessageWithColor("Limit Exceeded which is 2000", ConsoleColor.DarkRed);
                return; // Exit // If  proceed withdrawal
            }
            base.WithdrawFunds(amount);
        }
    }
}
//
//In this code, the `BabyAccount` class is a subclass of the `CustomerAccount` class. The `WithdrawFunds` method is overridden to enforce a withdrawal limit of 2000 for baby accounts. If the withdrawal amount exceeds this limit, a message with color is displayed to indicate the limit has been exceeded, and the withdrawal is not processed..</s>