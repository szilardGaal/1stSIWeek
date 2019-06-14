using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        private String name;
        private DateTime birthDate;
        private Gender gender;

        public Person(String name, DateTime birthDate, String gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            Gender genderEnum;
            Enum.TryParse<Gender>(gender, out genderEnum);
            this.gender = genderEnum;
        }


        public string toString()
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
