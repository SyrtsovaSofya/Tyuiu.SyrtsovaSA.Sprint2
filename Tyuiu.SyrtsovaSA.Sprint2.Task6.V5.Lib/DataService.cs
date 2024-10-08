using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task6.V5.Lib;

public class DataService : ISprint2Task6V5
{
    public string FindCardValue(int value) => value switch
    {
        6 => "��������",
        7 => "�������",
        8 => "���������",
        9 => "�������",
        10 => "�������",
        11 => "�����",
        12 => "����",
        13 => "������",
        14 => "���",
        _ => throw new ArgumentException("������. ����� ������ ���� �� 6 �� 14.")
    };
} 
