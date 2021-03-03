using System;

namespace City
{
    class City
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Pop  Mihai", "pop.mihai@gmail.com", 21, "7835627901");
            Person p2 = new Person("Teodorescu Alex", "t_alex@gmail.com", 56, "6534562552");
            Person p3 = new Person("Pop  Alin", "alinpop@emanuel.ro", 33, "1234567343");
            Person p4 = new Person("Stir Robert", "robertstt10@yahoo.com", 18, "2345265267");
            Person p5 = new Person("Magda Viorel", "magdaviorel@gmail.com", 45, "9673563562");
            Person p6 = new Person("Preda Filip", "filip_preda1999@gmail.com", 20, "1234567856");
            Person p7 = new Person("Petrican Damaris", "petrican_damaris@gmail.com", 18, "8765432124");
            Person p8 = new Person("Ioan Denisa", "denisa.ioan2000@gmail.com", 17, "8642456435");
            Person p9 = new Person("Suciu Sergiu", "sergiuboss@gmail.com", 15, "5642738263");

            Car car1 = new Car("BMW", 2019, "2000", p2);
            Car car2 = new Car("Audi", 2006, "1900", p5);
            Car car3 = new Car("Ford", 2020, "3200", p1);

            Street street1 = new Street("Tudor Popescu", 1);
            Street street2 = new Street("Parcului", 2);
            Street street3 = new Street("Principala", 3);

            Building school1 = new School("Scoala Generala Avraam Iancu", street3, 34);
            Building house1 = new House(street1, 10);
            Building house2 = new House(street1, 101);
            Building house3 = new House(street1, 32);
            Building house4 = new House(street1, 9);
            Building house5 = new House(street3, 2);
            Building house6 = new House(street3, 10);
            Building house7 = new House(street2, 989);
            Building house8 = new House(street2, 672);
            Building house9 = new House(street1, 47);

        }
    }
}
