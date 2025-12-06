using Tyuiu.BorisovaAD.Sprint4.Task5.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        // Обновляем информацию под Вашу задачу и ФИО/группу
        Console.Title = "Спринт #4 | Выполнил: Борисова А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами. Класс Random.                  *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Борисова Александра Дмитриевна | ИБКСб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, " +
            "заполненный случайными значениями в диапазоне от -2 до 4. " +
            "Найти сумму положительных элементов.");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        int rows = 5;
        int columns = 5;
        int[,] matrix = new int[rows, columns];

        Console.WriteLine("Сгенерированный массив 5x5:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Генерация случайного числа в диапазоне от -2 до 4 включительно
                matrix[i, j] = rnd.Next(-2, 5);
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int sumPositiveElements = ds.Calculate(matrix);
        Console.WriteLine($"Сумма положительных элементов массива: {sumPositiveElements}");

        Console.ReadKey();
    }
}