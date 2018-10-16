using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    //Inheriting Animal class
    public abstract class Mammal : Animal 
    {
        public bool Hair { get; set; }
        public bool LiveBirth { get; set; }
        public bool DrinksMilk { get; set; }

        public abstract string Cry();
    }
}
