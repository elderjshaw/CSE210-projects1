using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pick a number, any number. ");
        string numFromUser = Console.ReadLine();

        int x = int.Parse(numFromUser);
        int y = 5;

        if (x > y)
        {
            Console.WriteLine("Greater then y");
        }
        else if (x < y)
        {
            Console.WriteLine("Less then y");
        }
        else
        {
            Console.WriteLine("Both are equal");
        }
    }


   
        /*
//loops

//for loops

//foreach loops
List<string> fruits = new List<string>() { "Apple", "Bananana", "Cherry" };
foreach (string fruit in fruits)
{
Console.WriteLine(fruit);
}
//adding items to list
fruits.Add("Date");
fruits.Add("Eggplant");

fruits[0] = "Apricot";

Console.WriteLine(fruits[0]);

for (int i = 0; i < 10; i++)
{
Console.WriteLine($"i: {i}");
}

//while (*More commonly used)
Console.WriteLine("Make a choice  (y or n): ");
string value = Console.ReadLine().ToUpper();
while (value != "Y" && value != "N")
{
Console.Write("Choose y or n: ");
value = Console.ReadLine().ToUpper();
}

//functions
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        Console.WriteLine($"{number} is a great choice!");

// do while
do
{
Console.Write("Enter y or n: ");
value = Console.ReadLine().ToUpper();

} while (value != "Y" && value != "N");
*/


}