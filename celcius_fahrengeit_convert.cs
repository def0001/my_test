namespace Project1 // Знаю, хуево написал, но я тока учусь, так что мдэа.
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("===--- 1 - перевести °C в °F.");
            Console.WriteLine("===--- 2 - перевести °F в °C.");
            Console.WriteLine("===--- e - выйти из программы.");
            Console.WriteLine("\n===--- Введите действие (1, 2, e):");
            char action;
            while (true)
            {

                try
                {
                    Console.Write("\n> ");
                    action = Convert.ToChar(Console.ReadLine() ?? "");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: неизвестный символ.");
                    continue;
                }
                

                switch (action)
                {
                    case '1':
                        Console.WriteLine();
                        Console.Write("\nВведите температуру в °C: ");
                        double C = Convert.ToDouble(Console.ReadLine() ?? "");
                        double Fres = (C * 9 / 5 + 32); // Формула для перевода °C в °F.
                        Console.WriteLine($"Результат: {C}°C = {Fres}°F");
                        break;
                    case '2':
                        Console.Write("\nВведите температуру в °F: ");
                        double F = Convert.ToDouble(Console.ReadLine() ?? "");
                        double Cres = (F - 32) * 5 / 9; // Формула для перевода °F в °C.
                        Console.WriteLine($"Результат: {F}°C = {Cres}°F");
                        break;
                    case 'e':
                        Console.WriteLine("Прощайте...");
                        break;
                }
            }
        }
    }
}
