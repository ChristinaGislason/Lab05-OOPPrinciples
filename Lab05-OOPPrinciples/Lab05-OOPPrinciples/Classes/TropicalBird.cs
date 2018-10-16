using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{ 
    // Inheriting Aviary class
    abstract class TropicalBird : Aviary
    {
        public abstract string TropicalHabitat { get; set; }
        public abstract bool ColorfulPlumage { get; set; } 
    }  
}
