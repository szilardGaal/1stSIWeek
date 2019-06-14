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
            
            Console.WriteLine("Give a new name!");
            String name = Console.ReadLine();
            Console.WriteLine("give the persons gender(male/female)!");
            String gender;
            while (true)
            {
                gender = Console.ReadLine();
                if (gender.ToLower() == "male" || gender.ToLower() == "female")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid gender: " + gender + "\nPlease give a valid gender!(male/female)");
                    continue;
                }
            }
            Person person = new Person(name, DateTime.Today, gender);
            Console.WriteLine("A new person has born today: " + person.toString());
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
