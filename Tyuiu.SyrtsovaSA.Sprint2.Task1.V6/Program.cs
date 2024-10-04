using Tyuiu.SyrtsovaSA.Sprint2.Task1.V6.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task1.V6; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Логические операции                                            *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #6                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Написать программу из операций сравнений и логических       *");
        Console.WriteLine("* операций, которая вернет логическую последовательность: False, False,*");
        Console.WriteLine("* True, False, True, False при a = 915, b = 169, c = 174, d = 133.     *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: a = 915, b = 169, c = 174, d = 133                  *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        int a = 915;
        int b = 169;
        int c = 174;
        int d = 133;
        foreach (bool op in ds.GetLogicOperations(a, b, c, d))
            Console.WriteLine(op);
    } 
} 
