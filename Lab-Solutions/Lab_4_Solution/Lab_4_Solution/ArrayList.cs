using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Lab_4_Solution
{
    internal class ArrayList1
    {
        ArrayList list = new ArrayList();

        public ArrayList1()
        {
            list.Add("Ritesh");
            list.Add("Hiten");
            list.Add("Het");
            list.Add("Dhyey");
            list.Add("Krishna");
            list.Add("Fenil");
            printlist();
            list.Remove("Krishna");
            printlist();
            list.RemoveRange(1, 3);
            printlist();
            list.Clear();
            printlist();
        }

        public void printlist()
        {
            Console.WriteLine("---------------");
            foreach (object item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------");
        }
    }
}
