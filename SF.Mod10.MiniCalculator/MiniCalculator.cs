using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF.Mod10.MiniCalculator.Interfaces;

namespace SF.Mod10.MiniCalculator
{
    class MiniCalculator : IIntCalculate
    {
        public int IIntCalculate.DifferenceTwoNumbers(int number1, int number2)
        {
            return number1 - number2;
        }

        public int IIntCalculate.DividingTwoNumbers(int number1, int number2)
        {
            return number1 / number2;
        }

        public int IIntCalculate.MultiplicationTwoNumbers(int number1, int number2)
        {
            return number1 * number2;
        }

        public int IIntCalculate.SumTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
