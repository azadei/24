using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<char> letterSet = new List<char> { 'X', 'Y' };
        List<int> numberSet = new List<int> { 1, 2, 3 };
        List<string> colourSet = new List<string> { "Green", "Orange" };

        
        var cartesianProduct = from letter in letterSet
                               from number in numberSet
                               from colour in colourSet
                               select new { letter, number, colour };

        
        Console.WriteLine("The cartesian product is:");
        foreach (var item in cartesianProduct)
        {
            Console.WriteLine("{ letter = " + item.letter + ", number = " + item.number + ", colour = " + item.colour + " }");
        }

    }
}