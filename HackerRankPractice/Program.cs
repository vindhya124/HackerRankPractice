using System;
using System.IO;
using System.Linq;

namespace HackerRankPractice
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int SockMerchant(int[] ar)
        {
            var inputList = ar.ToList().GroupBy(p => p);
            return inputList.Sum(i => i.Count() / 2);
        }

        static void Main(string[] args)
        {

            var ar = new int[] { 10, 20, 10, 40, 50 };
            var result = SockMerchant(ar);

            Console.WriteLine(result);

        }
    }

}
