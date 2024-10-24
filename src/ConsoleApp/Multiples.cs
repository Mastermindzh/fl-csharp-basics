namespace ConsoleApp;

public static class Multiples
{
    public static bool IsMultipleOf(int input, int[] dividers)
    {
        return dividers.Any(x => input % x == 0);
    }
}