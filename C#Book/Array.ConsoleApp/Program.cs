using System.Collections;

int[] arr = new int[3] { 7, 9, 4 };
Console.WriteLine(arr[0]); //outputs 7
Console.WriteLine(arr[1]); //outputs 9


int[] arr2 = new int[] { 24, 2, 13, 47, 45 };
int[] arr3 = { 24, 2, 13, 47, 45 };

// same as string[]
var arrStr = new[] { "one", "two", "three" };

//To create an  int array of size 5 filled with "100"


int[] intArray = Enumerable.Repeat(100, 5).ToArray();

foreach (int i in intArray)
{
    Console.WriteLine(i);
}

var sourceArray = new int[] { 11, 12, 3, 5, 2, 9, 28, 17 };
var destinationArray = new int[3];
Array.Copy(sourceArray, destinationArray, 3);
// destinationArray will have 11,12 and 3

foreach (int i in destinationArray)
{
    Console.WriteLine(i);
}
// Multi-dimensional arrays

int[,] arrMulti = new int[10, 10];

int[,] arrMulti2 = new int[4, 2] { 
    { 1, 1 }, 
    { 2, 2 }, 
    { 3, 3 }, 
    { 4, 4 } 
};


// Access a member of the multi-dimensional array:

Console.WriteLine(arrMulti2[3, 1]);  // 4


int[] arr5 = new int[] { 0, 10, 20, 30 };
// Get
Console.WriteLine(arr5[2]); // 20
                           // Set
arr[2] = 100;
// Get the updated value
Console.WriteLine(arr5[2]); // 100


int[] sequence = Enumerable.Range(1, 100).ToArray();

// This will generate an array containing the numbers 1 through 100 ([1, 2, 3, ..., 98, 99, 100]).