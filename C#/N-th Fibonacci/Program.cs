public class Fibonacci
{
    public int NthFib(int n)
    {
        int a = 0;
        int b = 1;
        int c = 0;

        if (n == 1) return a;
        if (n == 2) return b;

        for (int i = 0; i < n - 2; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}