using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();

        // Разделение введенной строки на массив строк
        string[] inputArray = input.Split(',');

        // Формирование нового массива с элементами, длина которых меньше или равна 3 символам
        string[] resultArray = FilterArray(inputArray);

        // Вывод результата
        Console.WriteLine("Результат:");
        Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Подсчет количества элементов, удовлетворяющих условию
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива
        string[] resultArray = new string[count];
        int index = 0;

        // Заполнение нового массива
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}