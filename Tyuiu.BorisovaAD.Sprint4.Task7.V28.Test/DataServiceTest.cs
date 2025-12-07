using Tyuiu.BorisovaAD.Sprint4.Task7.V28.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "623351179845632";

            // Четные числа в строке: 6, 2, 8, 4, 6, 2
            // Произведение: 6 * 2 * 8 * 4 * 6 * 2 = 4608
            int expected = 4608;

            int actual = ds.Calculate(n, m, value);

            Assert.AreEqual(expected, actual);
        }
    }
}
