using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMicrosoftVers
{
    public class Navigation
    {

        public string yon { get; set; }
        public string yol { get; set; }
        public string yeniYon { get; set; }
        public int xmap { get; set; }
        public int ymap { get; set; }
        public int xstart { get; set; }
        public int ystart { get; set; }
        public int xfinal { get; set; }
        public int yfinal { get; set; }

        public string TurnLeft()
        {
            if (yon == "K")
            {
                yeniYon = "B";
            }
            else if (yon == "G")
            {
                yeniYon = "D";
            }
            else if (yon == "D")
            {
                yeniYon = "K";
            }
            else if (yon == "B")
            {
                yeniYon = "G";
            }

            yon = yeniYon;
            return yon;
        }
        public string TurnRight()
        {
            if (yon == "K")
            {
                yeniYon = "D";
            }
            else if (yon == "G")
            {
                yeniYon = "B";
            }
            else if (yon == "D")
            {
                yeniYon = "G";
            }
            else if (yon == "B")
            {
                yeniYon = "K";
            }
            yon = yeniYon;
            return yon;
        }

        public int  MoveX(int xstart)
        {
            if (yon == "B" || yeniYon == "B" || yon == "b" || yeniYon == "b")
            {
                xstart--;
            }
            else if (yon == "D" || yeniYon == "D"|| yon == "d" || yeniYon == "d")
            {
                xstart++;
            }
            xfinal = xstart;
            if (xfinal>xmap || xfinal<0)
            {
                Console.WriteLine("Araç harita dışına çıktı!");
            }
            return xstart;
        }
        public int MoveY(int ystart)
        {
            if (yon == "K" || yeniYon == "K"|| yon == "k" || yeniYon == "k")
            {
                ystart++;
            }
            else if (yon == "G" || yeniYon == "G"|| yon == "g" || yeniYon == "g")
            {
                ystart--;
            }
            yfinal = ystart;
            if (yfinal>ymap || yfinal<0)
            {
                
            }
            return ystart;
        }

        
    }
}
