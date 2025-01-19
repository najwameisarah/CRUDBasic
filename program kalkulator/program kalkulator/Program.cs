using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                double num1 = 0;
                double num2 = 0;
                double operationResult = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        operationResult = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + operationResult);
                        break;
                    case "-":
                        operationResult = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + operationResult);
                        break;
                    case "*":
                        operationResult = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + operationResult);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            operationResult = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + operationResult);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }

                // Ask the user if they want to continue
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
                string continueResponse = Console.ReadLine();
                if (continueResponse.ToUpper() != "Y")
                {
                    continueProgram = false;
                }
            }

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
