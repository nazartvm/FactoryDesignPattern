using System;

namespace BasicDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryDesignPattern factory = new FactoryDesignPattern();
            Imember member = factory.FactoryMethod("lifemember");
            member.register();
            Console.ReadLine();
        }
    }
}
