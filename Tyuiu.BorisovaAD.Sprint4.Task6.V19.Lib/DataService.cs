using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BorisovaAD.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            // Используем foreach для перебора всех элементов
            foreach (string item in array)
            {
                // Проверяем, длина строки больше 5
                if (item.Length > 5)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
