using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlekseevaVA.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 5) ||
                (x >= 5) && (x <= 8) && (y >= 5) && (y <= 7) ||
                (x >= 9) && (y >= 3) && (y <= 4) || 
                (x >= 11) &&(x <=12) && (y >= 3) && (y <= 4) ||
                (x >= 9) && (x <= 12) && (y >= 5) && (y <= 6) ||
                (x >= 13) && (y >= 6) && (y <= 8) ||
                (x >= 6) && (x <= 8) && ( y >= 8) && (y <=10) ||
                (x >= 3) && (x <= 8) && (y >= 11) ||
                (x >= 6) && (x <= 10) && (y >= 12))

            {
                res = true;
            }
           
            else
            {
                res = false;
            }

            return res;

        }
    }
}
