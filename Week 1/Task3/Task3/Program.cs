using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void arr(int n,string[] s)//method to make array of doubled numbers
        {
            int[] a = new int[n];//first array of numbers
            int[] a2 = new int[n * 2];// second array with twice size of first array
            int j = 0;//variable to help giving values to second array
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(s[i]);//a array is saving numbers from string array as an integer
                a2[j] = a[i];
                a2[j + 1] = a[i];// giving values to second array
                j += 2;//adding two because first two cells of array already have values
            }
            foreach (var m in a2)// loop to show elements of second array
            {
                Console.Write(m + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//creating variable n and reading value from console which is equal to quantity of numbers 
            string[] s = Console.ReadLine().Split();//creating array of strings and reading values from console spliting spaces
            arr(n, s);//calling and giving two parameters to arr method
        }
    }
}
