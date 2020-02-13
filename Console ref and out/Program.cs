using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ref_and_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            string message = MakeGreeting(name);
            Console.WriteLine(message);

            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            int namelength = FullName(name, lastName, out string fullname);
            Console.WriteLine("Your full name is " fullname + ". It has this many letters: ") + namelength);
            FullName(name, lastName, out string fullname);
            Console.WriteLine("Your full name is " + fullname + ". It has this many letters:  " + namelength);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
                 
        }

        static string MakeGreeting(string name) // This method is collapsed to save space
        {
            
        }

        static int FullName( string firstName, string lastName, out string fullname) 
        {
            fullname = firstName + " " + lastName;
            return fullname.Length;
        }
    }
}
