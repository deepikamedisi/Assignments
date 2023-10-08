using System;

namespace CalculatorApp
{
    delegate int CalculatorDelegate(int number1, int number2);

    class Calculator
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!");
            CalculatorDelegate calculatorDelegate = null;

            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Quit");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                if (choice == 4)
                {
                    Console.WriteLine("Quitting the calculator");
                    break;
                }

                Console.Write("Enter the first number: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        calculatorDelegate = Calculator.Add;
                        break;
                    case 2:
                        calculatorDelegate = Calculator.Subtract;
                        break;
                    case 3:
                        calculatorDelegate = Calculator.Multiply;
                        break;
                }

                if (calculatorDelegate != null)
                {
                    int result = calculatorDelegate(num1, num2);
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please select a valid operation.");
                }
                Console.ReadLine();
            }
        }
    }
}
