using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod10.MiniCalculator.Interfaces
{
    public interface IIntCalculate
    {
        int SumTwoNumbers(int number1, int number2);
        int DifferenceTwoNumbers(int number1, int number2);
        int MultiplicationTwoNumbers(int number1, int number2);
        int DividingTwoNumbers(int number1, int number2);

    }
}
