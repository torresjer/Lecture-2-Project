using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            Console.WriteLine("Hello, what is your name user?");
            answer = Console.ReadLine();
            Console.WriteLine("Oh " + answer + " is an intresting name!");

            Console.ReadKey();

            Console.WriteLine("\n\nNow that we got that out of the way what is your mother's maiden name?");
            answer = Console.ReadLine();
            Console.WriteLine("I know your wondering what I need with this information...\n I just wanted to state that " + answer + "is also an intersting name!");
            


            
        }
    }
}
