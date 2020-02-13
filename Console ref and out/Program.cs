using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Out keyword has ability to carry data away from a method and sends back greater than one value in one direction.
 * Furthermore, compiler needs value to be assigned to call function.  On the other hand, ref keyword
 * informs the compiler regarding to object needs to be initialized prior to go through the method. It has two directions. 
 */

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
            Console.WriteLine("Your full name is " fullname + ". It has this many letters: ") + namelength;
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
