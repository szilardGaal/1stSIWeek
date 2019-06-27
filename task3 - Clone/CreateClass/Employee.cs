using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int Salary { get; set; }
        private string Profession { get; set; }
        public Room Room { get; set; }

        public Employee(String name, DateTime birtrhDate, String gender, int salary, string profession, Room room) : base(name, birtrhDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.Room = room;
        }

        public object Clone()
        {
           /* Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.room = new Room(room.number);
            return newEmployee;*/
            return this.MemberwiseClone();
        }
        
        override public string ToString()
        {
            return base.ToString() + " profession:" + Profession + " salary: " + Salary + "\nCurrently in Room #" + Room.Number;
        }
    }
}
