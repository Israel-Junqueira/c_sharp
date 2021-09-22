using System;
using static System.Math;
namespace Typecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = 10.5m ;
            int n2 = Convert.ToInt32(n1); //typecast converter um tipo em outro
            int n3 = (int)n1;//typecast
            
            
            
            Console.WriteLine();
        }
    }
}