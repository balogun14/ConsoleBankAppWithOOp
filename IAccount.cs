namespace ConsoleBankApp
{
    public interface IAccount
    {
        public void WithdrawFunds(decimal amount);
        public void PayInFunds();
        public decimal GetBalance();
        public ulong GetId();
        public string GetName();
        public string MatchName(string value);
        public void ChangeUserPassword();



    }
}