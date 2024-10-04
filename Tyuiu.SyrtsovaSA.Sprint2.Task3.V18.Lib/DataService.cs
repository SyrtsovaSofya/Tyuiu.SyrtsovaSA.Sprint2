using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SyrtsovaSA.Sprint2.Task3.V18.Lib;

public class DataService : ISprint2Task3V18
{
    public double Calculate(double x)
    {
        double y;
        if (x > 1)
        {
            y = x * x * Math.Pow((x + 1) / (x - 1), x);
        }
        else
        {
            if (x == 0)
            {
                y = (x * x - Math.Pow(Math.Cos(x), 2) + 10) / (x * x - Math.Pow(Math.Sin(x), 2) + 12);
            }
            else
            {
                if (x > -22 && x < 2)
                {
                    y = Math.Pow(1 + 1 / (x * x), x);
                }
                else
                {
                    y = x + 10 * x - 1 / x;
                }
            }
        }
        return Math.Round(y, 3);
    }
}
