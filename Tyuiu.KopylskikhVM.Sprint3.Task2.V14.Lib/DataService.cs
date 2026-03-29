using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KopylskikhVM.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            int k = startValue;

            do
            {
                result *= Math.Pow((double)value / k, 3);
                k++;
            } while (k <= stopValue);

            return Math.Round(result, 3);
        }
    }
}