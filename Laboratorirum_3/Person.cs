using System;
using System.Drawing;

namespace Laboratorirum_3
{
    public class Person
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

        public override string ToString()
        {
            return name.ToString() + " " + surname.ToString() + " " + age.ToString() + " " + location.ToString();
        }
    }
}
