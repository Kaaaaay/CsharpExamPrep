using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Dog d = new Dog();
            d.Bark();
            d.Move();
            */

            IAnimal d = new Dog();
            Cat c = new Cat();
            d.Move();

            MoveAnimal(d);

            MoveAnimal(c);


        }
        static void MoveAnimal(IAnimal animal)
        {
            animal.Move();
        }
    }
}
