using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo_LinkedList10_15.Classes
{
    class LList
    {
        /// <summary>
        /// Always points to the first node in the LL
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// The node that is used to traverse through the LL
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// LL requires a node at time of creation to be the HEAD; 
        /// hence the constructor below
        /// </summary>
        /// <param name="node"></param>
        public LList(Node node)
        {
            Head = node;
            Current = node;
        }

        // adding a node at the beginning of LL: O(1) time
        // space: O(n)
        public void Add(Node node)
        {
            Current = Head;//this line is optional
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        // we must traverse in order to print, so O(n)
        // not allocating additional memory; just traversing what is given to us O(1) space
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} --> NULL");
            Current = Head;
        }

        // must traverse, so it's O(n)
        // not adding additional memory; space O(1)
        public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
            Current = Head;
        }

        // we have to traverse so big O is O(n)
        // working with what's given to you so space is O(1)
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if(Head.Value == existingNode.Value)
            {
                Add(newNode);
                return; 
            }

            while(Current.Next != null)
            {
                if(Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
                 
            }
        }

        //Add After
        //Add Find
    }
}
