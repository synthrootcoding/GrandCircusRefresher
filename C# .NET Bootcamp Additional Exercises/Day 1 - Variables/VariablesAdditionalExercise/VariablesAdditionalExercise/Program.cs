using System;

namespace VariablesAdditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 - Prompt the user to enter a string. After the user enters a string, output the same string back to the console.
            Console.WriteLine("Enter a string");
            string stringResponse = Console.ReadLine();
            Console.WriteLine(stringResponse);

            // Exercise 2 - Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.
            Console.WriteLine("Enter a number");
            int intResponse = Int32.Parse(Console.ReadLine()) + 1;
            Console.WriteLine(intResponse);

            // Exercise 3 - Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.
            Console.WriteLine("Enter another number");
            double doubleResponse = double.Parse(Console.ReadLine()) + 0.5;
            Console.WriteLine(doubleResponse);

            // Exercise 4 - Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.
            Console.WriteLine("Enter a number");
            double additionResponse = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double additionResponse2 = Double.Parse(Console.ReadLine());
            double additionSum = additionResponse + additionResponse2;
            Console.WriteLine(additionSum);

            // Exercise 5 - Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.
            Console.WriteLine("Enter a number");
            double multiplyResponse = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double multiplyResponse2 = double.Parse(Console.ReadLine());
            double multiplyProduct = multiplyResponse * multiplyResponse2;
            Console.WriteLine(multiplyProduct);
        }
    }
}
