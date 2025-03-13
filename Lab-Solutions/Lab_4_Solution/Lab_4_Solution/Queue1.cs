using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Solution
{
    internal class Queue1
    {
        Queue myQueue = new Queue();

        public Queue1()
        {
            myQueue.Enqueue("1");
            myQueue.Enqueue("2");
            myQueue.Enqueue("3");
            myQueue.Enqueue("4");
            myQueue.Enqueue("5");
            printqueue();

            myQueue.Dequeue();
            printqueue();

            Console.WriteLine("Peek :::: " + myQueue.Peek());
            Console.WriteLine("Contsins :::: " + myQueue.Contains("4"));

            myQueue.Clear();
            printqueue();
        }

        public void printqueue()
        {
            Console.WriteLine("-----------------------");
            foreach(var item in myQueue)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------");
        }
    }
}
