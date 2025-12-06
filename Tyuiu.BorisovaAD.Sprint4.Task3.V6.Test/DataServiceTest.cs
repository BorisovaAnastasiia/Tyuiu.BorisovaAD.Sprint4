using Tyuiu.BorisovaAD.Sprint4.Task3.V6.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Инициализация сервиса и данных
            DataService ds = new DataService();
            int[,] array = new int[5, 5] {
                {8, 8, 3, 4, 5},
                {8, 6, 6, 4, 6}, // Вторая строка
                {3, 6, 5, 3, 4},
                {5, 6, 3, 7, 5},
                {7, 8, 5, 6, 6}
            };

            // Установка ожидаемого результата
            int expected = 8;

            // Получение фактического результата
            int actual = ds.Calculate(array);

            // Сравнение результатов
            Assert.AreEqual(expected, actual);
        }
    }
}
