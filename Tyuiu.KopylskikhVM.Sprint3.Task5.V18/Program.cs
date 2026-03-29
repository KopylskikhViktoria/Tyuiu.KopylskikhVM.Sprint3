using Tyuiu.KopylskikhVM.Sprint3.Task5.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение выражения:                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* y = Σ(i=1..3) Σ(k=1..11) (cos(x) + k^2 / 2)                             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* при x = 5                                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 5;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 11;

        Console.WriteLine("Переменная x = " + x);
        Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
        Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadLine();
    }
}