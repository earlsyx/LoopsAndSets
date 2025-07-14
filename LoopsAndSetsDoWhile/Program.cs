
bool isValidAge;
int age;

int testNumber = 0;


//infinite loop- bad thing, stack overflow.

do
{
    Console.WriteLine("What is your age");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        Console.WriteLine("Invalid age");
    }

} while (isValidAge == false); //evaluates , statement
Console.WriteLine($"Your age is {age}");



//do
//{
// run the code atleast once
//} while (true);


//while (true)
//{
// will only run if expression is true
//}

