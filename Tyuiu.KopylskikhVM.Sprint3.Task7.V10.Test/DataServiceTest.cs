using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint3.Task7.V10.Lib;

namespace Tyuiu.KopylskikhVM.Sprint3.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] wait = { -15.4, -13.31, -11.36, -8, -2.62, 1.83, 4.49, 6.78, 10.58, 17.38, 23.76 };
            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}