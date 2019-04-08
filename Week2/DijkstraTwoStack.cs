using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class DijkstraTwoStack
    {
        static void Calculate(string[] args)
        {
            Stack<string> ops = new Stack<string>();
            Stack<double> vals = new Stack<double>();

            //this needs to change to the equivalent of the StdIn.isEmpty()
            foreach (var s in args)
            {
                if (s.Equals("("))
                {

                }
                else if (s.Equals("+"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("-"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("*"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("/"))
                {
                    ops.Push(s);
                }
                else if (s.Equals("sqrt"))
                {
                    ops.Push(s);
                }
                else if (s.Equals(")"))
                {
                    //pop, evaluate, and push result if token is ")"
                    string op = ops.Pop();
                    double v = vals.Pop();
                    if (op.Equals("+"))
                    {
                        v = vals.Pop() + v;
                    }
                    else if (op.Equals("-"))
                    {
                        v = vals.Pop() - v;
                    }
                    else if (op.Equals("*"))
                    {
                        v = vals.Pop() * v;
                    }
                    else if (op.Equals("/"))
                    {
                        v = vals.Pop() / v;
                    }
                    else if (op.Equals("sqrt"))
                        v = Math.Sqrt(v);
                    vals.Push(v);
                }

                //Token not operator or paren: push double value
                else
                {
                    vals.Push(Double.Parse(s));
                }

                Console.WriteLine(vals.Pop());
            }
        }
    }
}

