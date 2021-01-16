using System;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/5810085c533d69f4980001cf
    public class SimpleCalculator
    {
        private double FirstNumber;
        private double SecondNumber;

        private char Operation;

        public SimpleCalculator(
            double firstNumber,
            double secondNumber,
            char operation
        )
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operation = operation;
        }

        public double Solution()
        {
            switch (Operation)
            {
                case '+':
                    return FirstNumber + SecondNumber;
                case '-':
                    return FirstNumber - SecondNumber;
                case '*':
                    return FirstNumber * SecondNumber;
                case '/':
                    return FirstNumber / SecondNumber;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
