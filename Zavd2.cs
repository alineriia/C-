using System;
using System.Text;
using System.IO;
namespace ComsoleApp3
{
    class Program
    {
        public static void Main()
        {
            StringBuilder text = new StringBuilder();
            StringBuilder newText = new StringBuilder();
            string line;
            using (StreamReader MyFile = new StreamReader("test.txt"))

            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    text.Append(line + "\n");
                    if (line.Contains("I") == true)
                    {
                        newText = text.Remove(2, 19);

                    }
                    else
                    {
                        newText = text;
                    }
                }

            }



            Console.WriteLine("\n" + newText);


            Console.ReadLine();
        }
    }
}
