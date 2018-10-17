using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOPPrinciples.Classes
{
    public class Animal : ISleep
    {
        public int Eyes { get; set; }
        public bool Breathe { get; set; }
        public string Sound { get; set; }
        public string Sleep
        {
            get
            {
                return "Zzzzzz. Animals sleep!";
            }
            set
            {
                
            }
        }
    }
    
}
