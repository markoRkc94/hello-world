using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");
            Console.WriteLine("Creating one person.");

            Person person = new Person()
            {
                Name = "Marko",
                LastName = "Stojkovic"
            };

            Console.WriteLine(person);
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();
        }
    }
}
