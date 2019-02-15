using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// number of rows of startriangles
            string[,] arr = new string[n,n];// creating 2D array
            for (int i=0;i<n;i++)//loop for rows and n size
            {
                for (int j = 0; j <= i; j++)//loop for columns size is depend on value of i
                {
                    arr[i,j] = "[*]";//giving values two cells of 2D array
                    Console.Write(arr[i,j]);//output of program
                }
                Console.WriteLine();
            }
        }
    }
}
