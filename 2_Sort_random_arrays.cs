using System;
class Program
{
    public static void Main()
    {
        int i;
        int[] a = new int[5];
        int[] b = new int[7];
        Random rnd = new Random();
        for (i = 0; i < a.Length; i++)
            a[i] = rnd.Next(0, 100);
        for (i = 0; i < b.Length; i++)
            b[i] = rnd.Next(0, 100);
        Array.Sort(a);
        Array.Sort(b);
        for (i = 0; i < a.Length; i++)
        {
            Console.WriteLine("a[{0}]= {1} ", i, a[i]);
        }
        Console.WriteLine("==========================");
        for (i = 0; i < b.Length; i++)
        {
            Console.WriteLine("b[{0}]= {1} ", i, b[i]);
        }


        Console.ReadKey();
    }
}
