using Lab05_OOPPrinciples.Classes;
using System;

namespace Lab05_OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string Animal()
        {
            // instantiate a new animal object
            Animal animal = new Animal();

            animal.Mammal = "feline";
            animal.Aviary = "tropical bird";
            animal.Crustacean = "shrimp";
        }
    }
}
