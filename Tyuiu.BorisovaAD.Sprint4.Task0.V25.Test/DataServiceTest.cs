using Tyuiu.BorisovaAD.Sprint4.Task0.V25.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int expected = 42;
            int actual = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
