using System;
using External.Sdk;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Id = new Random().Next(int.MaxValue),
                Name = "Jan Kowalski",
                Address = new Address
                {
                    City = "Gdynia",
                    Street = "Sezam str 13"
                }
            };

            Console.WriteLine(person);
        }
    }
}