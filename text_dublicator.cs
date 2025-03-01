// Прошло всего несколько дней с того момента, как я начал изучать C#. Пока что, это всё что я умею.
using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            if (word == null)
            {
                word = "null";
            }

            while (true)
            {
                Console.Write("Введите число повторений (не больше 32,766 и не меньше 2): ");
                short number = Convert.ToInt16(Console.ReadLine());
                if (number >= 32767 && number <= 1) // Предохранитель от краша
                {
                    number = 1;
                    Console.WriteLine("Блять долбаи давай по новой");
                    Console.Write("Введите число повторений (не больше 32,767): ");
                    number = Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    for (short i = 0; i <= number; i++)
                    {
                        Console.WriteLine($"{i}) {word}");
                    }
                    break;
                }

            }
        }
    }
}
