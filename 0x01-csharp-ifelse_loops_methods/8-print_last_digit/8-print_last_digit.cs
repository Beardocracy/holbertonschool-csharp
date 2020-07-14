using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        int digit = number % 10;
        if (digit < 0)
        {
            digit *= -1;
        }
        Console.Write(digit.ToString("0"));
        return digit;
    }
}