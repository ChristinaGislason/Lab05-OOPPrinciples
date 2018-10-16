using Lab05_OOPPrinciples.Classes;
using System;

namespace Lab05_OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            OverrideAbstractMethods();
            //OverrideAbstractProperties();
            //OverrideVirtualMethods();
            //OverrideVirtualProperties();
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

        //static void OverridebstractProperties();

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
            Console.WriteLine($"I now have {cat.Whiskers} whiskers, not 10!");

            Langostino langostino = new Langostino();
            Console.WriteLine($"I now have {langostino.Legs} legs, not 6!");
        }

        



        // create animal object and instantiate concrete animals
        //Jaguar jaguar = new Jaguar();
        //Cat cat = new Cat();
        //Krill krill = new Krill();
        //Langostino langostino = new Langostino();
    }
}
