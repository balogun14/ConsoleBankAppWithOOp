

using ConsoleBankApp;

try
{
    // Start the application loop
    bool condition = true;
    while (condition)
    {
        // Display the dashboard message
        string dashboardMessage = "Welcome to the Bank.\nWhat can we do for you\n1.Create an Account.\n2.Login to your Account\n3. Quit";
        Console.WriteLine(dashboardMessage);

        // Get the user's choice
        var UserChoice = InputFunctions<String>.UserInput("What is Your Option");
        switch (UserChoice)
        {
            case "1":
                // Create a new account
                NewAccountCreation.CreateNewAccount();
                break;
            case "2":
                // Login to an existing account
                AccountLogin<CustomerAccount>.Login();
                break;
            case "3":
                // Quit the application
                condition = false;
                break;
            default:
                // Display message if the user's choice is invalid
                HelperFunctions.MessageWithColor("Read The Dashboard Message", ConsoleColor.DarkRed);
                break;
        }
    }

}

catch (Exception ex)
{
    // Display an error message if an exception occurs
    Console.WriteLine("An error Occured: " + ex.Message);
}

//This code provides a user interface for a banking application. It starts by displaying a dashboard message with options for the user. The user can choose to create a new account, login to an existing account, or quit the application. The code handles each option accordingly and provides error handling for invalid user choices or unexpected exceptions..</s>