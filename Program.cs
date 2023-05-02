// 1. Iterate and print values
Console.WriteLine("Given a List of strings, iterate through the List and print out all the values. ");
static void PrintList(List<string> MyList)
{
    foreach (string item in MyList)
    {
        Console.WriteLine(item);
    }
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);
Console.WriteLine("\n");


// 2. Print Sum
Console.WriteLine("Given a List of integers, calculate and print the sum of the values.");
static int SumOfNumbers(List<int> IntList)
{
    int totalSum = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        totalSum += IntList[i];
        Console.WriteLine(totalSum);
    }
    return totalSum;
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);
Console.WriteLine("\n");


// 3. Find Max
Console.WriteLine("Given a List of integers, find and return the largest value in the List.");
static int FindMax(List<int> IntList)
{
    int LargestNumber = IntList[0];
    for (int i = 0; i < IntList.Count; i++)
    {
        if (LargestNumber < IntList[i])
        {
            LargestNumber = IntList[i];
        } 
        else 
        {
            Console.WriteLine($"The current largest number is {LargestNumber}");
        }
    }
    Console.WriteLine(LargestNumber);
    return LargestNumber;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
FindMax(TestIntList2);
Console.WriteLine("\n");


// 4. Square the Values
Console.WriteLine("Given a List of integers, return the List with all the values squared.");
static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] *= IntList[i];
    }
    foreach (int item in IntList)
    {
        Console.WriteLine(item);
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);
Console.WriteLine("\n");


// 5. Replace Negative Numbers with 0
Console.WriteLine("Given an array of integers, return the array with all values below 0 replaced with 0.");
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if( IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    foreach (int number in IntArray)
    {
        Console.WriteLine(number);
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);
Console.WriteLine("\n");


// 6. Print Dictionary
Console.WriteLine("Given a dictionary, print the contents of the said dictionary.");

static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);
Console.WriteLine("\n");


// 7. Find Key
Console.WriteLine("Given a search term, return true or false whether the given term is a key in a dictionary. (Hint: figuring this one out may require some research!");
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    bool isFound = false;
    if (MyDictionary.ContainsKey(SearchTerm))
    {
        isFound = true;
    }
    // Console.WriteLine(isFound);
    return isFound;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));
Console.WriteLine("\n");


// 8. Generate a Dictionary
Console.WriteLine("Given a List of names and a List of integers, create a dictionary where the key is a name from the List of names and the value is a number from the List of numbers. Assume that the two Lists will be of the same length. Don't forget to print your results to make sure it worked.");
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 

// List 1
List<string> Names = new List<string>();
// Use the Add function in a similar fashion to push
Names.Add("Kawasaki");
Names.Add("Triumph");
Names.Add("BMW");

// Making sure the List has values
// Console.WriteLine(Names.Count);

// List 2
List<int> Numbers = new List<int>();

// Use the Add function in a similar fashion to push
Numbers.Add(4);
Numbers.Add(6);
Numbers.Add(8);

// Making sure the List has values
// Console.WriteLine(Names.Count);

static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary <string, int> newDictionary = new Dictionary <string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        newDictionary.Add(Names[i], Numbers[i]);
    }

    foreach (KeyValuePair<string, int> entry in newDictionary)
    {
        Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
    }
    // Console.WriteLine(newDictionary);
    return newDictionary;
}
GenerateDictionary(Names, Numbers);
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here

