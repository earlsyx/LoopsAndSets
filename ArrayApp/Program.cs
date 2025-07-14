

//Array
// variable type that holds a bunch of somethings


//string[] firstNames = new string[5];
//create new string array first name, each string type

//firstNames[0] = "Tim"; //first elemnt ,
                       //position 0, item. 0 based counting, 0, 1,2,3,4


//firstNames[1] = "Sue";
//firstNames[2] = "Bob";
//firstNames[4] = "Jnae";

//Console.WriteLine($"The firstnames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

//firstNames[0] = "Timothy";
//Console.WriteLine(firstNames[0]);

//firstNames[5] = "ts";

//single quoute identifies a char '' efficment?
//double quote identifies as a string value

string data = "Tim,Sue,Bob,Jane,Frank"; //csv -share data between app that don't talk to each other.
string[] firstNames = data.Split(',');

Console.WriteLine(firstNames[firstNames.Length - 1]);

Console.WriteLine(firstNames.Length);//one based counting

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] { 2, 3, 4 };
//set of data besides of arrays. more modern.