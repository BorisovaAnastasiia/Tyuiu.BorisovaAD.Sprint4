using Tyuiu.BorisovaAD.Sprint4.Task1.V7.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            int act = ds.Calculate(array);
            int wait = 24;
            Assert.AreEqual(act, wait);
        }
    }
}
