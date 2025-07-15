
bool addMoreStudents = true;
List<string> students = new List<string>();

do
{
	Console.WriteLine("Enter Student to be added");
	Console.Write("Add: ");
	string studentsText = Console.ReadLine();
	students.Add(studentsText);
	Console.Write("Do you want to add more? Yes/No");
	string answer = Console.ReadLine();
	if(answer.ToLower() == "yes")
    {
        addMoreStudents = true;
    }
	else if (answer.ToLower() == "no")
	{
		addMoreStudents = false;
        Console.WriteLine("List of Students:");
		for (int i = 0; i < students.Count; i++)
		{
            Console.WriteLine(students[i]);
        }
    }
	else
	{
        Console.WriteLine("Not a valid answer!");
	}
} while (addMoreStudents);