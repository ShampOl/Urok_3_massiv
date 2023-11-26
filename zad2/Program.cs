 {
        // Создаем массив из 10 целых чисел
        int[] array = { 2, 7, 14, 5, 20, 11, 8, 17, 30, 6 };

        // Выводим массив для наглядности
        Console.WriteLine("Массив: " + string.Join(", ", array));

        // Находим количество четных чисел в массиве
        int countEvenNumbers = CountEvenNumbers(array);

        // Выводим результат
        Console.WriteLine("Количество четных чисел в массиве: " + countEvenNumbers);
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

