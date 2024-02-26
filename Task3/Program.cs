namespace Task3
{
    internal class Program
    {
        static void PrintReversedArray(int[] arr, int i)
        {
            if (i < 0)
                return;
            Console.Write(arr[i] + " ");
            PrintReversedArray(arr, i - 1);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            PrintReversedArray(arr, arr.Length - 1);
        }
    }
}