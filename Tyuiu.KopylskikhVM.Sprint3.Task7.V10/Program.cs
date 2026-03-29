using Tyuiu.KopylskikhVM.Sprint3.Task7.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Копыльских В. М. | НТМ-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("* F(x) = (5 + x) / (sin(x) + 3) - 2x + cos(x)                             *");
        Console.WriteLine("* на заданном диапазоне [-5; 5] с шагом 1.                                *");
        Console.WriteLine("* Произвести проверку деления на ноль.                                    *");
        Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
        Console.WriteLine("* Значения занести в массив.                                              *");
        Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double[] res = ds.GetMassFunction(startValue, stopValue);

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine("x = " + (startValue + i) + " ; y = " + res[i]);
        }

        Console.ReadLine();
    }
}