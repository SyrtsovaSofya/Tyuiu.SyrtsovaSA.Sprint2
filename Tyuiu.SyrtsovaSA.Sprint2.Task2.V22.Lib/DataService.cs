using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task2.V22.Lib;

public class DataService : ISprint2Task2V22
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        bool res = false;
        if ((y == 3 || y == 4) && ((x > 2 && x < 6) || (x > 8 && x < 13)))
           res = true;
        else if (y > 4 && y < 8 && x > 2 && x < 13)
            res = true;
        else if(x == 13 && y > 5 && y < 9)
            res = true;
        else if(x == 12 && y > 7 && y < 12)
            res = true;
        else if(y > 7 && y < 12 && x > 3 && x < 7)
            res = true;
        else if(y == 11 && x == 3)
            res = true;
        else if(x == 5 && y > 11 && y < 14)
            res = true;
        else if(y == 14 && x > 3 && y < 11)
            res = true;
        return res;
    }
}
