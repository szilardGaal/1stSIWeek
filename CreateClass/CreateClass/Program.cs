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
            /* ================ Main method for task1 ================ 
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
            */

        /* ================ Main method for task1 ================ 
            Console.WriteLine("Give a new name!");
            String name = Console.ReadLine();
            Console.WriteLine("give the persons profession!");
            String profession = Console.ReadLine();
            Console.WriteLine("give the persons gender(male/female)!");
            String gender = createGender();
            int salary = getIntegerInput("please give " + name + " a salary!");
            int roomNumber = getIntegerInput("please tel which room he/she is in!");

            Person person = new Employee(name, DateTime.Today.Date, gender, salary, profession, new Room(roomNumber));

            Console.WriteLine(person.toString());
            Console.ReadLine();

            String createGender()
            {
                while (true)
                {
                    String genderString = Console.ReadLine();
                    if (genderString.ToLower() == "male" || genderString.ToLower() == "female")
                    {
                        return genderString;
                    }
                    else
                    {
                        Console.WriteLine("Invalid gender: " + genderString + "\nPlease give a valid gender!(male/female)");
                        continue;
                    }
                }
            }

            int getIntegerInput(string message)
            {
                while (true)
                {
                    Console.WriteLine(message + "!\n(should be a valid number!)");
                    string salaryInput = Console.ReadLine();
                    try
                    {
                        int salaryInt = Int32.Parse(salaryInput);
                        return salaryInt;
                    } catch (FormatException ex)
                    {
                        Console.WriteLine(salaryInput + " is not a number!");
                    }
                }
            }
        */
        }
    }
}
