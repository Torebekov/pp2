using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    { 
        static void PrintSpaces(int level)// method to print spaces before name of directory or file
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        static void fm(DirectoryInfo directory, int level)//method to show directories and files
        {
            FileInfo[] files = directory.GetFiles();//array to store all files in directory
            DirectoryInfo[] directories = directory.GetDirectories();//array to stroe all directories in this directory

            foreach (FileInfo file in files)//loop to show all files in current directory
            {
                PrintSpaces(level);//calling method to print spaces
                Console.WriteLine(file.Name);//writing file's name
            }

            foreach (DirectoryInfo d in directories)//loop to show all directories in current directory
            {
                PrintSpaces(level);//firstly printing space before names
                Console.WriteLine(d.Name);//writing name of directory
                fm(d, level + 1);//calling fm method to enter to the directory and show what is inside of it, adding one level
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Админ\Desktop\pp2");// first directory location
            fm(d,0);// giving function starting values
        }
    }
}
