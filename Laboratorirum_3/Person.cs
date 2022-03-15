using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorirum_3
{
    class Person
    {
        public string name;
        public string surname;
        public double age;
        public string location;

        public Person(string Name, string Surname, double Age, string Location)
        {
            name = Name;
            surname = Surname;
            age = Age;
            location = Location;
        }

        public string ToStringInformation()
        {
            return name.ToString() + " " + surname.ToString() + " " + age.ToString() + " " + location.ToString();
        }
    }
}
