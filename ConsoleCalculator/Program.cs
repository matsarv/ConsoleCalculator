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
                    Console.WriteLine(" Welcome to the Calculator \n ");

                    Console.WriteLine(" Type of operation ( +  -  /  * ) or x to exit:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("> ");
                    Console.ResetColor();

                    string stringOperation = (Console.ReadLine() ?? "");

                    switch (stringOperation)
                    {
                        case "+":
                            RunAdditionMethod();
                            break;

                        case "-":
                            RunSubstractionMethod();
                            break;

                        case "*":
                            RunMultiplicationMethod();
                            break;
                        
                        case "/":
                            RunDivisionMethod();
                            break;

                        case "x":
                            keepAlive = false;
                            return;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Not a valid operation!");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\n\n Press Enter to continue or x to quit!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("> ");
                    Console.ResetColor();

                    string assigmentKey = Console.ReadLine();
                    assigmentKey = assigmentKey.ToLower();

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
                    Console.WriteLine(" \n Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        // <summary>
        // Will ask for numbers and perform Addition and present result
        // Will ask to continue add numbers for Addition
        public static double RunAdditionMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = firstNumber + secondNumber;

            Console.WriteLine(" The result is:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);

            Console.WriteLine("\n Continue add number? (y/n) ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            string assignmentChoise = (Console.ReadLine() ?? "");
            assignmentChoise = assignmentChoise.ToLower();

            if (assignmentChoise == "y")
            {
                RunAdditionLoopMethod(result);
            }

            double RunAdditionMethod = result;

            return RunAdditionMethod;
        }
        // <summary>
        // Will ask for numbers and perform Substraction and present result
        // Will ask to continue add numbers for Substraction
        public static double RunSubstractionMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = firstNumber - secondNumber;

            Console.WriteLine(" The result is:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();
            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result);

            Console.WriteLine("\n Continue add number? (y/n) ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            string assignmentChoise = (Console.ReadLine() ?? "");
            assignmentChoise = assignmentChoise.ToLower();

            if (assignmentChoise == "y")
            {
                RunSubstractionLoopMethod(result);
            }

            double RunSubstractionMethod = result;

            return RunSubstractionMethod;
        }

        // <summary>
        // Will ask for numbers and perform Multiplication and present result
        // Will ask to continue add numbers for Multiplication
        public static double RunMultiplicationMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.Write("> ");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = firstNumber * secondNumber;

            Console.WriteLine(" The result is:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();
            Console.Write(firstNumber + " * " + secondNumber + " = " + result);

            double RunMultiplicationMethod = result;

            return RunMultiplicationMethod;
        }

        // <summary>
        // Will ask for numbers and perform Division and present result
        // Will ask to continue add numbers for Division
        public static double RunDivisionMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.Write("> ");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = firstNumber / secondNumber;

            if (firstNumber == 0 || secondNumber == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Not a valid number (0)!");
                Console.ResetColor();

                double RunDivisionMethod = result;
                return RunDivisionMethod;
            }
            else
            {
                Console.WriteLine(" The result is:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.Write(firstNumber + " / " + secondNumber + " = " + result);

            double RunDivisionMethod = result;

            return RunDivisionMethod;

            }
        }

        // <summary>
        // Will ask for numbers and perform Addition Loop and present result
        public static double RunAdditionLoopMethod(double result)
        {
            int i = 0;
            do
            {
                Console.WriteLine("\n Operation:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.WriteLine("+");

                Console.WriteLine(" First number:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.Write(result);

                Console.WriteLine(" \nType second number:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.ResetColor();

                double secondNumber = Convert.ToDouble(Console.ReadLine());

                result = result + secondNumber;

                Console.WriteLine(" The result is:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.Write(result + " + " + secondNumber + " = " + result);

                Console.WriteLine("\n\n Continue add number? (y/n) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();

                string assignmentChoise = (Console.ReadLine() ?? "");
                assignmentChoise = assignmentChoise.ToLower();

                if (assignmentChoise == "n")
                {
                    i = 1;
                }

            } while (i < 1);

            double RunDivisionMethod = result;

            return RunDivisionMethod;
        }

        // <summary>
        // Will ask for numbers and perform Substraction Loop and present result
        public static double RunSubstractionLoopMethod(double result)
        {
            int i = 0;
            do
            {
                Console.WriteLine("\n Operation:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.WriteLine("+");

                Console.WriteLine(" First number:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.Write(result);

                Console.WriteLine(" \nType second number:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();

                double secondNumber = Convert.ToDouble(Console.ReadLine());

                result = result - secondNumber;

                Console.WriteLine(" The result is:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();
                Console.Write(result + " - " + secondNumber + " = " + result);

                Console.WriteLine("\n\n Continue add number? (y/n) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ResetColor();

                string assignmentChoise = (Console.ReadLine() ?? "");
                assignmentChoise = assignmentChoise.ToLower();

                if (assignmentChoise == "y")
                {
                    i = 1;
                }

            } while (i < 1);

            double RunSubstractionMethod = result;

            return RunSubstractionMethod;
        }
    }

}
