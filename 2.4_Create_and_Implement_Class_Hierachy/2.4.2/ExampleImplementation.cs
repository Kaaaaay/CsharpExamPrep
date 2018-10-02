using System;
namespace Application
{
    public class Dog: IAnimal
    {
        public void Bark()
        {
            Console.WriteLine("Woof Woof");
        }

        public void Move()
        {
            Console.WriteLine("Dog Move");
        }
    }

    class Cat:IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Cat Move");
        }
    }
}
