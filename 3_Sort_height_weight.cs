using System;
class Program
{
    public static void Main()
    {
        int i;
        int[] a = new int[10];
        int[] b = new int[10];
        Random rnd = new Random();
        for (i = 0; i < a.Length; i++)
            a[i] = rnd.Next(140, 200);
        for (i = 0; i < b.Length; i++)
            b[i] = rnd.Next(45, 120);
        for (i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Зріст {0} Вага {1} ", a[i], b[i]);
        }
        Console.WriteLine("***********************************");
        Array.Sort(a, b);
        for (i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Зріст {0} Вага {1} ", a[i], b[i]);
        }
        Console.ReadKey();
    }
}
