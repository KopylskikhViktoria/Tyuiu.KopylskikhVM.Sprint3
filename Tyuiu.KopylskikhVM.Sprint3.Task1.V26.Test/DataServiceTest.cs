using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint3.Task1.V26.Lib;

namespace Tyuiu.KopylskikhVM.Sprint3.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 8;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(1.500, res);
        }
    }
}