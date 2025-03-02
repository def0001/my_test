namespace test1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ввелите количество рандомных чисел: ");
            short n = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Введите минимальное рандомное число: ");
            short n2 = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Введите максимальное рандомное число: ");
            short n3 = Convert.ToInt16(Console.ReadLine());
            
            short[] numbers = new short[n];
            Random rand = new Random();
            
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(rand.Next(n2, n3));
                Console.WriteLine($"Number {i}: {numbers[i]}");
            }
        }
    }
}
