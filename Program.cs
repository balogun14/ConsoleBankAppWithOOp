using ConsoleBankApp;

HelperFunctions.WelcomeMessage();
try
{
    Console.Write("How old are you: ");
    uint age = uint.Parse(Console.ReadLine()!);
    if (age >= 18)
    {
        CustomerAccount customerAccount = new()
        {
            Address = InputFunctions<String>.UserInput("What is your address"),
            FirstName = InputFunctions<String>.UserInput("What is your first name"),
            LastName = InputFunctions<String>.UserInput("What is your last name"),
            Age = (int)age,
            InitialBalance = InputFunctions<int>.UserInput("What is your initial Balance")
        };
        HelperFunctions.AdultAccountOperations(customerAccount);
    }
    else
    {
        BabyAccount babyAccount = new()
        {
            Address = InputFunctions<String>.UserInput("What is your address"),
            FirstName = InputFunctions<String>.UserInput("What is your first name"),
            LastName = InputFunctions<String>.UserInput("What is your last name"),
            Age = (int)age,
            InitialBalance = InputFunctions<int>.UserInput("What is your initial Balance")
        };
        HelperFunctions.AdultAccountOperations(babyAccount);

    }


}
catch (Exception ex)
{

    Console.WriteLine("An error Occured: " + ex.Message);
}
