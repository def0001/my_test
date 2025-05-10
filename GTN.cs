namespace Project1
{
    internal static class Program
    {
        static void Main()
        {
            byte minByte = Byte.MinValue;
            byte maxByte = Byte.MaxValue;

            Random rand = new();

            byte tryCount = Convert.ToByte(rand.Next(5, 15));

            byte minValue = Convert.ToByte(rand.Next(minByte, maxByte));
            byte maxValue = Convert.ToByte(rand.Next(minByte, maxByte));
            byte imgValue = Convert.ToByte(rand.Next(minValue, maxValue));

            int? str;

            Console.WriteLine($"Я загадал число, которое больше {minValue} и меньше {maxValue}.");
            Console.WriteLine($"У тебя есть {tryCount} попыток, что бы отгадать загаданное число!");

            while (true)
            {
                Console.Write($"({tryCount})> ");
                str = Convert.ToInt32(Console.ReadLine());

                if (str == imgValue && tryCount !< 0)
                {
                    
                }
                else
                {
                    tryCount--;
                    Console.WriteLine($"Вы не угадали! У вас осталось {tryCount} попыток.");

                    if (tryCount == 0)
                    {
                        Console.WriteLine($"Вы проиграли! Это было число {imgValue}.");
                        break;
                    }
                }
            }
        }
    }
}
