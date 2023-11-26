namespace ConsoleBankApp
{
    public class BabyAccount : CustomerAccount
    {
        public override void WithdrawFunds(decimal amount)
        {
            if (amount > 2000)
            {
                HelperFunctions.MessageWithColor("Limit Exceeded which is 2000", ConsoleColor.DarkRed);
                return;
            }
            base.WithdrawFunds(amount);
        }
    }
}