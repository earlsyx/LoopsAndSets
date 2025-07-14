
bool continueAsking = true;


do
{
    Console.Write("What is your Firstname?");
    string firstName = Console.ReadLine();
    string formattedName;
    if (firstName.ToLower() == "tim")
    {
        formattedName = $"Professor {firstName}";
        Console.WriteLine($"Welcome {formattedName}");
    }
    else
    {
        Console.WriteLine($"Welcome {firstName}");
    }

    Console.Write($"Type \"exit\" to stop asking the name ");
    var inputText = Console.ReadLine();
    if (inputText.ToLower() == "exit")
    {
        continueAsking = false;
    }
}
while (continueAsking);