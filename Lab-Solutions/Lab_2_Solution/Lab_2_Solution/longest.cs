using System;

namespace Lab_2_Solution
{
    internal class longest
    {
        public string FindLongestWord(string input)
        {
            string longestWord = "";
            string currentWord = "";

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) || c == '\n')
                {
                   
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord;
                    }

                    currentWord = "";
                }
                else
                {
                    currentWord += c;
                }
            }

            if (currentWord.Length > longestWord.Length)
            {
                longestWord = currentWord;
            }

            return longestWord;
        }
    }
}
