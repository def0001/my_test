namespace Pisdec
{
    class Program
    {
        static void Main()
        {
            Calculate();
        }

        public static float Calculate()
        {
            Console.Write("Введите первое число: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите оператор: ");
            char math = Convert.ToChar(Console.ReadLine() ?? "+");

            switch (math)
            {
                case '+':
                    {
                        Console.WriteLine($"Результат: {a} {math} {b}");
                        return a + b;
                    }
                case '-':
                    {
                        Console.WriteLine($"Результат: {a} {math} {b}");
                        return a - b;
                    }
                case '*':
                    {
                        Console.WriteLine($"Результат: {a} {math} {b}");
                        return a * b;
                    }
                case '/':
                    {
                        if (b == 0 || a == 0)
                        {
                            Console.WriteLine("На ноль делить низя!");
                            return 0;
                        }
                        Console.WriteLine($"Результат: {a} {math} {b}");
                        return a / b;
                    }
                default:
                    {
                        Console.WriteLine($"Неверный оператор \"{math}\"!");
                        return 0;
                    }
            }
        }
    }
}
