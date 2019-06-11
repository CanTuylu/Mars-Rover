using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMicrosoftVers
{
    class Program
    {
        static void Main(string[] args)
        {
            Navigation n = new Navigation();

            string yeniYon = "";
            Console.WriteLine("Harita boyutunu giriniz:");
            n.xmap = Convert.ToInt32(Console.ReadLine());
            n.ymap = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aracın ilk konumunu giriniz ");
            Console.WriteLine("X:?");
            n.xstart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y:?");
            n.ystart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yön:?(K, G, D, B)");
            n.yon = Console.ReadLine();

            Console.WriteLine("Aracın rotasını giriniz:");
            n.yol = Console.ReadLine();

            for (int i = 0; i < n.yol.Length; i++)
            {
                if (n.yol[i] == 'L' || n.yol[i] == 'l')
                {
                    n.TurnLeft();
                    n.xfinal = n.xstart;
                    n.yfinal = n.ystart;

                }
                else if (n.yol[i] == 'R' || n.yol[i] == 'r')
                {
                    n.TurnRight();
                    n.xfinal = n.xstart;
                    n.yfinal = n.ystart;
                }
                else if (n.yol[i]=='M' || n.yol[i] == 'm')
                {
                    n.MoveX(n.xstart);
                    n.MoveY(n.ystart);
                }
                n.xstart = n.xfinal;
                n.ystart = n.yfinal;
            }
            if (n.xfinal > n.xmap || n.xfinal < 0 || n.yfinal > n.ymap || n.yfinal < 0)
            {
                Console.WriteLine("Araç haritadan dışarı çıktı!");
            }
            else
            Console.WriteLine("Araç " + n.xfinal + " " + n.yfinal + " koordinatlarında ve " + n.yon + " yönündedir.");
        }
    }
}
