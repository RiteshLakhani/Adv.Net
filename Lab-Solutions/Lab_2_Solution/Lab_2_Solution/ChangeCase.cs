using System;

namespace Lab_2_Solution
{
    internal class ChangeCase
    {
        public char ConvertCase(char c)
        {
            if (char.IsLower(c))
            {
                return char.ToUpper(c);
            }
            else if (char.IsUpper(c))
            {
                return char.ToLower(c);
            }
            else
            {
                return c;
            }
        }
    }
}
