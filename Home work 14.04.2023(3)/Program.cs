using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_14._04._2023_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите путь к каталогу");
            string path = "";
            
         
            if (args.Length > 0)
            {
                path = args[0];
                
                var dir = new DirectoryInfo(path); // папка с файлами которая будет задана пользователем
                Console.WriteLine("Аргументы переданы\n Список папок выбранного каталога:");
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file.FullName));
            }

            Console.WriteLine();
            Console.ReadKey();

            }

            else
            {
                var dir2 = new DirectoryInfo(@"C:\Users\safim\source\repos\Home work 14.04.2023(3)"); // папка с файлами по умолчанию
                Console.WriteLine("Список папок текущего каталога:");

                foreach (FileInfo file in dir2.GetFiles())
                {
                    
                    Console.WriteLine(Path.GetFileNameWithoutExtension(file.FullName));
                }

                Console.WriteLine();
            }
            
          
        }
    }
}
