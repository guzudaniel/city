using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class School : Building
    {
        public string name { get; set; }
        public Person director { get; set; }
        public List<Person> teachers { get; set; }
        public string phoneNumber { get; set; }

        public School(string name, Street street, int number)
        {
            this.name = name;
            this.street = street;
            this.number = number;
        }

    }
}
