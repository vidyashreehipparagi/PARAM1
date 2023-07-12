using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAM1
{
    internal class Student
    {
        public void AcceptNames(params string[] names)
        {
            Console.WriteLine("Count "+names.Length);
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
         Student std = new Student();
            std.AcceptNames("Aniket");
            std.AcceptNames("Vidyashree", "Anjali");
            std.AcceptNames("Akshata", "Fahad", "Gorav");
            std.AcceptNames("Snehal", "Benzeer", "Pankaj", "sagar");
            std.AcceptNames("Sagar", "Nilesh", "Girish", "Sanket", "Rahul");
        }
    }
}
