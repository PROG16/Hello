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
            Console.WriteLine("Philippe was here!");
            Console.WriteLine("Fredrik was here!");
            Console.WriteLine("Klas was here!");
            Console.WriteLine("Khalid was here!");
            Console.WriteLine("Fredrik was here!");
            Console.WriteLine("Patrik too");
            Console.WriteLine(jesper.Speak());
            Console.WriteLine("Isabella");
            Console.WriteLine("Fredrik was here!");
            Console.WriteLine("Erik Jonson was here");
            Console.WriteLine("Fredrik was here!");
            Console.WriteLine("Mattias was here!");
            Console.WriteLine("Philippe was here!");
            Console.WriteLine("Andreas was also here omg!!");
            Console.WriteLine("Nu blir det en mergekonflikt - som jag löst!");
            Console.WriteLine("Patrik too");
            Console.WriteLine("Anna was here!");
            Console.WriteLine("Matilda was here!");
            Console.WriteLine("Patrik too");
            Console.WriteLine("Cornelia här på avstånd. :) Vi ses imorgon! (Testar att faktiskt merga nu)");
            Console.WriteLine("Tanja was here!");
            Console.WriteLine("Second time Philippe was here!");
            Console.WriteLine("Filip is here");
            Console.ReadLine();                    
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
