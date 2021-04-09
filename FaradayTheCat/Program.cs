using System;

namespace FaradayTheCat
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Cat faraday = new Cat("Vasea", Cat.Gender.Male);
            Console.WriteLine(faraday.Energy);
            faraday.Jump();
            faraday.Sleep();





        }
    }
}
