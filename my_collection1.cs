// Здесь собраны все программы, который я написал до 10.04.25

namespace Pisdec
{
    class Program // Замените на имя вашей программы.
    {
        static void Main()
        {
            sbyte result;
            while (true)
            {
                result = Pisdec();

                if (result != 0)
                {
                    if (result == -1)
                    {
                        Console.WriteLine("\nНеверный номер программы!");
                        Console.WriteLine("1-3, ~ для вывода списка доступных программ.\n");
                    }
                    else if (result == 1)
                    {
                        Console.WriteLine("\nВыход из программы...");
                        break;
                    }
                }
            }
        }

        // ###################################################################################################################
        public static float Calculate() // Бездарный калькулятор.
        {
            Console.Write("Введите первое число: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите оператор (+, -, *, /): ");
            char math = Convert.ToChar(Console.ReadLine() ?? "+");

            switch (math)
            {
                case '+':
                    {
                        Console.WriteLine($"Результат: {a} {math} {b} = {a + b}");
                        return 0;
                    }
                case '-':
                    {
                        Console.WriteLine($"Результат: {a} {math} {b} = {a - b}");
                        return 0;
                    }
                case '*':
                    {
                        Console.WriteLine($"Результат: {a} {math} {b} = {a * b}");
                        return 0;
                    }
                case '/':
                    {
                        if (b == 0 || a == 0)
                        {
                            Console.WriteLine("На ноль делить низя!");
                            return 0;
                        }
                        Console.WriteLine($"Результат: {a} {math} {b} = {a / b}");
                        return 0;
                    }
                default:
                    {
                        Console.WriteLine($"Неверный оператор \"{math}\"!");
                        return 0;
                    }
            }
        }
        // ###################################################################################################################
        public static sbyte RandNumsGenerator() // Генератор рандомных чисел.
        {
            Console.Write("Введите количество рандомных чисел: ");
            short n = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите минимальное рандомное число: ");
            short n2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите максимальное рандомное число: ");
            short n3 = Convert.ToInt16(Console.ReadLine());
            short[] numbers = new short[n];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(rand.Next(n2, n3));
                Console.WriteLine($"Число {i + 1}: {numbers[i]}");
            }
            return 0;
        }
        // ###################################################################################################################
        public static sbyte TextDublicator() // Дубликатор текста.
        {
            Console.Write("Введите текст: ");
            String text = Console.ReadLine() ?? "text";
            Console.Write("Введите число повторений: ");
            int num = Convert.ToInt32(Console.ReadLine() ?? "10");

            for (int i = 1; i < num + 1; i++)
            {
                Console.WriteLine($"{i} {text}");
            }
            return 0;
        }
        // ###################################################################################################################

        public static sbyte Pisdec() // Выбор программы.
        {
            Console.Write("Выберите программу: ");
            char program = Convert.ToChar(Console.ReadLine() ?? "");
            switch (program)
            {
                case '~':
                    {
                        Console.WriteLine("\nСписок доступных программ:");
                        Console.WriteLine("1 - Бездарный калькулятор. Может работать с двумя оперантами и операторами +, -, * и /.");
                        Console.WriteLine("2 - Генератор рандомных чисел.");
                        Console.WriteLine("3 - Дубликатор текста. Очень полезен, если например девушка заставила вас сказать \"Извини\" 100 раз.");
                        Console.WriteLine("q - Выход из программы.\n");
                        return 0;
                    }
                case '1':
                    {
                        Console.WriteLine("Программа 1: Бездарный калькулятор.");
                        Calculate();
                        return 0;
                    }
                case '2':
                    {
                        Console.WriteLine("Программа 2: Генератор рандомных чисел.");
                        RandNumsGenerator();
                        return 0;
                    }
                case '3':
                    {
                        Console.WriteLine("Программа 3: Дубликатор текста.");
                        TextDublicator();
                        return 0;
                    }
                case 'q':
                    {
                        return 1; // 1 - выход из программы (вызов).
                    }
                default:
                    {
                        return -1; // -1 - ошибка.
                    }
            }
        }
    }
}
