// Variables act very similar to any strongly typed language
// <data type> <varNameInCamelCase>;

int myVar;
myVar = 6;
Console.WriteLine(myVar);


// You can declare multiple variables at a time

int x = 4, y = 6, z = 8;
Console.WriteLine(x+y+z);

// You can assign multiple variables to the same value all at once

int a, b, c;
a = b = c = 1;
Console.WriteLine(a+b+c);

// C# Data Types

bool isTrue = true;
// long for a bigger int
int myInt = 123;
// float can only hold 6-7 digits after the decimal point
// due to this it is safer to use double for calculations
// double for a bigger float and calculations
double myDouble = 1.23; 

string myString = "abc";

// C# Type Casting
// Use Convert.to<Type>(value)

int testInt = 8724;
string testString = Convert.ToString(testInt);
Console.WriteLine(testString);