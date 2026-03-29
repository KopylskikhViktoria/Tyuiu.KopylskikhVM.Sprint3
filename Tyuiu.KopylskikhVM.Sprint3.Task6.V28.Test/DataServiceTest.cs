using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint3.Task6.V28.Lib;

namespace Tyuiu.KopylskikhVM.Sprint3.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 19;

            int wait = 15;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}