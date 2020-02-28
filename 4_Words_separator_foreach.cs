using System;
using System.IO;
using System.Text;
namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // лічильник слів, де d стоїть на 2-му місці
            string line; // допоміжний рядок
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' }; // масив
            StringBuilder otvet = new StringBuilder(); // рядок-відповідь
            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                // читання рядка з файлу, поки це можливо
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line); // друкуємо, що прочитали
                    //виділяємо слова
                    string[] words = line.Split(separator);
                    foreach (string slovo in words) //цикл за словами, цикл foreach
                    {
                        if ((slovo.Length >= 2) && (slovo[1] == 'd'))
                        {
                            counter++;
                            otvet.Append(slovo);
                            otvet.Append(" ");
                        }
                    }
                }
            }
            Console.WriteLine("There were {0} sequences.", counter);
            Console.WriteLine(otvet.ToString());
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
