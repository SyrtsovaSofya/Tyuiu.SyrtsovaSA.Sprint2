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
                res = "������";
                break;
            case 2:
                res = "�������";
                break;
            case 3:
                res = "����";
                break;
            case 4:
                res = "������";
                break;
            case 5:
                res = "���";
                break;
            case 6:
                res = "����";
                break;
            case 7:
                res = "����";
                break;
            case 8:
                res = "������";
                break;
            case 9:
                res = "��������";
                break;
            case 10:
                res = "�������";
                break;
            case 11:
                res = "������";
                break;
            case 12:
                res = "�������";
                break;
            default:
                throw new ArgumentException($"����� ������ ���� �� 1 �� 12. �������� {date.Month}.");
        }
        return res;
    }
} 
