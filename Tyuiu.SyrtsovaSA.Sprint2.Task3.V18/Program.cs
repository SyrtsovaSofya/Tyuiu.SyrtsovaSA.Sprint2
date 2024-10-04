using Tyuiu.SyrtsovaSA.Sprint2.Task3.V18.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint2.Task3.V18; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема: Вложенные операторы if-else                                    *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #18                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:  Написать программу, которая вычисляет требуемое значение   *"); 
        Console.WriteLine("* функции Y с использованием вложенных оператор if-else, где           *"); 
        Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.          *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("Введите переменную X:"); 
        int x = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine($"Y = {ds.Calculate(x)}"); 
    } 
} 
