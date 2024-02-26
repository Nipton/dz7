namespace Task2
{
    internal class Program
    {
        static int AckermanFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return AckermanFunction(m - 1, 1);
            }
            else
            {
                return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AckermanFunction(m, n));
        }
    }
}