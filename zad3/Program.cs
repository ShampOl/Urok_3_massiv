 {
        // Создаем массив из вещественных чисел
        double[] array = { 2.45, 7.89, 14.12, 5.67, 20.34, 11.78, 8.56, 17.23, 30.01, 6.45 };

        // Выводим массив для наглядности
        Console.WriteLine("Массив: " + string.Join(", ", array));

        // Находим разницу между максимальным и минимальным элементами
        double difference = FindDifference(array);

        // Выводим результат
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }

    static double FindDifference(double[] array)
    {
        if (array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым.");
        }

        double min = array[0];
        double max = array[0];

        // Находим минимальный и максимальный элементы в массиве
        foreach (double num in array)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;
        return difference;
    }

