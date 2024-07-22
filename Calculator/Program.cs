using System.ComponentModel;

namespace Calculator
{
    internal class Program
    {
        static class MyCalculator
        {
            public static double Add(double left, double right)
            {
                return left + right;
            }
            public static double SubtractAdd(double left, double right)
            {
                return left - right;
            }
            public static double Multiply(double left, double right)
            {
                return left * right;
            }
            public static double Divide(double left, double right)
            {
                if (right == 0)
                {
                    Console.WriteLine("에러 발생");
                    return right;
                }
                return left / right;
            }
            public static double Squared(double left, double right)
            {
                return Math.Pow(left, right);
            }
        }

        static void Main(string[] args)
        {
            MyCalculator myCalculator = new MyCalculator();
        }
    }
}
