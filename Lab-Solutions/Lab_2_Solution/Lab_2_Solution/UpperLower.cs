using System;

namespace Lab_2_Solution
{
    internal class UpperLower
    {
        public string ConvertCase(string input)
        {
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                // Convert lowercase to uppercase
                if (c >= 'a' && c <= 'z')
                {
                    chars[i] = (char)(c - 'a' + 'A');
                }
                // Convert uppercase to lowercase
                else if (c >= 'A' && c <= 'Z')
                {
                    chars[i] = (char)(c - 'A' + 'a');
                }
                // If it's not a letter, leave it unchanged
            }

            return new string(chars);
        }
    }
}
