using Lab05_OOPPrinciples.Classes;
using System;

namespace Lab05_OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            OverrideAbstractMethods();
            OverrideAbstractProperties();
            OverrideVirtualMethods();
            OverrideVirtualProperties();
            Jaguar testJaguar = new Jaguar();
            Console.WriteLine(testJaguar.Sleep);
            Krill testKrill = new Krill();
            Console.WriteLine(testKrill.Swim);
        }

        static void OverrideAbstractMethods()
        {
            Cat cat = new Cat();
            Console.WriteLine(cat.Bites());
            Console.WriteLine(cat.Cry());
            Jaguar jaguar = new Jaguar();
            Console.WriteLine(jaguar.Bites());
            Console.WriteLine(jaguar.Cry());
        }

        static void OverrideAbstractProperties()
        {
            Toucan toucan = new Toucan();
            Console.WriteLine($"A toucan has colorful plumage: {toucan.ColorfulPlumage}");
            Console.WriteLine($"{toucan.TropicalHabitat}");
            Parrot parrot = new Parrot();
            Console.WriteLine($"A parrot has colorful plumage: {parrot.ColorfulPlumage}");
            Console.WriteLine($"{parrot.TropicalHabitat}");
        }

        static void OverrideVirtualMethods()
        {
            // Override two virtual methods
            // Create animal objects and instantiate concrete animals
            Parrot parrot = new Parrot();
            Console.WriteLine(parrot.Fly());
            Toucan toucan = new Toucan();
            Console.WriteLine(toucan.Fly());

            Krill krill = new Krill();
            Console.WriteLine(krill.BeEaten());
            Langostino langostino = new Langostino();
            Console.WriteLine(langostino.BeEaten());
        } 

        static void OverrideVirtualProperties()
        {
            // Override two virtual properties 
            Cat cat = new Cat();
            Console.WriteLine($"Cat has {cat.Whiskers} whiskers, not 10!");

            Langostino langostino = new Langostino();
            Console.WriteLine($"Langostino has {langostino.Legs} legs, not 6!");
        }       
    }
}
