 {
        // Вводим натуральное число в диапазоне от 1 до 100,000
        Console.Write("Введите натуральное число (от 1 до 100,000): ");
        int inputNumber;
        while (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber < 1 || inputNumber > 100000)
        {
            Console.Write("Пожалуйста, введите корректное число: ");
        }

        // Создаем массив из цифр числа
        int[] digitArray = ExtractDigitsToArray(inputNumber);

        // Выводим массив для наглядности
        Console.WriteLine("Массив из цифр числа: " + string.Join(", ", digitArray));
    }

    static int[] ExtractDigitsToArray(int number)
    {
        // Используем List<int>, чтобы динамически добавлять цифры
        List<int> digitsList = new List<int>();

        // Разбираем число на цифры и добавляем их в массив
        while (number > 0)
        {
            int digit = number % 10;
            digitsList.Insert(0, digit);  // Вставляем в начало списка, чтобы старший разряд был на 0-м индексе
            number /= 10;
        }

        // Преобразуем List<int> в массив int[]
        int[] digitArray = digitsList.ToArray();

        return digitArray;
    }

