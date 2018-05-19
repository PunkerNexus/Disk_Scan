using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ScannerForFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            // один из вариантов
            // попытка сделать с EnumerateFiles
            // ищет до момента, пока не словит exception
            // в класс Scanner добавлять нечего
            Console.WriteLine("Enter the folder name(like 'c:\\', 'e:\\', 'd:\\' or another folder you have): ");
            string directory = Console.ReadLine();

            try
            {
                foreach (string file in Directory.EnumerateFiles(@directory, "*.*", SearchOption.AllDirectories))
                {
                    Console.WriteLine(file);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
            Console.ReadKey();
        }
    }
}
