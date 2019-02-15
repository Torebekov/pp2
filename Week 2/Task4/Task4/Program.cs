using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path, path2;
            path = Console.ReadLine();//first path is original location of file
            path2 = Console.ReadLine();// second path is future location of copied file
            FileInfo file = new FileInfo(path);//creating new variable
            file.CopyTo(path2);// copying file to another location
            file.Delete();//deleting original file
        }
    }
}