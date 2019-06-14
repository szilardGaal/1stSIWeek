using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerEvents
{
    class Person
    {
        protected String name { get; set; }
        protected DateTime birthDate { get; }
        protected Gender gender { get; }

        public Person(String name, DateTime birthDate, String gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            Gender genderEnum;
            Enum.TryParse<Gender>(gender, out genderEnum);
            this.gender = genderEnum;
        }

        
        public virtual string toString()
        {
            string genderString = gender.ToString();
            return birthDate + " " + genderString + " " + name;
        }
    }

    enum Gender
    {
        MALE,
        FEMALE
    }
}
