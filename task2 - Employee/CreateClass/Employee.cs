using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        private int Salary { get; set; }
        private string Profession { get; set; }
        private Room Room { get; set; }

        public Employee(String name, DateTime birtrhDate, String gender, int salary, string profession, Room room) : base(name, birtrhDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.Room = room;
        }
        
        override public string ToString()
        {
            return base.ToString() + " profession:" + Profession + " salary: " + Salary + "\nCurrently in Room #" + Room.Number;
        }
    }
}
