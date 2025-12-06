using Tyuiu.BorisovaAD.Sprint4.Task6.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        // Обновляем информацию под Вашу задачу и ФИО/группу
        Console.Title = "Спринт #4 | Выполнил: Борисова А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c массивами. Класс Random.                  *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #19                                                             *"); // Изменен номер варианта
        Console.WriteLine("* Выполнил: Борисова Александра Дмитриевна | ИБКСб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных [\"Chrome\", \"Firefox\", \"Safari\",           *");
        Console.WriteLine("* \"Opera\", \"Edge\", \"Internet Explorer\", \"Brave\"].                    *");
        Console.WriteLine("* Подсчитайте количество элементов, длина которых больше 5.               *"); // Изменено условие
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        // Создаем строковый массив как указано в задании
        string[] browsers = new string[]
        {
                "Chrome",
                "Firefox",
                "Safari",
                "Opera",
                "Edge",
                "Internet Explorer",
                "Brave"
        };

        Console.WriteLine("Исходный массив строк:");
        for (int i = 0; i < browsers.Length; i++)
        {
            Console.WriteLine($"[{i}] = \"{browsers[i]}\" (длина: {browsers[i].Length})");
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int count = ds.Calculate(browsers); // Вызываем метод для строкового массива
        Console.WriteLine($"Количество элементов с длиной больше 5: {count}");

        Console.ReadKey();
    }
}