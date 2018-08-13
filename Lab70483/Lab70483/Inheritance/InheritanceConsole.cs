using System;
using System.Collections.Generic;
using System.Text;

namespace Lab70483.Inheritance
{
    class InheritanceConsole
    {
        static void Main() {

            // Nao tenho acesso a nada da classe animal pois sao metodos protegidos.
            Animal animal = new Animal();

            Cat cat = new Cat();
            Console.Write("My CAT");
            Console.Write(cat.Checkin());
            Console.Write(cat.FeedWithMilk());
            Console.Write(cat.Vacine());
            Console.Write(cat.CheckBalance());

            Dog dog = new Dog();
            Console.Write("\nMy DOG");
            Console.Write(dog.FeedWithMeat());
            Console.Write(dog.Checkin());

            Console.Read();
        }
    }
}
