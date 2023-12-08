using System;
using System.Numerics;

namespace code;
public class Calculator
{
    public static BigInteger Calculate(BigInteger[] numbers)
    {
        BigInteger lcm = LCM(numbers);

        return lcm;
    }

    private static BigInteger LCM(BigInteger[] numbers)
    {
        BigInteger result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = LCM(result, numbers[i]);
        }
        return result;
    }

    private static BigInteger LCM(BigInteger a, BigInteger b)
    {
        return a / GCD(a, b) * b;
    }

    private static BigInteger GCD(BigInteger a, BigInteger b)
    {
        while (b != 0)
        {
            BigInteger temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

