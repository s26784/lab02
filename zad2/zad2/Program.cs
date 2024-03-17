// See https://aka.ms/new-console-template for more information


class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] tbl = { 1, 2, 3, 4, 5 };
        Console.WriteLine(CalculateValue(tbl));
        Console.WriteLine(FindMax(tbl));
    }


    public static double CalculateValue(int[] tbl)
    {
        double value = 0;
        for (int i = 0; i < tbl.Length; i++)
        {
            value += tbl[i];
        }

        return value / tbl.Length;
    }
    
    public static int FindMax(int[] tbl)
    {
        int max = tbl[0];
        for (int i = 0; i < tbl.Length; i++)
        {
            if (max < tbl[i])
            {
                max = tbl[i];
            }
        }

        return max;
    }
    
    String Str1 = "Tomasz";
    String Str2 = "Maksym";
    String Str3 = "Daniel";
}



