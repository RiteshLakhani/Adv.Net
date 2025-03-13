using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Solution
{
    internal class Stack1
    {
        Stack myStack = new Stack();

        public Stack1()
        {
            myStack.Push("1");
            myStack.Push("2");
            myStack.Push("3");
            myStack.Push("4");
            myStack.Push("5");
            printStack();
            myStack.Pop();
            printStack();
            Console.WriteLine("Peek: " + myStack.Peek());
            Console.WriteLine("Contains: " + myStack.Contains("4"));
            myStack.Clear();
            printStack();
        }

        public void printStack()
        {
            Console.WriteLine("-----------------------");
            foreach (var item in myStack)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-----------------------");
        }
    }
}
