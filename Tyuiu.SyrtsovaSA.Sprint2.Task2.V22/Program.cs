using Tyuiu.SyrtsovaSA.Sprint2.Task2.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task2.V22; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                   *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #22                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу на, которая запрашивает целые значения с *"); 
        Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y в       *"); 
        Console.WriteLine("* заштрихованной области.                                              *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:"); 
        int x = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите переменную Y:"); 
        int y = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        bool res = ds.CheckDotInShadedArea(x, y);
        if (res)
            Console.WriteLine("Точка находится в заштрихованной области");
        else
            Console.WriteLine("Точка не находится в заштрихованной области");
    } 
} 
