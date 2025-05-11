namespace Project1
{
    internal static class Program
    {
        static void Main()
        {
            var whileDo = true; // Статус цикла
            string? str;
            double? result;

            while (whileDo)
            {
                Console.Write("> ");
                str = Console.ReadLine();

                switch (str)
                {
                    case "exit":
                    case "e":
                        Console.WriteLine("\nВыход из программы...");
                        whileDo = false;
                        continue;

                    case "help":
                        Console.WriteLine("\n===---  ОПЕРАТОРЫ  ---===");
                        Console.WriteLine("           \"+\" - сложение ");
                        Console.WriteLine("           \"-\" - вычитание ");
                        Console.WriteLine("           \"*\" - умножение ");
                        Console.WriteLine("           \"/\" - деление ");
                        Console.WriteLine("\n===---   КОМАНДЫ   ---===");
                        Console.WriteLine("           help - показать список доступных оператором и команд");
                        Console.WriteLine("           e/exit - выйти из программы\n");
                        WaitToClear();
                        continue;

                    default:
                        result = Calculate(str);
                        break;
                }

                if (result == null)
                    continue;

                Console.WriteLine($"\nРезультат: {str} = {result}\n");
                WaitToClear();

            }
        }

        static double? Calculate(string? input)
        {
            double? result;
            string[] math;
            
            char op;
            double? num1;
            double? num2;

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("\nОшибка: пустая строка.\n");
                WaitToClear();
                return null;
            }

            math = input.Split(" ");

            if (math.Length != 3)
            {
                Console.WriteLine("\nОшибка: недостающее значение строки.\n");
                WaitToClear();
                return null;
            }

            try
            {
                num1 = Convert.ToDouble(math[0]);
                num2 = Convert.ToDouble(math[2]);
                op = Convert.ToChar(math[1]);
            }

            catch
            {
                Console.WriteLine("\nОшибка: неизвестное значение строки.\n");
                WaitToClear();
                return null;
            }

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"\nОшибка: деление на 0.\n");
                        WaitToClear();
                        return null;
                    }

                    result = num1 / num2;
                    break;

                default:
                    Console.Write("\nОшибка: неизвестная операция.\n");
                    WaitToClear();
                    return null;
            }

            return result;
        }

        static void WaitToClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
