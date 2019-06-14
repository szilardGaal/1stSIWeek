using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private int salary { get; set; }
        private string profession { get; set; }
        private Room room { get; set; }

        public Employee(String name, DateTime birtrhDate, String gender, int salary, string profession, Room room) : base(name, birtrhDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
            this.room = room;
        }
        
        override public string toString()
        {
            return name + " " + profession + " salary: " + salary + "\nborn in: " + birthDate + "\nCurrently in Room #" + room.number;
        }
    }
}
