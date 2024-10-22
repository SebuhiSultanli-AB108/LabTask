using Extension.Models;

namespace Extension;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("IsOdd and IsEven: \n");
        Console.WriteLine("Is 5 even: " + 5.IsEven());
        Console.WriteLine("Is 6 even: " + 6.IsEven());
        Console.WriteLine("Is 5 odd: " + 5.IsOdd());
        Console.WriteLine("Is 6 odd: " + 6.IsOdd());
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("HasDigit: \n");
        Console.WriteLine("Does 'salam' has digit: " + "salam".HasDigit());
        Console.WriteLine("Does 'sa1am' has digit: " + "sa1am".HasDigit());
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("CheckPassword: \n");
        Console.WriteLine("Is 'Salam1234' a safe password: " + "Salam1234".CheckPassword());
        Console.WriteLine("Is 'Salam' a safe password: " + "Salam".CheckPassword());
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Capitalize: \n");
        string text = "Salam necesen? Allah seni qorusun!";
        Console.WriteLine("Original version: " + text);
        Console.WriteLine("Capitalize version: " + text.Capitalize());
        Console.WriteLine("--------------------------------------------------------");
    }
}