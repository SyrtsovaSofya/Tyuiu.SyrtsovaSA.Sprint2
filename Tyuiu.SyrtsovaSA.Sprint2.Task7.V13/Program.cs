using Tyuiu.SyrtsovaSA.Sprint2.Task7.V13.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task7.V13; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #13                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу на C#, которая запрашивает исходные      *"); 
        Console.WriteLine("* данные (вещественные значения) и вычисляет, находится ли точка с     *"); 
        Console.WriteLine("* координатами X,Y в заштрихованной области.                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("Введите переменную X:"); 
        double x = double.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите переменную Y:");
        double y = double.Parse(Console.ReadLine()!); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        if (ds.CheckDotInShadedArea(x, y))
            Console.WriteLine("Точка находится в заштрихованной области");
        else
            Console.WriteLine("Точка не находится в заштрихованной области");
    } 
} 
