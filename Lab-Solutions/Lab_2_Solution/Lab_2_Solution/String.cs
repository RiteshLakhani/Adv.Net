using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Solution
{
    internal class String_Methods
    {
        String s = "Ritesh is a Cricket";

        public String_Methods()
        {
            Console.WriteLine("s.Length :: " + s.Length);
            Console.WriteLine("s.Contains(\"Hiten\") :: " + s.Contains("Hiten"));
            Console.WriteLine("s.IndexOf(\"World\") :: " + s.IndexOf("World"));
            Console.WriteLine("s.Substring(7, 5) :: " + s.Substring(7, 5));
            Console.WriteLine("s.ToLower() :: " + s.ToLower());
            Console.WriteLine("s.ToUpper() :: " + s.ToUpper());
        }
    }
}
