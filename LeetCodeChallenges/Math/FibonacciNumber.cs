namespace Math;

public class FibonacciNumber
{
    public int Fib(int n)
    {
        return n switch
        {
            0 => 0,
            1 => 1,
            _ => Fib(n - 1) + Fib(n - 2)
        };
    }
}