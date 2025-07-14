

// array of 3 names
// ask:<whichnumbertoselect>
// return the name once user gives the number
// check for invalid numbers.

string[] names = new string[] { "jayson", "david", "seb" };

Console.Write("Which number do you want to select: ");
string numberText = Console.ReadLine();

bool isValidNumber = int.TryParse(numberText, out int number);


if (!isValidNumber)
{
    Console.WriteLine("Invalid number");
    return;
}

bool isOutOfBounds =  number > names.Length - 1;

if (isOutOfBounds)
{
    Console.WriteLine("Number given is larger the the nubmer of names in the array");
    return;
}

Console.WriteLine($"The name based on the number given is {names[number]}");

