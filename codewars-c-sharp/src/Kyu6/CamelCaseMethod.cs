using System;
using System.Linq;

namespace codewars_c_sharp.src.Kyu6
{
    // https://www.codewars.com/kata/587731fda577b3d1b0001196
    public static class CamelCaseMethod
    {
        public static string CamelCase(this string input)
        {
            if (input.Length == 0)
            {
                return "";
            }
            return string.Join(
                "",
                input.Split(' ').Select(
                    word => word != ""
                        ? new string(word.Remove(0, 1)
                            .Insert(0, word[0].ToString().ToUpper()).ToArray())
                        : ""
                )
            );
        }
    }
}
