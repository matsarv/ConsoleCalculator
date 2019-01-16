using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    double result = 0;
                    Console.WriteLine(" Welcome to the Calculator \n ");
                    
                    Console.WriteLine(" Type first number:");
                    Console.Write("> ");
                    string stringFirstNumber = (Console.ReadLine());
                    double firstNumber = Convert.ToDouble(stringFirstNumber);

                    Console.WriteLine(" Type second number:");
                    Console.Write("> ");
                    string stringSecondNumber = (Console.ReadLine());
                    double secondNumber = Convert.ToDouble(stringSecondNumber);

                    Console.WriteLine(" Type operation ( +  -  /  * ):");
                    Console.Write("> ");
                    string stringOperation = Console.ReadLine();

                    switch (stringOperation)
                    {
                        case "+":
                            //RunAdditionMethod();
                            result = firstNumber + secondNumber;
                            break;

                        case "-":
                            //RunSubstractionMethod();
                            result = firstNumber - secondNumber;
                            break;
                        
                        case "/":
                            //RunDivisionMethod();
                            //if (firstNumber == 0 || secondNumber == 0)
                            result = firstNumber / secondNumber;
                            break;
                        case "*":
                            //RunMultiplicationMethod();
                            result = firstNumber * secondNumber;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Not a valid number!");
                            break;
                    }

                    Console.Write("\n Result: " + stringFirstNumber + " " + stringOperation + " " + stringSecondNumber + " = ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(result);
                    Console.ResetColor();
                    Console.WriteLine("\n\n Enter to continue or x to quit!");
                    Console.Write("> ");
                    string assigmentKey = Console.ReadLine();
                    if (assigmentKey == "x")
                    {
                        keepAlive = false;
                        return;
                    }
                    Console.Clear();
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" This is not a valid assigment number!");
                    Console.ResetColor();
                    Console.WriteLine(" Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

    }

}
