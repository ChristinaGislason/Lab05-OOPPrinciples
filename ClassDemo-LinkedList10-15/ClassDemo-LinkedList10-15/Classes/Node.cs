using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo_LinkedList10_15.Classes
{
    class Node
    {
        public object Value { get; set; } // "object " is the root datatpye of all datatypes
        public Node Next { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}
