using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inheriting Feline class   
    class Cat : Feline
    {
        public bool Domesticated { get; set; }
        public bool LovesCatnip { get; set; }
        
        // Virtual property from Feline that Cat overrides
        public override int Whiskers { get; set; } = 4;

        public override string Bites()
        {
            return "Cats bite!";
        }

        public override string Cry()
        {
            return "Cats meow to cry.";
        }

    }
}
