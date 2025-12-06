using Tyuiu.BorisovaAD.Sprint4.Task4.V19.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Инициализация сервиса
            DataService ds = new DataService();

            // Исходные данные (матрица из условия)
            int[,] matrix = new int[,] {
                {6, 7, 3, 5, 1},
                {6, 5, 2, 2, 7},
                {2, 6, 4, 6, 6},
                {7, 5, 5, 2, 6},
                {3, 1, 5, 7, 7}
            };

            // Ожидаемый результат (сумма нечетных элементов = 68)
            int expected = 68;

            // Получение фактического результата
            int actual = ds.Calculate(matrix);

            // Сравнение результатов
            Assert.AreEqual(expected, actual);
        }
    }
}
