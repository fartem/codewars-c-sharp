using System;

namespace codewars_c_sharp.src.Kyu8
{
    // https://www.codewars.com/kata/50654ddff44f800200000004
    public class Multiply
    {
        private int FirstNumber;
        private int SecondNumber;

        public Multiply(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public int Solution()
        {
            return FirstNumber * SecondNumber;
        }
    }
}
