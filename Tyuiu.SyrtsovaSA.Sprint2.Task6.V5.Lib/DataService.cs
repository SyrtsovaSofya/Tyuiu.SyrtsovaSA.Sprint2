using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task6.V5.Lib;

public class DataService : ISprint2Task6V5
{
    public string FindCardValue(int value) => value switch
    {
        6 => "шестерка",
        7 => "семерка",
        8 => "восьмерка",
        9 => "девятка",
        10 => "десятка",
        11 => "валет",
        12 => "дама",
        13 => "король",
        14 => "туз",
        _ => throw new ArgumentException("Ошибка. Число должно быть от 6 до 14.")
    };
} 
