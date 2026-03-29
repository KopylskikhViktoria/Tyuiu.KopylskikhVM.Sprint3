using Tyuiu.KopylskikhVM.Sprint3.Task1.V26.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить сумму ряда:                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* S = Σ(k=1..8) (6 / n^k)^2                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* n = 5                                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 5;
        int startValue = 1;
        int stopValue = 8;

        Console.WriteLine("Переменная n = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadLine();
    }
}