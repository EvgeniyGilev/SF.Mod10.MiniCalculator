namespace SF.Mod10.MiniCalculator.Interfaces
{
    /// <summary>
    /// The int calculate.
    /// </summary>
    public interface IIntCalculate
    {
        /// <summary>
        /// Sum the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int SumTwoNumbers(int number1, int number2);

        /// <summary>
        /// Difference the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int DifferenceTwoNumbers(int number1, int number2);

        /// <summary>
        /// Multiplication the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int MultiplicationTwoNumbers(int number1, int number2);

        /// <summary>
        /// Dividing the two numbers.
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>An int.</returns>
        int DividingTwoNumbers(int number1, int number2);
    }
}
