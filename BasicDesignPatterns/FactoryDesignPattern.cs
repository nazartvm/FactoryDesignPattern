using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDesignPatterns
{
    /// <summary>
    /// factory class which helps to create a object
    /// </summary>
    class FactoryDesignPattern
    {
        public Imember FactoryMethod(string type)
        {
            switch (type)
            {
                case "lifemember":
                    return new LifeMember();
                case "annualmember":
                    return new AnnualMember();
                case "tempmember":
                    return new TempMember();
            }
            throw new Exception("pass correct member type");
        }
    }
    /// <summary>
    /// Interface which holds the member methods
    /// </summary>
    public interface Imember
    {
        void register();
        void notify();
    }
    /// <summary>
    /// Life member class
    /// </summary>
    public class LifeMember:Imember
    {
        public void register()
        {
            Console.WriteLine("I am  a life time member");
        }
        public void notify() {
            Console.WriteLine("Life time member notified");
        }
    }
    /// <summary>
    /// annual member class
    /// </summary>
    public class AnnualMember : Imember
    {
        public void register()
        {
            Console.WriteLine("I am  a annual time member");
        }
        public void notify()
        {
            Console.WriteLine("Annual time member notified");
        }
    }
    /// <summary>
    /// Temp member class
    /// </summary>
    public class TempMember : Imember
    {
        public void register()
        {
            Console.WriteLine("I am  a temp time member");
        }
        public void notify()
        {
            Console.WriteLine("Temp time member notified");
        }
    }
}
