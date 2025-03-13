using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Solution
{
    internal class Program3
    {
        //Base class
        public class RBI
        {
            public virtual void CalculateIntrest()
            {
                Console.WriteLine("Interest rate calculated by RBI.");
            }
        }

        //dervied class
        public class HDFC : RBI
        {
            public override void CalculateIntrest()
            {
                Console.WriteLine("Interest rate calculated by HDFC.");
            }
        }

        public class ICICI : RBI
        {
            public override void CalculateIntrest()
            {
                Console.WriteLine("Interest rate calculated by ICICI.");
            }
        }

        public class SBI : RBI
        {
            public override void CalculateIntrest()
            {
                Console.WriteLine("Interest rate calculated by SBI.");
            }
        }
    }
}
