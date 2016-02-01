using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class Algorithms
        {
            public int fib(int N)
            {
                if (N == 1)
                {
                    return 1;
                }
                else if (N == 2)
                {
                    return 2;
                }
                int fibA = 1;
                int fibB = 2;
                for (int i = 3; i < N; i++)
                {
                    fibB = fibA + fibB;
                    fibA = fibB - fibA;
                }
                return fibB;
            }
            /*
             * function addFibNumbers
             * 
             * parameters:
             * 
             * ref List<int>  currentTable - list of fibonacci numbers recorded
             *
             * Will grow fibonacci table by 10x's current size.
             */
            public void addFibNumbers(ref List<int> currentTable)
            {
                int currentFib = currentTable.Count;
                System.Console.Out.WriteLine("updating table, increasing by {0} values", 10 * currentFib - currentFib);
                for (int i = currentFib + 1; i < currentFib * 10; i++)
                {
                    currentTable.Add(fib(i));
                }
            }

        }

        public class myFibHashTable // could create custom, but for now, let's use .net
        {
            List<int> FibSeq; 
        }

        static void Main(string[] args)
        {
            int N = 25;
            List<int> fibHashTable = new List<int>();
            Algorithms myAlgos = new Algorithms();
            System.Console.Out.WriteLine("Initializing the '{0}' numbers of the fibonacci sequence", N);
            for (int i = 1; i <= N; i++)
            {
                fibHashTable.Add(myAlgos.fib(i));
            }
            for (int i = 1; i < 35; i++)
            {
                if(fibHashTable.Count<i)
                {
                    myAlgos.addFibNumbers(ref fibHashTable);
                }
                System.Console.Out.WriteLine("the {0} fib number is: {1}", 
                                                i,
                                                fibHashTable[i-1]);
            }
            System.Console.ReadLine();
        }
    }
}
