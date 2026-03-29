using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KopylskikhVM.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] values = new double[len];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 3;

                if (denominator == 0)
                {
                    values[index] = 0;
                }
                else
                {
                    double y = (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
                    values[index] = Math.Round(y, 2);
                }

                index++;
            }

            return values;
        }
    }
}