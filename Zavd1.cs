﻿using System;
using System.Text;
using System.IO;
namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder text = new StringBuilder();
            StringBuilder newText = new StringBuilder();
            string line;
            int i;
            using (StreamReader MyFile = new StreamReader("test.txt"))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    text.Append(line);
                    i = 0; 
                    while (i < line.Length)
                    {
                        if (line.Contains("+") == true) { 
                        if ((i < line.Length) && (char.IsDigit(line, i)))
                        {
                            newText = text.Replace(line[i], '*');
                        }
                    }
                        else { newText = text; }
                            i++;
                        }
                    }
                }
            
            Console.WriteLine(newText);
            Console.ReadKey();
        }
    }
}

