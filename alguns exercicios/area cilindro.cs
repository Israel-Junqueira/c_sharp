using System;

namespace area_de_um_cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double areabase, arealateral, areatotal, latas, H, R, Valor;
            int QTDE;
            double pi;

            pi = 3.14;
            latas = 12;
            H = 1.80;
            R = 2;

            areabase = pi * (R * R);
            arealateral = 2 * pi * R * H;
            areatotal = 2 * areabase + arealateral;

            /*areatotal= 2 * (pi * (R * R)) + 2*(pi * R * H);*/

            QTDE = Convert.ToInt32(areatotal / latas);

            Valor = (QTDE * 40) * 2;

            Console.WriteLine("A area é {0:N}m  A quantidade de latas é de {1:N}   e o valor gasto será de {2} ", areatotal, QTDE, Valor);
        }
    }
}
