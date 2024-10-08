using Tyuiu.SyrtsovaSA.Sprint2.Task4.V5.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task4.V5; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Тернарный оператор                                             *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #5                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет требуемое значение    *"); 
        Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит       *"); 
        Console.WriteLine("* значение переменных x,y с клавиатуры.                                *"); 
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
        Console.WriteLine($"Ответ = {ds.Calculate(x,y)}"); 
    } 
} 
