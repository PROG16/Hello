using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var jesper = new Jesper();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fredrik was here!");
            Console.WriteLine("Patrik too");
            Console.WriteLine(jesper.Speak());
        }

        internal class Jesper
        {
            public string Speak()
            {
                return "Jesper was here";
            }
        }
    }
}
