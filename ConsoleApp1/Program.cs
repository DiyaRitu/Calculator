using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

/// <summary>
/// A simple console-based calculator program.
/// </summary>
class CalculatorProgram
{
    static void Main(string[] args)
    {
        /// <summary>
        /// The first number to operate on.
        /// </summary>
        float num1;

        /// <summary>
        /// The second number to operate on.
        /// </summary>
        float num2;

        /// <summary>
        /// The user's input for the operation type.
        /// </summary>
        string answer;

        /// <summary>
        /// The result of the operation.
        /// </summary>
        float result;

        Console.WriteLine("Hello, Welcome to the calculator program!");
        Console.WriteLine("Please enter your first number.");
        num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your second number.");
        num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("What type of operation would you like to do ?");
        Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division.");

        answer = Console.ReadLine().ToLower();

        if (answer == "a")
        {
            /// <summary>
            /// Perform addition.
            /// </summary>
            result = num1 + num2;
        }
        else if (answer == "s")
        {
            /// <summary>
            /// Perform subtraction.
            /// </summary>
            result = num1 - num2;
        }
        else if (answer == "m")
        {
            /// <summary>
            /// Perform multiplication.
            /// </summary>
            result = num1 * num2;
        }
        else
        {
            /// <summary>
            /// Perform division, handling division by zero.
            /// </summary>
            result = num2 == 0 ? float.NaN : num1 / num2;
        }

        if (float.IsNaN(result))
        {
            Console.WriteLine("Cannot divide by 0!");
        }
        else
        {
            Console.WriteLine("The result is " + result);
        }

        Console.WriteLine("Thank you for using the calculator program.");

        Console.ReadLine();
    }
}