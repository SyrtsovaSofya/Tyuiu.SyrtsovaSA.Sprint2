using Tyuiu.SyrtsovaSA.Sprint2.Task6.V5.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task6.V5; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Получение результата из switch                                 *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #5                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Игральным картам условно присвоены следующие порядковые     *"); 
        Console.WriteLine("* номера в зависимости от их достоинства : «валету» — 11, «даме» — 12, *"); 
        Console.WriteLine("* «королю» — 13, «тузу» — 14. Порядковые номера остальных карт         *"); 
        Console.WriteLine("* соответствуют их названиям («шестерка» и т.п.). По заданному номеру  *"); 
        Console.WriteLine("* карты k (6 <=k <= 14) определить достоинство соответствующей карты.  *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("Введите номер карты:"); 
        int n = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine($"Карта = {ds.FindCardValue(n)}"); 
    } 
} 
