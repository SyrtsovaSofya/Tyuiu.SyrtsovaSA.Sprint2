using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task5.V7.Lib;

public class DataService : ISprint2Task5V7
{
    public string FindMonthName(int startYear, int n)
    {
        DateOnly date = new DateOnly(startYear, 1, 1);
        date = date.AddMonths(n).AddDays(2);
        string res;
        switch (date.Month)
        {
            case 1:
                res = "€нварь";
                break;
            case 2:
                res = "февраль";
                break;
            case 3:
                res = "март";
                break;
            case 4:
                res = "апрель";
                break;
            case 5:
                res = "май";
                break;
            case 6:
                res = "июнь";
                break;
            case 7:
                res = "июль";
                break;
            case 8:
                res = "август";
                break;
            case 9:
                res = "сент€брь";
                break;
            case 10:
                res = "окт€брь";
                break;
            case 11:
                res = "но€брь";
                break;
            case 12:
                res = "декабрь";
                break;
            default:
                throw new ArgumentException($"ћес€ц должен быть от 1 до 12. «начение {date.Month}.");
        }
        return res;
    }
} 
