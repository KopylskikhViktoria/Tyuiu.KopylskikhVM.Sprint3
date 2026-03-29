using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KopylskikhVM.Sprint3.Task3.V23.Lib;

namespace Tyuiu.KopylskikhVM.Sprint3.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);

            Assert.AreEqual("fd88t 8iu v8r8", res);
        }
    }
}