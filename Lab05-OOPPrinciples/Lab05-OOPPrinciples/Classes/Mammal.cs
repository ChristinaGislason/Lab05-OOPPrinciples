using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    //Inheriting Animal class
    class Mammal : Animal 
    {
        public bool Hair { get; set; }
        public bool LiveBirth { get; set; }
        public bool DrinksMilk { get; set; }
    }
}
