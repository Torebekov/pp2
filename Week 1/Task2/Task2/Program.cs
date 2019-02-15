using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class student
    {
        public string name;
        public int id;
        public int year;//creating name, id, year variables

        public student()//empty constructor
        {
            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());//Reading values from console
            y();//calling y method
        }

        public student(string name, int id)// constructor with two parameters
        {
            this.name = name;//there are two name variables, two identify class's main variables use this
            this.id = id;
            y();
        }

        public void y()// method to get year
        {
            year = int.Parse(Console.ReadLine())+1;// Reading and giving value to year and incrementing it
            Console.Write(year+" ");// Write to console year firstly
        }
        public override string ToString()//altering method ToString to make name and id values as one string 
        {
            return name + " " + id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();// creating new and empty variable of class student
            Console.WriteLine(s);
            student k = new student("Torebekov",111);//creating and giving two values to another variable of class
            Console.WriteLine(k);
        }

    }
}
