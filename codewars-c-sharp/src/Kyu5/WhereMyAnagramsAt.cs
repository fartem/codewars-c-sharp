using System;
using System.Collections.Generic;
using System.Linq;

namespace codewars_c_sharp.src.Kyu5
{
    // https://www.codewars.com/kata/523a86aa4230ebb5420001e1
    public class WhereMyAnagramsAt
    {
        private string Word;
        private List<string> Words;

        public WhereMyAnagramsAt(string word, List<string> words)
        {
            Word = word;
            Words = words;
        }

        public List<string> Solution()
        {
            return Words
                .Select(w => w)
                .Where(w => IsAnograms(Word, w))
                .ToList();
        }

        private bool IsAnograms(string firstWord, string secondWord)
        {
            string first = String.Concat(firstWord.OrderBy(c => c));
            string second = String.Concat(secondWord.OrderBy(c => c));
            return first == second;
        }
    }
}
