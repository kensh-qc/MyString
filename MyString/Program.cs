using System;

namespace MyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello World!";
            var testPositive = "ld!";
            var testNegative = "Check";
            var sameText = "Hello World!";
            var longText = "Check Hello World!";

            Console.WriteLine(new String(text).EndsWith(sameText));
        }
    }
}
