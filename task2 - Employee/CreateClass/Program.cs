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
            Console.WriteLine("give the persons profession!");
            String profession = Console.ReadLine();
            Console.WriteLine("give the persons gender(male/female)!");
            String gender = CreateGender();
            int salary = GetIntegerInput("please give " + name + " a salary!");
            int roomNumber = GetIntegerInput("please tel which room he/she is in!");

            Person person = new Employee(name, DateTime.Today.Date, gender, salary, profession, new Room(roomNumber));

            Console.WriteLine(person.ToString());
            Console.ReadLine();

            String CreateGender()
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

            int GetIntegerInput(string message)
            {
                while (true)
                {
                    Console.WriteLine(message + "!\n(should be a valid number!)");
                    string salaryInput = Console.ReadLine();
                    try
                    {
                        int salaryInt = Int32.Parse(salaryInput);
                        return salaryInt;
                    } catch (FormatException)
                    {
                        Console.WriteLine(salaryInput + " is not a number!");
                    }
                }
            }
        }
    }
}
