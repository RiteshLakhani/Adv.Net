using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Solution
{
    internal class List1
    {
        List<String> list = new List<string>();

        public List1()
        {
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            printList();
            list.Remove("1");
            printList();
            list.RemoveRange(1,2);
            printList();
            list.Clear();
            printList();
        }

        public void printList()
        {
            Console.WriteLine("--------------");
            foreach(var item in  list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-----------------");
        }
    }
}
