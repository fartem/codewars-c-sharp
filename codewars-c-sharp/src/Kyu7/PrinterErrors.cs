using System;
using System.Linq;

namespace codewars_c_sharp.src.Kyu7
{
    // https://www.codewars.com/kata/56541980fa08ab47a0000040
    public class PrinterErrors
    {
        private string Input;

        public PrinterErrors(string input)
        {
            Input = input;
        }

        public string Solution()
        {
            int errors = Input
                .Select(letter => letter)
                .Where(letter => letter > 109)
                .ToArray()
                .Length;
            return errors.ToString() + "/" + Input.Length;
        }
    }
}
