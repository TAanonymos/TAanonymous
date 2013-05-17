using System;

class Methods
{
    static double CalcTriangleArea(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("Sides should be positive.");
        }
        double halfPerimeter = (a + b + c) / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        return area;
    }

    static string NumberToDigit(int number)
    {
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
        }
        throw new ArgumentException("Invalid number!");
    }

    static int FindMax(params int[] elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException("Elements can't be null!");
        }

        if (elements.Length == 0)
        {
            throw new ArgumentException("Array must have at least one element!");
        }

        int max = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }

        return max;
    }

    public static void PrintAsFloatNumber(object number)
    {
        Console.WriteLine("{0:f2}", number);
    }

    public static void PrintAsPercent(object number)
    {
        Console.WriteLine("{0:p0}", number);
    }

    public static void PrintRightAlignedNumber(object number)
    {
        Console.WriteLine("{0,8}", number);
    }

    public static bool CheckLineIsHorizontal(double x1, double x2)
    {
        bool isHorizontal = (x1 == x2);

        return isHorizontal;
    }

    public static bool CheckLineIsVertical(double y1, double y2)
    {
        bool isVertical = (y1 == y2);

        return isVertical;
    }

    public static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

        return distance;
    }

    static void Main()
    {
        Console.WriteLine(CalcTriangleArea(3, 4, 5));

        Console.WriteLine(NumberToDigit(5));

        Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

        PrintAsFloatNumber(1.3);
        PrintAsPercent(0.75);
        PrintRightAlignedNumber(2.30);

        bool horizontal = CheckLineIsHorizontal(3, 3);
        bool vertical = CheckLineIsVertical(-1, 2.5);
        Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
        Console.WriteLine("Horizontal? " + horizontal);
        Console.WriteLine("Vertical? " + vertical);
    }
}
