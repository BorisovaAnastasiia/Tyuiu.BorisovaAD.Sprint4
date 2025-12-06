using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BorisovaAD.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int max = int.MinValue;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[1, j] > max)
                {
                    max = array[1, j];
                }
            }
            return max;
        }
    }
}
