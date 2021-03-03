using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class House : Building
    {
        public List<Person> people { get; set; }

        public House(Street street, int number)
        {
            this.street = street;
            this.number = number;
        }
    }
}
