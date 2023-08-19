internal class Program
{
    public static int Fatorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Fatorial(n - 1);
    }
    private static void Main(string[] args)
    {
    }
}