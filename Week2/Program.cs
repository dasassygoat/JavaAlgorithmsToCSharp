using System;
using System.Collections;
using System.Collections.Generic;

namespace Week2
{
    class Program
    {
        void StackMain(string[] args)
        {
            Stack<String> stack = new Stack<string>();
            stack.Push("this");
            stack.Push("that");
            stack.Push("Never");

            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }

            var stackNext = stack.Pop();

            Console.WriteLine($"Poped value: {stackNext}");

            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Queue Section");
            Queue<string> que = new Queue<string>();
            que.Enqueue("This");
            que.Enqueue("That");
            que.Enqueue("Never");

            foreach (var q in que)
            {
                Console.WriteLine(q);
            }

            var queNext = que.Dequeue();

            Console.WriteLine($"Dequeued value: {queNext}");

            foreach (var q in que)
            {
                Console.WriteLine(q);
            }

        }



    }
}
