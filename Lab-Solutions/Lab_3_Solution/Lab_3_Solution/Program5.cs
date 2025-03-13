using System;

namespace Lab_3_Solution
{
    internal class Program5
    {
        public class Hospital
        {
            public virtual void HospitalDetails()
            {
                Console.WriteLine("General Hospital Details");
            }
        }

        public class Apollo : Hospital
        {
            public override void HospitalDetails()
            {
                Console.WriteLine("Apollo Hospital Details");
            }
        }

        public class Wockhardt : Hospital
        {
            public override void HospitalDetails()
            {
                Console.WriteLine("Wockhardt Hospital Details");
            }
        }

        public class Gokul_Superspeciality : Hospital
        {
            public override void HospitalDetails()
            {
                Console.WriteLine("Gokul Superspeciality Hospital Details");
            }
        }
    }
}
