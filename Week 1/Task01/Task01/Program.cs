using System;
public class Task1
{
    public static bool prime(int num)//function to identify prime numbers
    {
        if (num == 1)
        return false; //if number is one then it isn't prime number
        if (num == 2)
        return true; //if number is two, it is a prime number 
        for (int i = 2; i < num; i++)
        if (num % i == 0)
        return false;//if result of dividing of a number is equal to zero then it is not prime
        return true;//return true if number is prime after passing loop
    }
    public static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());//create variable to store quantity of numbers which will be entered, read from console and convert to integer
        string[] arr = Console.ReadLine().Split();//create array of strings to store numbers from line and after spliting them
        int[] a = new int[x];//creating array to store prime numbers
        int l = 0;// incrementer to count number of primes
        
        for(int i=0; i<x;++i)
        {
            int n = int.Parse(arr[i]);// implementing new variable to store number from string array converted to integer
            if (prime(n))//Checking number
            {
                a[l] = n;//Stroring prime number to array
                l++;//incrementing l
            }
                
        }
        Console.WriteLine(l);//Writing number of prime numbers
        for (int i = 0; i < l; ++i)
            Console.Write(a[i]+" ");// Using loop to write all prime numbers
    }
}