using System;

class PersonsTest
{
    static void Main()
    {
        Person g = new Person("Georgi", "Georgiev");
        Console.WriteLine(g);

        Person i = new Person("Ivan", "Ivanov", "ivan.ivanov@gmail.com");
        Console.WriteLine(i);

        Person m = new Person("Mariika", "Petrova", "gre6enemail");
        Console.WriteLine(m);
    }
}
