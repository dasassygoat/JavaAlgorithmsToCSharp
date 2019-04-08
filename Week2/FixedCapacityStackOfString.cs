using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class CapacityProgram
    {
        public static void Main(string[] args)
        {
            FixedCapacityOfStackOfStrings s;
            s = new FixedCapacityOfStackOfStrings(100);
            foreach(var item in args)
            {
                if (!item.Equals("-"))
                {
                    s.Push(item);
                }
                else if (!s.IsEmpty())
                {
                    Console.WriteLine($"{s.Pop()} ");
                }

            }

            _ = new object[5];

            Console.WriteLine($"({s.Size()} left on stack)");
        }
    }

    public class FixedCapacityOfStackOfStrings
    {
        private string[] a; //stack entries
        private int N; //size

        public FixedCapacityOfStackOfStrings(int cap)
        {
            a = new string[cap];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public int Size()
        {
            return N;
        }

        public void Push(string item)
        {
            a[N++] = item;
        }

        public string Pop()
        {
            return a[--N];
        }
    }
}
