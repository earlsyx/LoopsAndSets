

//use ful type of set,
//Tkey: the type of the keys in dictionary
//T value
Dictionary<string, string> lookup = new Dictionary<string, string>();

//like a dictionary, look up words, gets definition
//key string (word) 

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swim";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is {lookup["fish"]}");


//same as list, instead of index 0 1 2 etc.
// indext is based upon the value we passed in

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Tim Corey";
employees[28] = "Sue Storm";
//doesn't matter if not sequential.

Console.WriteLine($"The employee id 28 is {employees[28]}");

//keys and values, each has its own type.

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thurday"] = 5;
dayOfWeek["Friday"] = 6;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}");

//immportnt, keys can only be one, so unique. cant be duplicate other wase value will be change.


