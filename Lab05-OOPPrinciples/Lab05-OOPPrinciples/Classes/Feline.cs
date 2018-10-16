using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{ 
    // Inheriting Mammal class
    class Feline : Mammal
    {
        public int Paws { get; set; }
        public bool Claws { get; set; }
        public virtual int Whiskers { get; set; } = 10;
    }   
}
