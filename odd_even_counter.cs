namespace Project1
{
    internal static class Program
    {
        static void Main()
        {
            Console.Clear();

            int oddCount = 0, evenCount = 0; // Нечётные, чётные числа
            string? strMin = null, strMax = null;
            int min, max; 

            while (true)
            {
                Console.Write("(min)> ");
                try
                {
                    strMin = Console.ReadLine();

                    if (String.IsNullOrEmpty(strMin))
                    {
                        Console.Write($"Ошибка: значение не может быть null или empty, но strMin({strMin}) является такими.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    min = Int32.Parse(strMin);
                    break;
                }

                catch
                {
                    Console.WriteLine($"Ошибка: не удалось парсить значение strMin({strMin}) из string в Int32.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"(min)> {min}");
                Console.Write("(max)> ");
                try
                {
                    strMax = Console.ReadLine();

                    if (String.IsNullOrEmpty(strMax))
                    {
                        Console.Write($"Ошибка: значение не может быть null или empty, но strMax({strMax}) является таким.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    max = Int32.Parse(strMax);
                    break;
                }

                catch
                {
                    Console.WriteLine($"Ошибка: не удалось парсить значение strMax({strMax}) из string в Int32.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }

            Console.Clear();

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine("Производиться подсчёт...");

                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} - чётное число.");
                    Console.SetCursorPosition(0, 0);
                    evenCount++;
                }

                else
                {
                    Console.WriteLine($"{i} - нечётное число.");
                    Console.SetCursorPosition(0, 0);
                    oddCount++;
                }
            }

            Console.Clear();
            Console.Write("Подсчёт завершен! Нажмите любую клавишу для продолжения: ");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine($"Кол-во нечётных чисел: {oddCount}");
            Console.WriteLine($"Кол-во чётных чисел: {evenCount}");
        }
    }
}
