

// dictionary list of employee Ids and name.
// fill in a few records, ask the user for their ID and return their name.

//Current employee dictionary list

Dictionary<string, string> employee = new Dictionary<string, string>();
employee["1"] = "Jayson";
employee["123"] = "David";
employee["5123"] = "Seb";
employee["222"] = "Ash";

Console.Write("Enter employee Id");
string employeeId = Console.ReadLine();

Console.WriteLine($"The employee name is {employee[employeeId]}");

