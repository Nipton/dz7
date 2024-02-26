namespace Task1
{
    internal class Program
    {
        static void PrintNaturalNumbers(int m, int n)
        {
            if (m == n)
            {
                Console.Write(m);
                return;
            }
            Console.Write(m + ", ");
            PrintNaturalNumbers(m + 1, n);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (m <= n)
                PrintNaturalNumbers(m, n);
        }
    }
}