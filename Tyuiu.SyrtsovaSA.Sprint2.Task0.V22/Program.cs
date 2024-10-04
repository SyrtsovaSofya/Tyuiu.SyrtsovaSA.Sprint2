using Tyuiu.SyrtsovaSA.Sprint2.Task0.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task0.V22; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Операции сравнения                                             *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #22                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу из операций сравнений и арифметических   *"); 
        Console.WriteLine("* выражений, которая вернет логическую последовательность: False, True,*"); 
        Console.WriteLine("* True, True, True, False при x = 3105, y = 77.                        *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: x = 3105, y = 77                                    *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        int x = 3105;
        int y = 77;
        foreach (bool op in ds.GetCompareOperations(x, y))
            Console.WriteLine(op);    
    } 
} 
