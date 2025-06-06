namespace Project1
{
    internal static class Program
    {
        static void Main()
        {
            byte minByte = Byte.MinValue;
            byte maxByte = Byte.MaxValue;

            Random rand = new();

            byte tryCount = (byte)rand.Next(5, 15);

            byte minValue;
            byte maxValue;

            while (true)
            {
                minValue = Convert.ToByte(rand.Next(minByte, maxByte));
                maxValue = Convert.ToByte(rand.Next(minByte, maxByte));

                if (minValue >= maxValue)
                {
                    continue;
                }
                else
                    break;
            }

            byte imgValue = Convert.ToByte(rand.Next(minValue + 1, maxValue));

            string? str;
            int strNum;

            Console.WriteLine($"Я загадал число, которое больше {minValue} и меньше {maxValue}.");
            Console.WriteLine($"У тебя есть {tryCount} попыток, что бы отгадать загаданное число!");

            while (true)
            {
                Console.Write($"({tryCount})> ");
                str = Console.ReadLine();

                if (!int.TryParse(str, out strNum))
                {
                    Console.WriteLine("В строке может быть только число!");
                    continue;
                }

                if (strNum == imgValue && tryCount > 0)
                {
                    Console.WriteLine($"Вы угадали число {imgValue}! Поздравляем!!");
                    break;
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
