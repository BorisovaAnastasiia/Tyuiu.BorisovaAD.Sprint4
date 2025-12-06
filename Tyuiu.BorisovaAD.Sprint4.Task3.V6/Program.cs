using Tyuiu.BorisovaAD.Sprint4.Task3.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Борисова А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Борисова Александра Дмитриевна | ИБКСб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, " +
            "заполненный статическими значениями в диапазоне от 3 до 8. " +
            "Найдите максимальный элемент во второй строке массива.");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        int[,] ms = {
            {8, 8, 3, 4, 5},
            {8, 6, 6, 4, 6},
            {3, 6, 5, 3, 4},
            {5, 6, 3, 7, 5},
            {7, 8, 5, 6, 6}
        };
        int rows = ms.GetUpperBound(0) + 1;
        int columns = ms.Length / rows;
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{ms[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int maxElement = ds.Calculate(ms);
        Console.WriteLine(maxElement);
        Console.ReadKey();
    }
}