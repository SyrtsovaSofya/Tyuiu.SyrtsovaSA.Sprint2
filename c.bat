@echo off

set prefix=Tyuiu

set fio=Сырцова С.А.
set full_fio=Сырцова Софья Алексеевна
set group=ИИПб-24-1
set name=SyrtsovaSA

set sprint=2
set task=5
set variant=7

set template=%prefix%.%name%.Sprint%sprint%
set filename_template=%template%.Task%task%.V%variant%

set console_path=%filename_template%
set classlib_path=%filename_template%.Lib
set mstest_path=%filename_template%.Test

:: Создаём проекты
:: Консольное приложение
dotnet new console --use-program-main -o %console_path%
:: Библиотека
dotnet new classlib -o %classlib_path%
:: Тестирование
dotnet new mstest -o %mstest_path%

set classlib_csproj=%classlib_path%\%classlib_path%.csproj
:: Дурацким способом подключаем dll к библиотеке классов
echo ^<Project Sdk="Microsoft.NET.Sdk"^> > %classlib_csproj%
echo. >> %classlib_csproj%
echo   ^<PropertyGroup^> >> %classlib_csproj%
echo     ^<TargetFramework^>net8.0^</TargetFramework^> >> %classlib_csproj%
echo     ^<ImplicitUsings^>enable^</ImplicitUsings^> >> %classlib_csproj%
echo     ^<Nullable^>enable^</Nullable^> >> %classlib_csproj%
echo   ^</PropertyGroup^> >> %classlib_csproj%
echo. >> %classlib_csproj%
echo   ^<ItemGroup^> >> %classlib_csproj%
echo     ^<Reference Include="tyuiu.cources.programming.interfaces"^> >> %classlib_csproj%
echo       ^<HintPath^>..\tyuiu.cources.programming.interfaces.dll^</HintPath^> >> %classlib_csproj%
echo     ^</Reference^> >> %classlib_csproj%
echo   ^</ItemGroup^> >> %classlib_csproj%
echo. >> %classlib_csproj%
echo ^</Project^> >> %classlib_csproj%

:: Создаём шаблон для консольного приложения
set console_class=%console_path%\Program.cs
echo using %classlib_path%; > %console_class%
echo. >> %console_class%
echo namespace Tyuiu.SyrtsovaSA.Sprint%sprint%.Task%task%.V%variant%; >> %console_class%
echo. >> %console_class%
echo class Program >> %console_class%
echo { >> %console_class%
echo     static void Main(string[] args) >> %console_class%
echo     { >> %console_class%
echo         Console.Title = "Спринт #%sprint% | Выполнила: %fio% | %group%"; >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* Спринт #%sprint%                                                            *"); >> %console_class%
echo         Console.WriteLine("* Тема:                                                                *"); >> %console_class%
echo         Console.WriteLine("* Задание #%task%                                                           *"); >> %console_class%
echo         Console.WriteLine("* Вариант #%variant%                                                          *"); >> %console_class%
echo         Console.WriteLine("* Выполнила: %full_fio% | %group%                                                          *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* УСЛОВИЕ:                                                             *"); >> %console_class%
echo         Console.WriteLine("*                                                                      *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo. >> %console_class%
echo         Console.WriteLine("Введите переменную X:"); >> %console_class%
echo         int x = int.Parse(Console.ReadLine()!); >> %console_class%
echo         Console.WriteLine("Введите переменную Y:"); >> %console_class%
echo         int y = int.Parse(Console.ReadLine()!); >> %console_class%
echo. >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo         Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); >> %console_class%
echo         Console.WriteLine("************************************************************************"); >> %console_class%
echo. >> %console_class%
echo         Console.WriteLine($"Ответ = "); >> %console_class%
echo     } >> %console_class%
echo } >> %console_class%

:: Создаём шаблон для библиотеки классов
del %classlib_path%\Class1.cs
set classlib_class=%classlib_path%\DataService.cs
echo using tyuiu.cources.programming.interfaces.Sprint%sprint%; > %classlib_class%
echo. >> %classlib_class%
echo namespace %classlib_path%; >> %classlib_class%
echo. >> %classlib_class%
echo public class DataService //: ISprint%sprint%Task%task%V%variant% >> %classlib_class%
echo { >> %classlib_class%
echo } >> %classlib_class%

:: Создаём шаблон для тестов
del %mstest_path%\UnitTest1.cs
set mstest_class=%mstest_path%\DataServiceTest.cs
echo using %classlib_path%; > %mstest_class%
echo. >> %mstest_class%
echo namespace %mstest_path%; >> %mstest_class%
echo. >> %mstest_class%
echo [TestClass] >> %mstest_class%
echo public class DataServiceTest >> %mstest_class%
echo { >> %mstest_class%
echo    [TestMethod] >> %mstest_class%
echo    public void ValidExpression()  >> %mstest_class%
echo    { >> %mstest_class%
echo    } >> %mstest_class%
echo } >> %mstest_class%

:: Добавляем в решение
dotnet sln %template%.sln add %console_path%\%console_path%.csproj --solution-folder Task%task%
dotnet sln %template%.sln add %classlib_csproj% --solution-folder Task%task%
dotnet sln %template%.sln add %mstest_path%\%mstest_path%.csproj --solution-folder Task%task%

:: Добавляем ссылки на библиотеку
dotnet add %console_path%\%console_path%.csproj reference %classlib_csproj%
dotnet add %mstest_path%\%mstest_path%.csproj reference %classlib_csproj%