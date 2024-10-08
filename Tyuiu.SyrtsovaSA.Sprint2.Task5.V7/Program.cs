using Tyuiu.SyrtsovaSA.Sprint2.Task5.V7.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task5.V7; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Оператор switch                                                *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #7                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: С начала 1990 года по некоторый день прошло n месяцев и 2   *"); 
        Console.WriteLine("* дня. Определить название месяца (январь, февраль и т. п.) этого дня. *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Введите номер месяца:");
        int month = int.Parse(Console.ReadLine()!);
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Месяц = {ds.FindMonthName(1990, month)}");
    } 
} 
