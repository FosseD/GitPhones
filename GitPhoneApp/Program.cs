using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commit!");
            Console.WriteLine("Making a change");
            Console.WriteLine("Ange ett namn:");
            string name = Console.ReadLine();
            if (name == "Dennis")
            {
                Console.WriteLine("Äru go eller?");
            }
            else
            {
                Console.WriteLine("Hallå eller");
            }
            //
        }
    }
}
