// See https://aka.ms/new-console-template for more information


class Program
{
    public static void main(String[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] tbl = { 1, 2, 3, 4, 5 };
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
    
    String Str1 = "Tomasz";
    String Str2 = "Maksym";
    String Str3 = "Daniel";
}



