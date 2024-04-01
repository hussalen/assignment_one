namespace assignment_one;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
    }

    static int CalculateAverage(int[] ints)
    {
        int sum = 0;
        foreach (int i in ints)
        {
            sum += i;
        }
        return sum / ints.Length;
    }
}
