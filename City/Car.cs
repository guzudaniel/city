using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Car
    {
        public string marca { get; set; }
        public int an { get; set; }
        public string capacitate_motor { get; set; }
        public Person person { get; set; }

    public Car(string marca, int an, string capacitate, Person person)
        {
            this.marca = marca;
            this.an = an;
            this.capacitate_motor = capacitate;
            this.person = person;
        }

        
    }
}
