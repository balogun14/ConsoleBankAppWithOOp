using ConsoleBankApp;

try
{
    while (true)
    {
        string dashboardMessage = "Welcome to the Bank.\nWhat can we do for you\n1.Create an Account.\n2.Login to your Account";
        Console.WriteLine(dashboardMessage);

        var UserChoice = InputFunctions<String>.UserInput("What is Your Option");
        switch (UserChoice)
        {
            case "1":
                NewAccountCreation.CreateNewAccount();
                break;
            case "2":
                AccountLogin<CustomerAccount>.Login();
                break;
            default:
                HelperFunctions.MessageWithColor("Read The Dashboard Message", ConsoleColor.DarkRed);
                break;
        }
    }

}

catch (Exception ex)
{
    Console.WriteLine("An error Occured: " + ex.Message);
}
