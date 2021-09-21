using System;

namespace Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {

           int num= 100;

            num = num>>3;  // ele quebra  pela metade
            num = num << 1;  // ele dobra
            Console.WriteLine(num);
        }
    }
}