using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day4.FileOperationsExceptions
{
    class FileOperations
    {
        public FileOperations()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\ishitasinghal\Desktop\test");
            FileInfo[] Files = dinfo.GetFiles("*.*");
            Console.WriteLine("The files in this directory are: ");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine("\nText files in the directory are : ");
            FileInfo[] TextFiles = dinfo.GetFiles("*.txt");
            int c = 0;
            foreach (FileInfo file in TextFiles)
            {
                //Console.WriteLine(file.Name);
                c++;
            }
            Console.WriteLine("\nNumber of text files in the directory are :" + c);

            string[] fileArray = Directory.GetFiles(@"C:\Users\ishitasinghal\Desktop\test");
            var grpextension = fileArray.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                     .GroupBy(x => x, (ext, extCnt) => new
                     {
                         Extension = ext,
                         Count = extCnt.Count()
                     });

            foreach (var v in grpextension)
            {
                Console.WriteLine("\n{0} File(s) with {1} Extension ",
                                      v.Count, v.Extension);
            }

            Console.WriteLine("\nTop 5 largets files in the directory are: ");
            var result = dinfo.GetFiles().OrderByDescending(x => x.Length).Take(5).ToList();
            foreach (var v in result)
            {
                Console.WriteLine("\nFile Name {0} Size {1}KB ",v.Name, v.Length);
            }
            Console.WriteLine("\nThe file with maximum length in the directory is : {0}", result[0].Name);

            Console.ReadLine();
        }
    }
}