namespace ConsoleBankApp
{
    public interface IBank
    {

        CustomerAccount? FindAccount(ulong id);
        CustomerAccount? FindAccount(string name);
        bool StoreAccount(CustomerAccount account);
        bool GetAccount(string name, string pass);
    }

}