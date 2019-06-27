using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        protected String Name { get; set; }
        protected DateTime BirthDate { get; }
        protected Gender Gender { get; }

        public Person(String name, DateTime birthDate, String gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            Gender genderEnum;
            Enum.TryParse<Gender>(gender, out genderEnum);
            this.Gender = genderEnum;
        }

        
        public override string ToString()
        {
            string genderString = Gender.ToString();
            return BirthDate + " " + genderString + " " + Name;
        }
    }

    enum Gender
    {
        MALE,
        FEMALE
    }
}
