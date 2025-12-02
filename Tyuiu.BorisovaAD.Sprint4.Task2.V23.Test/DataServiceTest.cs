using Tyuiu.BorisovaAD.Sprint4.Task2.V23.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            // Тестовый массив (сумма четных: 4+6+8+4+6 = 28)
            int[] array = { 3, 4, 5, 6, 7, 8, 3, 4, 5, 6, 7, 8, 3, 4, 5 };
            int expected = 28;
            int actual = ds.Calculate(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
