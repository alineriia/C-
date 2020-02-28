using System;
class Program
{
    public static int i = 0;
    public static void Main()
    {
        // sort string array
        string[] stringArray = new string[5] { "Csharp", "ASP.net",
"EntityFramework", "ADO.net", "WCF" };
        Array.Sort(stringArray);
        // write array
        foreach (string str in stringArray) Console.Write(str + " ");
        Console.ReadKey();
    }
}
