using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KopylskikhVM.Sprint3.Task4.V13.Lib
{
    public class DataService : ISprint3Task4V13
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                result *= Math.Sin(x) / Math.Cos(x);
            }

            return Math.Round(result, 3);
        }
    }
}