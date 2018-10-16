using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inheriting Animal class
    public class Aviary : Animal
    {
        public bool Beak { get; set; }
        public int Wings { get; set; }

        public virtual string Fly()
        {          
            return "I can fly!";
        } 
    }

    
}
