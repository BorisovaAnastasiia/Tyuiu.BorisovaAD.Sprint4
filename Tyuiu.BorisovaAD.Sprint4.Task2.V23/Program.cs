using Tyuiu.BorisovaAD.Sprint4.Task2.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        // Инициализация генератора случайных чисел
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Борисова А.Д. | Смартб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами                                 *");
        Console.WriteLine("* Задание #2                                                              *"); // Исправлено на Задание #2
        Console.WriteLine("* Вариант #23                                                             *"); // Исправлено на Вариант #23
        Console.WriteLine("* Выполнил: Борисова Анастасия Дмитриевна | Смартб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный " +
            "случайными значениями в диапазоне от 3 до 8 подсчитать сумму четных элементов массива."); // Исправлено условие
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        const int len = 15; // Длина массива 15 элементов
        int[] array = new int[len];

        // Заполнение массива случайными числами от 3 до 8 (верхняя граница Exclusive, поэтому 9)
        for (int i = 0; i < len; i++)
        {
            array[i] = rnd.Next(3, 9);
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < len; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Вызываем метод Calculate из библиотеки V23
        int sum = ds.Calculate(array);
        Console.WriteLine($"Сумма четных элементов массива: {sum}"); // Улучшенный вывод результата
        Console.ReadKey();
    }
}