using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

/*char[] a = { 'm', 'f', 'f', 'm', 'm', 'm', 'f', 'm' };

ArrayList a1 = new ArrayList();
a1.Add(1);
a1.Add(2);

a1.Insert(2, 20);
foreach(object obj in a1)
{
    Console.WriteLine(obj);
}

Console.WriteLine(a1.Count);
Console.WriteLine(a1.Contains(20));
Console.WriteLine(a1.Capacity);

a1.Remove(30);
a1.RemoveAt(2);


Stack<int> s1 = new Stack<int>();
s1.Push(1);
s1.Push(2);
s1.Push(3);
s1.Push(4);

foreach(object obj in s1)
{
    Console.WriteLine(obj);
}

Console.WriteLine("Popped from stack: " + s1.Pop());
Console.WriteLine("Stack after popping:");
foreach (int item in s1)
{
    Console.WriteLine(item);
}

Queue<int> q1 = new Queue<int>();
q1.Enqueue(101);
q1.Enqueue(102);
q1.Enqueue(103);
foreach (object obj in q1)
{
    Console.WriteLine(obj);
}

Console.WriteLine("Dequeued from queue: " + q1.Dequeue());
Console.WriteLine("Queue after dequeuing:");
foreach (int item in q1)
{
    Console.WriteLine(item);
}*/

/*
Hashtable ht = new Hashtable();
ht.Add("Name","Ritesh");
ht.Add("id",101);
ht.Add("Batch", "A2");

foreach (object key in ht.Keys)
{
    Console.WriteLine(key + ": " + ht[key]);
}*/

/*Hashtable ht = new Hashtable();
ht.Add("Name", "Ritesh");
ht.Add("id", 101);
ht.Add("Batch", "A2");
ICollection keys = ht.Keys;

foreach (String k in keys)
{
    Console.WriteLine(ht[k]);
}
Console.ReadLine();
*/


BitArray ba = new BitArray(4);
ba[0] = true;
ba[1] = false;
ba[2] = true;
ba[3] = false;
ba[2] = false;
foreach(Object obj in ba)
{
    Console.WriteLine(obj);
}
Console.ReadLine();