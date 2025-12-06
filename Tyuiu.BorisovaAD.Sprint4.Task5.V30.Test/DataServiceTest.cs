using Tyuiu.BorisovaAD.Sprint4.Task5.V30.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Статический набор данных для тестирования, соответствующий диапазону [-2; 4]
            int[,] matrix = new int[,] {
                {4, -1, 0, 3, 2},
                {-2, 1, 4, 0, -1},
                {3, 2, -1, 4, 1},
                {0, -2, 3, 1, 4},
                {2, 4, 1, -2, 0}
            };

            // Ожидаемый результат: сумма только положительных элементов:
            // 4+3+2 + 1+4+1 + 3+2+4+1 + 3+1+4 + 2+4+1 = 38
            int expected = 38;

            int actual = ds.Calculate(matrix);

            Assert.AreEqual(expected, actual);
        }
    }
}
