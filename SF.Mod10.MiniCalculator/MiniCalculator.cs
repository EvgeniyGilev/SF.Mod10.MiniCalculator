using System;
using SF.Mod10.MiniCalculator.Interfaces;

namespace SF.Mod10.MiniCalculator
{
    /// <summary>
    /// The mini calculator.
    /// </summary>
    public class MiniCalculator : IIntCalculate
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        private ILogger Logger { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiniCalculator"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public MiniCalculator(ILogger logger)
        {
            this.Logger = logger;
        }

        /// <summary>
        /// Difference the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int IIntCalculate.DifferenceTwoNumbers(int number1, int number2)
        {
            try
            {
                this.Logger.Event("Разница двух чисел: " + (number1 - number2), 0);

                return number1 - number2;
            }
            catch (Exception ex)
            {
                this.Logger.Event("Ошибка при вычитании: " + ex.Message, -1);
                return 0;
            }
        }

        /// <summary>
        /// Dividing the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int IIntCalculate.DividingTwoNumbers(int number1, int number2)
        {
            try
            {
                this.Logger.Event("Частное двух чисел: " + (number1 / number2), 0);
                return number1 / number2;
            }
            catch (Exception ex)
            {
                this.Logger.Event("Ошибка при делении: " + ex.Message, -1);
                return 0;
            }


        }

        /// <summary>
        /// Multiplications the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int IIntCalculate.MultiplicationTwoNumbers(int number1, int number2)
        {
            try
            {
                this.Logger.Event("Произведение двух чисел: " + (number1 * number2), 0);
                return number1 * number2;
            }
            catch (Exception ex)
            {
                this.Logger.Event("Ошибка при умножении: " + ex.Message, -1);
                return 0;
            }

        }

        /// <summary>
        /// Sums the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int IIntCalculate.SumTwoNumbers(int number1, int number2)
        {
            try
            {
                this.Logger.Event("Сумма двух чисел: " + (number1 + number2), 0);
                return number1 + number2;
            }
            catch (Exception ex)
            {
                this.Logger.Event("Ошибка при сложении: " + ex.Message, -1);
                return 0;
            }
        }
    }
}
