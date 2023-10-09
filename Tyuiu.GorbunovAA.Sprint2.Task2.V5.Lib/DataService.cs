using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorbunovAA.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3) && (x <= 4) && (((y >= 3) && (y <= 5)) || (y == 9) || (y == 11) || (y == 12))) return true;
            else if ((x == 5) && ((y >= 3) && (y <= 12))) return true;
            else if ((x == 6) && ((y >= 5) && (y <= 13))) return true;
            else if ((x == 7) && ((y >= 5) && (y <= 8) || (y == 13))) return true;
            else if (((x >= 8) && (x <= 10)) && ((y >= 6) && (y <= 8) || (y == 13))) return true;
            else if ((x == 11) && ((y >= 3) && (y <= 8))) return true;
            else if ((x == 12) && ((y >= 7) && (y <= 10))) return true;
            else return false;

        }
    }
}
