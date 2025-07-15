

//like an array
// modernway of storing data.

List<string> firstNames = new List<string>();  //List of T (GENERIC) any name. only strings
//set of strings, first name
// initializing it - meaning setup that list.
// create that list and put it in firstname

firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jnae");
firstNames.Add("Frank");


Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);

// List<T> - generic.
// because of the fact that we get to used when we create
// the list of what that t is going to be.
// list of t, choosing the type that you passed in.

//length arrays, count list

string data = "Corey,Smith,Jones";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");//primary way of working with data.

