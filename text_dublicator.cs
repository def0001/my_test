// Прошло немного больше времени.
namespace for_tests
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            String text = Console.ReadLine() ?? "text";
            Console.Write("Введите число повторений: ");
            int num = Convert.ToInt32(Console.ReadLine() ?? "10");

            for (int i = 1; i < num+1; i++)
            {
                Console.WriteLine($"{i} {text}");
            }
        }
    }
}
