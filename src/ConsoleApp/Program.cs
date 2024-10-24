// See https://aka.ms/new-console-template for more information

using System.Linq;
using ConsoleApp;

Console.WriteLine("Hello, World!");

var enumerableOfNumbers = Enumerable.Range(1, 999);
var listOfNumbers = enumerableOfNumbers.ToList();

// you can't do forEach on an array
// listOfNumbers.ToArray().ForEach(x => Console.WriteLine(x));

// but you can do it on a LIST
Console.WriteLine("Numbers:");
listOfNumbers.ForEach(x => Console.WriteLine(x));

// though that incurs a penalty (converting to a list), instead in c# you'd do:
var sum = 0;

foreach (var number in enumerableOfNumbers)
{

    if (Multiples.IsMultipleOf(number, [3, 5]))
    {
        sum = sum + number;
    }
}

// some people also use LINQ, which can be written in SQL syntax
// foreach (var number in from number in enumerableOfNumbers
//                        where Multiples.isMultipleOf(number, [3, 5])
//                        select number)
// {
//     sum = sum + number;
// }

// or if you want to be fancy.... (which isn't more readable...)
// foreach (var number in enumerableOfNumbers)
// {
//     sum = sum + (Multiples.isMultipleOf(number, [3, 5]) ? number : 0);
// }

Console.WriteLine("Sum of multiples of 3 and 5 under 1000: {0}", sum);
