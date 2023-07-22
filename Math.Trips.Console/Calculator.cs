namespace Study.Exponential;

public static class Calculator
{
    public static (string, double) UNIT => ("one", 1); 

    public static string Print((string, double) tuple)
        => $"{tuple.Item1} = {tuple.Item2}";
    public static (string, double) Times(int times, (string, double) num)
    {
        var res = 0D;
        for (var i = 0; i < times; i++)
            res += num.Item2;

        return ($"{times}X({num.Item1})", res);
    }

    public static (string, double) Power(int b, int exponent)
    {
        var res = UNIT;

        for (var e = 0; e < exponent; e++)
            res = Times(b, res);

        res.Item1 = $"{b}^{exponent} = {res.Item1}";

        return res;
    }
}

