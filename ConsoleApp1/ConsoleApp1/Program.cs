using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat
    {
        private string name;
        private int  age; 
        public Cat (string name, int age)
        {
            this.name = name;
            this.age = age; 
        }
        public string meow()
        {
            return name + " "+ "meow"; 
        }
       
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat meow = new Cat("alex", 5);
            Console.WriteLine(meow.meow());
            Console.ReadKey(); 

        }
    }
}
