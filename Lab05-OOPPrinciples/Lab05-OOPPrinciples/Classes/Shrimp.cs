using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    // Inheriting Crustacean class 
    public class Shrimp : Crustacean
    {
        public bool Delicious { get; set; }
        public virtual int Legs { get; set; } = 8;
    }
}
