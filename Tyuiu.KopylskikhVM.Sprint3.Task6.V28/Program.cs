using Tyuiu.KopylskikhVM.Sprint3.Task6.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
        Console.WriteLine("* принадлежащих числовому отрезку [13, 19],                               *");
        Console.WriteLine("* количество всех делителей меньше 7.                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 13;
        int stopValue = 19;

        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadLine();
    }
}