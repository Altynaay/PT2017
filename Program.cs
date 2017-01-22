using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrimeNumber1
{
    class Program
    {
        static bool isPrime(int a)
        {
            if (a == 1)
                return false;
            for (int i = 2; i < a; i ++)
                if (a % i == 0)
                    return false;
            return true;
        }
         public static void Main(string[] args)
         {
             int n = args.Length;
             for (int i = 0; i <n; i++)
             {
                 string s = args[i];
                 int p = int.Parse(s);
 
                 if (isPrime(p) == true)
                 {
                     Console.WriteLine(p);
                 }
             }
         }
     }
 }