// Collections is the name for any sort of array, list, or hashmap

// List 
List<int> myList = new List<int> { 1, 2, 3 };
Console.WriteLine(myList[0].ToString() + myList[1].ToString() + myList[2].ToString());

List<int> myNewList = [1, 2, 3];
Console.WriteLine(myNewList[1]);

int[] ints = { 1, 2, 3 };
Console.WriteLine(ints[0]);

// 2D Array
int[,] twoDimensions = { { 1, 2, 3 }, { 5, 6, 7 } };
Console.WriteLine("Two Dimensions: " + twoDimensions[0,2]);

// Dictionary
Dictionary<string, int> ages = new Dictionary<string, int>
{
    { "Wyatt", 19 },
    { "Grace", 19 }
};
Console.WriteLine(ages["Wyatt"]);