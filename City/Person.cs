using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Person
    {

        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int age { get; set; }
        public string Cnp { get; set; }

        public Person(string name, string emailAddress, int age, string cnp)
        {
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.age = age;
            this.Cnp = cnp;
        }
    }
}
