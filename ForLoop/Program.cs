
//set up variable for counting. not descriptive ,standard.
//only last for duration of for loop. universal . i j k.
// initialization. zero based counting. match up with arrays.
// starting value

//next. 2 part.
//evalutation portion then run if true.
// reinitialied variable.

//3. I++, i become one. repeat.
// loop through a set number of tie.
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"The value of I is{i}");
//}

//string data = "Tim,Sue,Bob,Jane,Frank";
//List<string> firstNames = data.Split(',').ToList();

////loop , work with ever single item in the lsit.
//// sets of dat.a some type of action in every element.
//for (int i = 0; i < firstNames.Count; i++)
//{
//    Console.WriteLine($"{firstNames[i]} is in attendance");
//}

List<decimal> charges = new(); //oop new trick 

charges.Add(23.78M);
charges.Add(15.23M);
charges.Add(125M);

decimal total = 0;
//loops through in each element in a set. like adding.
// how to operate in every element.
for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Total charge is {total}");
