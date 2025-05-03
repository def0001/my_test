namespace Calculator_3._0
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Clear();
            int delay;
            
            while (true)
            {
                Console.Write("Введите скорость работы таймера (1000 - 1 сек.): ");
                var timerSpeed = Console.ReadLine();
                Console.Clear();
                
                if (int.TryParse(timerSpeed, out delay) && delay > 0)
                {
                    Console.Clear();
                    break;
                }
            }

            var isDoing = true;
            
            byte sec = 0;
            byte min = 0;
            byte hour = 0;
            var day = 0;
            
            while (isDoing)
            {
                sec ++;
                if (sec == 60)
                {
                    sec = 0;
                    min ++;
                    if (min == 60)
                    {
                        min = 0;
                        hour ++;
                        if (hour == 24)
                        {
                            hour = 0;
                            day ++;
                            if (day == Int32.MaxValue)
                            {
                                Console.WriteLine($"Таймер достиг максимального значения: {Int32.MaxValue}");
                                isDoing = false;
                            }
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{day}d: ");
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{hour}h: ");
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{min}m: ");
                
                Console.ResetColor();
                Console.Write($"{sec}s");
                
                Thread.Sleep(delay);
                Console.SetCursorPosition(0, 0);
            }
        }
    }
}
