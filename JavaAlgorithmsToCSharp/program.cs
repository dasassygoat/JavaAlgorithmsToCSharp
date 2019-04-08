using System;
using System.Collections.Generic;
using System.Text;
using Week1;

namespace JavaAlgorithmsToCSharp
{
    public class program
    {
        static void Main(string[] args)
        {
            //Quick-find
            QuickFindUF grid = new QuickFindUF(10);
            grid.Union(2, 3);
            grid.Union(3, 6);
            grid.Union(6, 5);
            Console.WriteLine($"Does 2 and 5 connect? {grid.Connected(2, 5)}");
            Console.WriteLine($"Does 6 and 1 connect? {grid.Connected(1, 6)}");

            //Quick-union
            QuickUnionUF quuf = new QuickUnionUF(10);
            quuf.Union(2, 3);
            quuf.Union(3, 6);
            quuf.Union(6, 5);
            Console.WriteLine($"Does 2 and 5 connect? {quuf.Connected(2, 5)}");
            Console.WriteLine($"Does 6 and 1 connect? {quuf.Connected(1, 6)}");

            Console.WriteLine(GreatestCommonDenominator.GetGCD(9,0));
        }
    }
}
