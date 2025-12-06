using Tyuiu.BorisovaAD.Sprint4.Task6.V19.Lib;
namespace Tyuiu.BorisovaAD.Sprint4.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив
            string[] browsers = new string[]
            {
                "Chrome",      // 6 символов - больше 5
                "Firefox",     // 7 символов - больше 5  
                "Safari",      // 6 символов - больше 5
                "Opera",       // 5 символов - не больше 5
                "Edge",        // 4 символа - не больше 5
                "Internet Explorer", // 16 символов - больше 5
                "Brave"        // 5 символов - не больше 5
            };

            // Ожидаемый результат: Chrome(6), Firefox(7), Safari(6), Internet Explorer(16) = 4 элемента
            int result = ds.Calculate(browsers);

            Assert.AreEqual(4, result);
        }
    }
}
