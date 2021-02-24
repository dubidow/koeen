using System;
using System.Collections.Generic;

namespace køen
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> people = new Queue<string>();

            people.Enqueue("person1");
            people.Enqueue("person2");
            people.Enqueue("person3");
            people.Enqueue("person4");

            

            foreach (string p in people)
            {
                Console.WriteLine(people);
            }

            Console.WriteLine("\nDequeuing '{0}'", people.Dequeue());
            Console.WriteLine("Who's next to dequeue: {0}",
                people.Peek());
            Console.WriteLine("Dequeuing '{0}'", people.Dequeue());



        }
    }
}
