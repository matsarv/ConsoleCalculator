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
                    Console.Write("> ");

                    string stringOperation = Console.ReadLine();

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
                    Console.WriteLine(" \n Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        public static double RunAdditionMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.Write("> ");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.Write("> ");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = firstNumber + secondNumber;

            Console.WriteLine(" The result is:");
            Console.Write("> ");
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);

            Console.WriteLine("\n Continue add number?(y/n)? ");
            Console.Write("> ");

            string assignmentChoise = (Console.ReadLine() ?? "");

            if (assignmentChoise == "y")
            {
                RunAdditionLoopMethod(result);
            }

            double RunAdditionMethod = result;
            return RunAdditionMethod;
        }

        public static double RunSubstractionMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.Write("> ");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.Write("> ");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = firstNumber - secondNumber;

            Console.WriteLine(" The result is:");
            Console.Write("> ");
            Console.Write(firstNumber + " - " + secondNumber + " = " + result);

            double RunSubstractionMethod = result;
            return RunSubstractionMethod;
        }

        public static double RunMultiplicationMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.Write("> ");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.Write("> ");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = firstNumber * secondNumber;

            Console.WriteLine(" The result is:");
            Console.Write("> ");
            Console.Write(firstNumber + " * " + secondNumber + " = " + result);

            double RunMultiplicationMethod = result;
            return RunMultiplicationMethod;
        }

        public static double RunDivisionMethod()
        {
            Console.WriteLine(" Type first number:");
            Console.Write("> ");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Type second number:");
            Console.Write("> ");

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
            Console.Write("> ");
            Console.Write(firstNumber + " / " + secondNumber + " = " + result);

            double RunDivisionMethod = result;
            return RunDivisionMethod;

            }
        }

        public static double RunAdditionLoopMethod(double result)
        {
            int i = 0;
            do
            {
                Console.WriteLine(" Operation:");
                Console.WriteLine("> +");

                //double firstNumber = result;

                Console.WriteLine(" First number:");
                //Console.Write("> " + firstNumber);
                Console.Write("> " + result);

                Console.WriteLine(" \nType second number:");
                Console.Write("> ");

                double secondNumber = Convert.ToDouble(Console.ReadLine());

                result = result + secondNumber;

                Console.WriteLine(" The result is:");
                Console.Write("> ");
                Console.Write(result + " + " + secondNumber + " = " + result);

                Console.WriteLine("\n Continue add number?(y/n)? ");
                Console.Write("> ");
                string assignmentChoise = (Console.ReadLine() ?? "");

                if (assignmentChoise == "n")
                {
                    i = 1;
                }

            } while (i < 1);

            double RunDivisionMethod = result;
            return RunDivisionMethod;
        }
    }

}
