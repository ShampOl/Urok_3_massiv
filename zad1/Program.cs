  {
        // Создаем одномерный массив из 10 целых чисел от 1 до 100
        int[] array = new int[10];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        // Выводим массив для наглядности
        Console.WriteLine("Массив: " + string.Join(", ", array));

        // Находим количество элементов в отрезке [20, 90]
        int countInRange = CountElementsInRange(array, 20, 90);

        // Выводим результат
        Console.WriteLine("Количество элементов в отрезке [20, 90]: " + countInRange);
    }

    static int CountElementsInRange(int[] array, int lowerBound, int upperBound)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num >= lowerBound && num <= upperBound)
            {
                count++;
            }
        }
        return count;
    }

