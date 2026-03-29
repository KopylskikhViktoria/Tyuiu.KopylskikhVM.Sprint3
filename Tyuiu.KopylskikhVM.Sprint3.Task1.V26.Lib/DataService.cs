using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KopylskikhVM.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            while (k <= stopValue)
            {
                sum += Math.Pow(6.0 / Math.Pow(value, k), 2);
                k++;
            }

            return Math.Round(sum, 3);
        }
    }
}