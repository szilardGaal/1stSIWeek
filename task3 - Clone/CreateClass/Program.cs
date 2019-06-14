using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Kovacs = new Employee("Géza", DateTime.Now, "male", 123, "léhűtő", new Room(1));
            Kovacs.room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.room.number = 112;
            Console.WriteLine(Kovacs.toString());
            Console.WriteLine(Kovacs2.toString());
            Console.ReadKey();
        }
    }
}