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
                    //Console.WriteLine("Use X to exit \n ");
                    //Console.ReadKey();
                    //Console.Clear();

                    Console.Write("> ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("> (+, -, /, *): ");
                    string assigmentChoise = Console.ReadLine();

                    Console.Write("> ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    //Console.Write("Enter assigment number (or -1 to exit): ");
                    //var assigmentChoise = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assigmentChoise)
                    {
                        case "+":
                            //RunAdditionMethod();
                            Console.Write("> ");
                            Console.Write(number1 + number2);
                            break;
                        //case 2:
                        //    break;
                        //case 3:
                        //    break;
                        //case 4:
                        //    break;
                        //case 5:
                        //    break;
                        //case 6:
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("> This is not a valid assigment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("\n\n> Enter to continue or x to quit!");
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
                    Console.WriteLine("> This is not a valid assigment number!");
                    Console.ResetColor();
                    Console.WriteLine("> Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }

}
