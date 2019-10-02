using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace FileManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowFiles("D:\\");

            //Show drives 
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"{drive.Name}    total size = {drive.TotalSize}  " +
                    $"Free space = {drive.AvailableFreeSpace}");
            }
        }

        
        static void ShowFiles(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            foreach (var file in files)
            {
                FileInfo fi = new FileInfo(file);
                Console.WriteLine($"{file},{fi.Length}");
             //   File.Delete("abc.txt");
              //  File.Copy("source.txt", "destination.txt");
              //  bool found = File.Exists("file1.txt");
            }
            

        }
    }
}
