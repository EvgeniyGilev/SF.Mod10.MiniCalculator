using System;
using SF.Mod10.MiniCalculator.Interfaces;

namespace SF.Mod10.MiniCalculator
{
    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        public static ILogger Logger { get; set; }

        /// <summary>
        /// Mains the.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Logger = new Logger();
            var miniCalculator = new MiniCalculator(Logger);

            Console.WriteLine("Целочисленный калькулятор");

            do
            {
                try
                {
                    Console.WriteLine("Введите число 1:");
                    var number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число 2:");
                    var number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Нажмите клавишу, соответствующую операции: + , - , * , / или пробел для повторного ввода чисел и выхода");
                    var keyentered = Console.ReadKey();
                    while (keyentered.Key != ConsoleKey.Spacebar)
                    {
                        switch (keyentered.Key)
                        {
                            case ConsoleKey.Add:
                                ((IIntCalculate)miniCalculator).SumTwoNumbers(number1, number2);
                                break;
                            case ConsoleKey.Subtract:
                                ((IIntCalculate)miniCalculator).DifferenceTwoNumbers(number1, number2);
                                break;
                            case ConsoleKey.Multiply:
                                ((IIntCalculate)miniCalculator).MultiplicationTwoNumbers(number1, number2);
                                break;
                            case ConsoleKey.Divide:
                                ((IIntCalculate)miniCalculator).DividingTwoNumbers(number1, number2);
                                break;
                            case ConsoleKey.Spacebar:
                                break;
                            default:
                                Console.WriteLine("\nНажата неверная клавиша!");
                                break;
                        }

                        Console.WriteLine("Нажмите клавишу, соответствующую операции: + , - , * , / или пробел для повторного ввода чисел и выхода");
                        keyentered = Console.ReadKey();
                    }
                }
                catch (Exception e)
                {
                    Logger.Event("Произошла ошибка, обратитесь к разработчику " + e.Message, -1);
                    Console.ReadKey();
                }

                Console.WriteLine("Нажмите пробел для выхода или любую клавишу для повторного ввода чисел");
            } while (Console.ReadKey().Key != ConsoleKey.Spacebar);

            Console.WriteLine("Нажата клавиша пробел, выход");
            Console.ReadKey();
        }
    }
}
